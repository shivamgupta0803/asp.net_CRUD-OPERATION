
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models;


public class CategoriesController : Controller
{
    public IActionResult Index()
    {
        var categories = CategoriesRepository.GetCategories();
        return View(categories);
    }
    public IActionResult Edit(int? id)
    {
        ViewBag.Action = "edit";
        var category = CategoriesRepository.GetCategoryById(id.HasValue ? id.Value : 0);
        return View(category);
    }

    [HttpPost]
    public IActionResult Edit(Category category)
    {
        if (ModelState.IsValid)
        {

            CategoriesRepository.UpdateCatogary(category.CategoryId, category);
            return RedirectToAction(nameof(Index));
        }
        return View(category);
    }
    public IActionResult Add()
    {
        ViewBag.Action = "add";
        return View();
    }

    [HttpPost]
    public IActionResult Add(Category category)
    {
        if (ModelState.IsValid)
        {
            CategoriesRepository.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }
        return View(category);
    }

    public IActionResult Delete(int categoryId)
    {
        CategoriesRepository.DeleteCatogary(categoryId);
        return RedirectToAction(nameof(Index));
    }


}