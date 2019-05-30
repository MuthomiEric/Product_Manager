using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sokokapu_Stock_Management.Data.Interfaces;
using Sokokapu_Stock_Management.Models;
using Sokokapu_Stock_Management.ViewModels;
using System;
using System.Linq;

namespace Sokokapu_Stock_Management.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
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

        //TODO Just like editing
        public ActionResult Sold(int id)
        {
            var product = _productRepository.GetProductById(id);


            return View(product);
        }




        //POST: Default/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sold(int id, Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _productRepository.Update(product);

                return RedirectToAction(nameof(ManageProduct));
            }

            return View();
        }
        public IActionResult ManageProduct()
        {
            var products = _productRepository.AllProducts();

            return View(products);

        }

        #region Create

        public IActionResult Create()
        {

            ViewBag.CategoryId = new SelectList(_categoryRepository.Categories(), "Id", "CatName");
            return View();


        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Add(product);
                return RedirectToAction(nameof(Index));
            }
            else
                throw new Exception("Not valid");


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


                var product = _productRepository.GetProductById(id);
                ViewBag.CategoryId = new SelectList(_categoryRepository.Categories(), "Id", "CatName", product.CategoryId);
                return View(product);

            }

        }

        //POST: Default/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _productRepository.Update(product);

                return RedirectToAction(nameof(ManageProduct));
            }

            return View();
        }
        #endregion

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);

            var model = new ProductViewModel()
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
            _productRepository.Delete(id);

            return RedirectToAction(nameof(Index));
        }
        #endregion

    }
}
