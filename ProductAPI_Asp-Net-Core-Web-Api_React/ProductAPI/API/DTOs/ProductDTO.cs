namespace API.DTOs
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryID { get; set; }
    }
}
