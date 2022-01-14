using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class ColorToProduct
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public Color Color { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public List<SizeColorToProduct> SizeColorToProducts { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
