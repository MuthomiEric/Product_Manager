using Microsoft.AspNetCore.Mvc;
using Sokokapu_Stock_Management.Data.Interfaces;
using Sokokapu_Stock_Management.Models;

namespace Sokokapu_Stock_Management.Controllers
{
    public class CategoryController : Controller
    {


        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

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
                Category category = _categoryRepository.GetCategoryById(id);
                return View(category);
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

        // GET: Products/Details/5
        public ActionResult Details(int id)
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

        #region Delete
        //// GET: Products/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    if (id <= 0)
        //    {
        //        return NotFound();
        //    }
        //    var category = _categoryRepository.GetCategoryById(id);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(category);
        //}

        //// POST: Products/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //   _categoryRepository.Delete(id);

        //    return RedirectToAction(nameof(ManageCategories));
        //}
        #endregion

    }
}
