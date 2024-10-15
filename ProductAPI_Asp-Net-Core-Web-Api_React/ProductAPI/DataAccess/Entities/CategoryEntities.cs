using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    internal class CategoryEntities
    {
        public CategoryEntities()
        {
            Products = new List<ProductEntities>();
        }

        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        public virtual ICollection<ProductEntities> Products { get; set; }
    }
}
