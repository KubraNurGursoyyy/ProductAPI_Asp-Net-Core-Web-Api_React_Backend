using System.ComponentModel.DataAnnotations;

namespace DTO.DTOs
{
    public class ProductDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, ErrorMessage = "Product name must not exceed 100 characters")]
        public required string Name { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category ID is required")]
        public int CategoryID { get; set; }
    }
}
