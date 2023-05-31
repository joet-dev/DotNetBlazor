using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestBlazor.Data;

namespace BlazingPizza.Controllers;

[Route("circles")]
[ApiController]
public class PizzaController : Controller
{
    private readonly PizzaStoreContext _db;

    public PizzaController(PizzaStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Pizza>>> GetPizza()
    {
        return (await _db.Pizzas.ToListAsync()).OrderBy(p => p.Price).ToList();
    }
}