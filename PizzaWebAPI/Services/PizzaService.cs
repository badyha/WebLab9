using PizzaWebAPI.Models;

namespace PizzaWebAPI.Services;

public interface IPizzaService
{
    Task<List<Pizza>> GetAllPizzasAsync();
    Task<Pizza?> GetPizzaByIdAsync(int id);
    Task<Pizza> CreatePizzaAsync(Pizza pizza);
    Task<Pizza?> UpdatePizzaAsync(int id, Pizza pizza);
    Task<bool> DeletePizzaAsync(int id);
}

public class PizzaService : IPizzaService
{
    private static List<Pizza> _pizzas = new()
    {
        new() { Id = 1, Name = "Маргарита", Size = "Велика", Price = 150, Quantity = 10 },
        new() { Id = 2, Name = "Пепероні", Size = "Середня", Price = 180, Quantity = 5 },
        new() { Id = 3, Name = "Чотири сири", Size = "Велика", Price = 220, Quantity = 8 }
    };

    private static int _nextId = 4;

    public Task<List<Pizza>> GetAllPizzasAsync()
    {
        return Task.FromResult(_pizzas);
    }

    public Task<Pizza?> GetPizzaByIdAsync(int id)
    {
        return Task.FromResult(_pizzas.FirstOrDefault(p => p.Id == id));
    }

    public Task<Pizza> CreatePizzaAsync(Pizza pizza)
    {
        pizza.Id = _nextId++;
        _pizzas.Add(pizza);
        return Task.FromResult(pizza);
    }

    public Task<Pizza?> UpdatePizzaAsync(int id, Pizza pizza)
    {
        var existingPizza = _pizzas.FirstOrDefault(p => p.Id == id);
        if (existingPizza == null)
            return Task.FromResult<Pizza?>(null);

        existingPizza.Name = pizza.Name;
        existingPizza.Size = pizza.Size;
        existingPizza.Price = pizza.Price;
        existingPizza.Quantity = pizza.Quantity;

        return Task.FromResult<Pizza?>(existingPizza);
    }

    public Task<bool> DeletePizzaAsync(int id)
    {
        var pizza = _pizzas.FirstOrDefault(p => p.Id == id);
        if (pizza == null)
            return Task.FromResult(false);

        _pizzas.Remove(pizza);
        return Task.FromResult(true);
    }
}
