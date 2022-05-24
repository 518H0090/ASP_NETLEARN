using ASP001.Data;
using ASP001.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP001.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

       public IActionResult Index()
        {
            IEnumerable<Category> objCategory = _db.categories.ToList();
            return View(objCategory);
        }
    }
}
