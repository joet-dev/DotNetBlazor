namespace TestBlazor.Data; 

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var pizzas = new Pizza[]
        {
            new Pizza { Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegetarian = false, Vegan = false },
            new Pizza { Name = "Buffalo chicken", Price =  12.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", Vegetarian = false, Vegan = false },
            new Pizza { Name = "Veggie Delight", Price =  11.5M, Description = "It's like salad, but on a pizza", Vegetarian = true, Vegan = true},
            new Pizza { Name = "Margherita", Price =  9.99M, Description = "Traditional Italian pizza with tomatoes and basil", Vegetarian = true, Vegan = false},
            new Pizza { Name = "Basic Cheese Pizza", Price =  11.99M, Description = "It's cheesy and delicious. Why wouldn't you want one?", Vegetarian = false, Vegan = false},
            new Pizza { Name = "Classic pepperoni", Price =  10.5M, Description = "It's the pizza you grew up with, but Blazing hot!", Vegetarian = false, Vegan = false },
            new Pizza { Name = "Joseph's Pizza", Price = 69.42M, Description="Nice", Vegetarian=false, Vegan=false}
        };
        db.Pizzas.AddRange(pizzas);
        db.SaveChanges();
    }
}