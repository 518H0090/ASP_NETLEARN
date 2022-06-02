using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Basic.Data;
using Razor_Basic.Models;

namespace Razor_Basic.Pages.Categories
{
    //[BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        //[BindProperty]
        public Category category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            category = _db.categories.Find(id);
            //category = _db.categories.FirstOrDefault(x => x.Id == id);
            //category = _db.categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public async Task<IActionResult> OnPost(Category category)
        {


            var categoryFromDb = _db.categories.Find(category.Id);
            if (categoryFromDb != null)
            {
                _db.categories.Remove(categoryFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Delete Succesfully";
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
