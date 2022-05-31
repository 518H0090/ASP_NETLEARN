using ASP002.Data;
using ASP002.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP002.Controllers
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
            IEnumerable<Category> categories = _db.categories.ToList();
            return View(categories);
        }
    }
}
