using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150), Required]
        public string Name { get; set; }
        [ForeignKey("ParentCategory")]
        public int? ParentCategoryId { get; set; }
        public ProductCategory ParentCategory { get; set; }
        public List<Product> Products { get; set; }
    }
}
