using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class CategoryDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(100, ErrorMessage = "Category name must not exceed 100 characters")]
        public required string Name { get; set; }
    }
}
