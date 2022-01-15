using MenuApp.Data;
using MenuApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuApp.Controllers
{
    public class RecipeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RecipeController(ApplicationDbContext db)
        {
            _db = db; 
        }
        public IActionResult Recipe()

        {
            var randomRecipes = _db.Recipes.OrderBy(r => Guid.NewGuid());
            return View(randomRecipes);
        }
    }
}
