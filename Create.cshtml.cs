using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UdemyWeb.Data;
using UdemyWeb.Model;

namespace UdemyWeb.Pages.Admin.Categories
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        [BindProperty]

        public Category Category { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost() //IActionResult is used because I want to return to page or redirect to a view
        {
            await _db.Category.AddAsync(category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }  
    }
}
