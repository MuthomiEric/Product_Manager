using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sokokapu_Stock_Management.Data.Interfaces;
using Sokokapu_Stock_Management.Models;

namespace Sokokapu_Stock_Management.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {

            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }




        [Authorize]
        public IActionResult ManageCategories()
        {


            var category = _categoryRepository.AllCategories();

            return View(category);

        }

        #region Create

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {

            if (ModelState.IsValid)
            {
                _categoryRepository.Add(category);
                return RedirectToAction(nameof(ManageCategories));
            }

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
                Category model = _categoryRepository.GetCategoryById(id);

                return View(model);

            }

        }

        //POST: Default/Edit/5
        [HttpPost]

        public ActionResult Edit(Category category)
        {

            if (ModelState.IsValid)
            {
                _categoryRepository.Edit(category);
            }

            return RedirectToAction("ManageCategories");
        }

        #endregion

        #region Deactivate
        //Get
        public ActionResult DeActivate(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            else
            {
                Category category = _categoryRepository.GetCategoryById(id);

                return View(category);

            }

        }

        //POST: Default/Edit/5
        [HttpPost]

        public ActionResult DeActivate(Category category)
        {

            if (ModelState.IsValid)
            {

                _categoryRepository.Edit(category);
            }

            return RedirectToAction("ManageCategories");
        }

        #endregion


    }
}