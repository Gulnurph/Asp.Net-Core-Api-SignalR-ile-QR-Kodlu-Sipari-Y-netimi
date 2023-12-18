namespace EntiyLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        private string? Status { get; set; }
        public List<Product> Products { get; set; }
    }
}
