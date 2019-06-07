using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sokokapu_Stock_Management.Data.Interfaces;
using Sokokapu_Stock_Management.Models;
using Sokokapu_Stock_Management.ViewModels;
using System;
using System.IO;
using System.Linq;

namespace Sokokapu_Stock_Management.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHostingEnvironment _environment;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, IHostingEnvironment environment)
        {
            _environment = environment;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var products = _productRepository.AllProducts();

            var model = products.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                ImageUrl = p.ImageUrl,
                ProductName = p.ProductName,
                Description = p.Description,
                Price = p.Price,
                Size = p.Size,
                InStock = p.InStock

            });


            return View(model);

        }

        #region Sold
        //TODO Just like editing
        public ActionResult Sold(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            else
            {
                Product model = _productRepository.GetProductById(id);

                EditProductVM edit = new EditProductVM
                {
                    Id = model.Id,
                    ProductName = model.ProductName,
                    Description = model.Description,
                    Price = model.Price,
                    Color = model.Color,
                    Quantity = model.Quantity,
                    NumberSold = model.NumberSold,
                    Size = model.Size,
                    ExistingImage = model.ImageUrl,
                    CategoryId = model.CategoryId,
                    _Category = model._Category,

                };

                ViewBag.CategoryId = new SelectList(_categoryRepository.AllCategories(), "Id", "Name", edit.CategoryId);
                return View(edit);

            }

        }

        //TODO
        //POST: Default/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sold(EditProductVM model, int Sold)
        {
            if (ModelState.IsValid)
            {

                Product product = new Product
                {
                    Id = model.Id,
                    ProductName = model.ProductName,
                    Description = model.Description,
                    Price = model.Price,
                    Color = model.Color,
                    Quantity = model.Quantity,
                    Size = model.Size,
                    ImageUrl = model.ExistingImage,
                    CategoryId = model.CategoryId,
                    _Category = model._Category,
                    NumberSold = model.NumberSold + Sold
                };
                _productRepository.Edit(product);

            }

            return RedirectToAction("ManageProduct");
        }

        #endregion

        [Authorize]
        public IActionResult ManageProduct()
        {


            var products = _productRepository.AllProducts();

            return View(products);

        }

        #region Create

        public IActionResult Create()
        {

            ViewBag.CategoryId = new SelectList(_categoryRepository.AllCategories(), "Id", "Name");
            return View();


        }
        [HttpPost]
        public ActionResult Create(AddProductVM model)
        {

            if (ModelState.IsValid)
            {
                string uniqueFileName = FileCheck(model);
                model.NumberSold = 0;
                Product product = new Product
                {

                    ProductName = model.ProductName,
                    Description = model.Description,
                    Price = model.Price,
                    Color = model.Color,
                    Quantity = model.Quantity,
                    NumberSold = model.NumberSold,
                    Size = model.Size,
                    ImageUrl = uniqueFileName,
                    CategoryId = model.CategoryId,
                    _Category = model._Category

                };
                _productRepository.Add(product);
                return RedirectToAction(nameof(ManageProduct));


            }
            ViewBag.CategoryId = new SelectList(_categoryRepository.AllCategories(), "Id", "Name");

            return View();
        }

        #endregion

        #region Edit
        //Get
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            else
            {
                Product model = _productRepository.GetProductById(id);

                EditProductVM edit = new EditProductVM
                {
                    Id = model.Id,
                    ProductName = model.ProductName,
                    Description = model.Description,
                    Price = model.Price,
                    Color = model.Color,
                    Quantity = model.Quantity,
                    NumberSold = model.NumberSold,
                    Size = model.Size,
                    ExistingImage = model.ImageUrl,
                    CategoryId = model.CategoryId,
                    _Category = model._Category,

                };

                ViewBag.CategoryId = new SelectList(_categoryRepository.AllCategories(), "Id", "Name", edit.CategoryId);
                return View(edit);

            }

        }

        //POST: Default/Edit/5
        [HttpPost]

        public ActionResult Edit(EditProductVM model)
        {

            if (ModelState.IsValid)
            {

                Product product = new Product
                {
                    Id = model.Id,
                    ProductName = model.ProductName,
                    Description = model.Description,
                    Price = model.Price,
                    Color = model.Color,
                    Quantity = model.Quantity,
                    NumberSold = model.NumberSold,
                    Size = model.Size
                };


                if (model.Photo != null)
                {
                    if (model.ExistingImage != null)
                    {
                        string filep = Path.Combine(_environment.WebRootPath, "images/", model.ExistingImage);
                        System.IO.File.Delete(filep);
                    }
                    product.ImageUrl = FileCheck(model);
                }
                else
                {
                    product.ImageUrl = model.ExistingImage;
                }

                product.CategoryId = model.CategoryId;
                product._Category = model._Category;

                _productRepository.Edit(product);


            }

            ViewBag.CategoryId = new SelectList(_categoryRepository.AllCategories(), "Id", "Name", model.CategoryId);

            return RedirectToAction("ManageProduct");
        }

        #endregion

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {

            Product product = _productRepository.GetProductById(id);
            if (id <= 0)
            {
                return NotFound();
            }
            else
            {
                ProductViewModel model = new ProductViewModel()
                {

                    Id = product.Id,
                    ImageUrl = product.ImageUrl,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    Price = product.Price,
                    Size = product.Size,
                    InStock = product.InStock
                };
                return View(model);
            }


        }

        #region Delete
        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var product = _productRepository.GetProductById(id);



            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var p = _productRepository.GetProductById(id);
            if (p.ImageUrl != null)
            {
                string filep = Path.Combine(_environment.WebRootPath, "images/", p.ImageUrl);
                System.IO.File.Delete(filep);
            }

            _productRepository.Delete(id);

            return RedirectToAction(nameof(Index));
        }
        #endregion

        private string FileCheck(AddProductVM model)
        {
            string uniqueFileName = null;
            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, "images/");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder + uniqueFileName);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(filestream);
                }


            }

            return uniqueFileName;
        }


    }

}
