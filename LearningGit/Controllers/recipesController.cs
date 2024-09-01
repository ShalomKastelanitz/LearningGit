using LearningGit.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningGit.Controllers
{
    public class recipesController : Controller
    {
        private List<Recipes> recipes = new List<Recipes>
        {
            new Recipes
            {
                Id = 1,
                Name = "Recipe 1",
                Description = "Short description for recipe 1",
                PreparationTime = 30,
                ProductList = new List<string> { "Flour", "Sugar", "Eggs", "Butter" },
                StepsToPerform = new List<string> { "Mix ingredients", "Bake at 180°C for 30 minutes" }
            },
            new Recipes
            {
                Id = 2,
                Name = "Recipe 2",
                Description = "Short description for recipe 2",
                PreparationTime = 45,
                ProductList = new List<string> { "Pasta", "Tomato Sauce", "Cheese" },
                StepsToPerform = new List<string> { "Boil pasta", "Prepare sauce", "Mix and serve" }
            },
            // Add more recipes here
        };

        public ActionResult Index()
        {
            return View(recipes);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Recipes newRecipe)
        {
            // יצירת מזהה חדש למתכון
            newRecipe.Id = recipes.Count + 1;

            // הוספת המתכון החדש לרשימה
            recipes.Add(newRecipe);

            // ניתוב מחדש לעמוד הראשי כדי להציג את כל המתכונים
            return RedirectToAction("Index");
        }

    }
}
