using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Basic.Data;
using Razor_Basic.Models;

namespace Razor_Basic.Pages.Categories
{
    //[BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        //[BindProperty]
        public Category category { get; set; }

        public EditModel(ApplicationDbContext db)
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
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder Match Name");
            }

            if (ModelState.IsValid)
            {
                _db.categories.Update(category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Update Succesfully";
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
