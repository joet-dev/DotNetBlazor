namespace TestBlazor.Data
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public bool Vegetarian { get; set; }

        public bool Vegan { get; set; }

        public string GetFormattedBasePrice() => Price.ToString("0.00");
    }
}
