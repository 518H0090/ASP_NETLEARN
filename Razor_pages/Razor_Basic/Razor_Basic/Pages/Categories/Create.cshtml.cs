using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Basic.Data;
using Razor_Basic.Models;

namespace Razor_Basic.Pages.Categories
{
    //[BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        //[BindProperty]
        public Category category { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(Category category)
        {
            if(category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name","The DisplayOrder Match Name");
            }

           if(ModelState.IsValid)
            {
                await _db.categories.AddAsync(category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Create Succesfully";
                return RedirectToPage("Index");
            }

           return Page();
        }
    }
}
