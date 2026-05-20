using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaRazorPages.Pages;

public class Pizza
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Size { get; set; } = "";
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class PizzaListModel : PageModel
{
    public List<Pizza> Pizzas { get; set; } = new();

    public void OnGet()
    {
        // Sample data
        Pizzas = new List<Pizza>
        {
            new() { Id = 1, Name = "Маргарита", Size = "Велика", Price = 150, Quantity = 10 },
            new() { Id = 2, Name = "Пепероні", Size = "Середня", Price = 180, Quantity = 5 },
            new() { Id = 3, Name = "Чотири сири", Size = "Велика", Price = 220, Quantity = 8 }
        };
    }
}
