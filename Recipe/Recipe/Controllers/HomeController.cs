using Microsoft.AspNetCore.Mvc;
using Recipe.ViewModel;
using System.Diagnostics;

namespace Recipe.Controllers
{
    using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new RecipeViewModel());
    }

    [HttpPost]
    public IActionResult Index(RecipeViewModel recipe)
    {
        return Content($"Recipe: {recipe.Name} with {recipe.Ingredients?.Count ?? 0} ingredients!");
    }
}
}
