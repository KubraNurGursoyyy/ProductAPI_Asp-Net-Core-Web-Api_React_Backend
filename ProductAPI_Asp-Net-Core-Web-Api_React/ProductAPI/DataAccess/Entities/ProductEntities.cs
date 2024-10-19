using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class ProductEntities
    {

        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        public decimal Price { get; set; }

        [Required]
        public int CategoryID { get; set; }

        public virtual CategoryEntities? Category { get; set; } // Nullable olarak işaretleyebilirsiniz
    }
}
