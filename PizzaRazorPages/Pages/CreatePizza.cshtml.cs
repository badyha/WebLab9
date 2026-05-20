using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRazorPages.Models;

namespace PizzaRazorPages.Pages;

public class CreatePizzaModel : PageModel
{
    [BindProperty]
    public Pizza Pizza { get; set; } = new();

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Save to database (placeholder)
        return RedirectToPage("PizzaList");
    }
}
