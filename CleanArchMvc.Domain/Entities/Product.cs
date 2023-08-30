namespace CleanArchMvc.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Descritpion { get; set; }
        public decimal price { get; set; }
        public int Stock { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
        public Category? category { get; set; }
    }
}
