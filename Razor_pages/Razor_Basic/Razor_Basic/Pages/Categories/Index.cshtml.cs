using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Basic.Data;
using Razor_Basic.Models;

namespace Razor_Basic.Pages.Categories
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _db;
        public IEnumerable<Category> Categories { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        //lấy giá trị category từ database
        public void OnGet()
        {
            Categories = _db.categories.ToList();
        }
    }
}
