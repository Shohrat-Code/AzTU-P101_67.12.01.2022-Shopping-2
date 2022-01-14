using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500), Required]
        public string Name { get; set; }

        [MaxLength(500), Required]
        public string About { get; set; }

        [MaxLength(10), Required]
        public string SKU { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [ForeignKey("ProductCategory")]
        public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<ProductTagToProduct> ProductTagToProducts { get; set; }
        public List<ColorToProduct> ColorToProducts { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
