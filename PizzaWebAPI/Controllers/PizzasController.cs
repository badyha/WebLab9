using Microsoft.AspNetCore.Mvc;
using PizzaWebAPI.Models;
using PizzaWebAPI.Services;

namespace PizzaWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PizzasController : ControllerBase
{
    private readonly IPizzaService _pizzaService;

    public PizzasController(IPizzaService pizzaService)
    {
        _pizzaService = pizzaService;
    }

    /// <summary>
    /// Get all pizzas
    /// </summary>
    /// <returns>List of all pizzas</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pizza>>> GetPizzas()
    {
        var pizzas = await _pizzaService.GetAllPizzasAsync();
        return Ok(pizzas);
    }

    /// <summary>
    /// Get pizza by ID
    /// </summary>
    /// <param name="id">Pizza ID</param>
    /// <returns>Pizza object</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<Pizza>> GetPizza(int id)
    {
        var pizza = await _pizzaService.GetPizzaByIdAsync(id);
        if (pizza == null)
            return NotFound(new { message = $"Pizza with ID {id} not found" });

        return Ok(pizza);
    }

    /// <summary>
    /// Create new pizza
    /// </summary>
    /// <param name="pizza">Pizza object to create</param>
    /// <returns>Created pizza</returns>
    [HttpPost]
    public async Task<ActionResult<Pizza>> CreatePizza(Pizza pizza)
    {
        if (string.IsNullOrWhiteSpace(pizza.Name))
            return BadRequest(new { message = "Pizza name is required" });

        var createdPizza = await _pizzaService.CreatePizzaAsync(pizza);
        return CreatedAtAction(nameof(GetPizza), new { id = createdPizza.Id }, createdPizza);
    }

    /// <summary>
    /// Update pizza
    /// </summary>
    /// <param name="id">Pizza ID</param>
    /// <param name="pizza">Updated pizza data</param>
    /// <returns>Updated pizza</returns>
    [HttpPut("{id}")]
    public async Task<ActionResult<Pizza>> UpdatePizza(int id, Pizza pizza)
    {
        if (string.IsNullOrWhiteSpace(pizza.Name))
            return BadRequest(new { message = "Pizza name is required" });

        var updatedPizza = await _pizzaService.UpdatePizzaAsync(id, pizza);
        if (updatedPizza == null)
            return NotFound(new { message = $"Pizza with ID {id} not found" });

        return Ok(updatedPizza);
    }

    /// <summary>
    /// Delete pizza
    /// </summary>
    /// <param name="id">Pizza ID</param>
    /// <returns>Success message</returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePizza(int id)
    {
        var deleted = await _pizzaService.DeletePizzaAsync(id);
        if (!deleted)
            return NotFound(new { message = $"Pizza with ID {id} not found" });

        return NoContent();
    }
}
