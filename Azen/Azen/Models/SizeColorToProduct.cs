using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class SizeColorToProduct
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Size")]
        public int SizeId { get; set; }
        public Size Size { get; set; }
        [ForeignKey("ColorToProduct")]
        public int ColorToProductId { get; set; }
        public ColorToProduct ColorToProduct { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public DateTime? DiscountDate { get; set; }
        public decimal Quantity { get; set; }
        public List<SaleItem> SaleItems { get; set; }
    }
}
