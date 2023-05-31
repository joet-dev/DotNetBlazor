using Microsoft.EntityFrameworkCore; 

namespace TestBlazor.Data; 
public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Pizza> Pizzas { get; set; }
}

