using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class SaleItem
    {
        [Key]
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("SizeColorToProduct")]
        public int ProductId { get; set; }
        public SizeColorToProduct SizeColorToProduct { get; set; }
        [ForeignKey("Sale")]
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
    }
}
