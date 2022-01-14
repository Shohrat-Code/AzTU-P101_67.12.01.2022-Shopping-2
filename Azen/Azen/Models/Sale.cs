using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(11)]
        public string No { get; set; }
        public decimal? Shipping { get; set; }
        [ForeignKey("CustomUser")]
        public string CustomerId { get; set; }
        public CustomUser CustomUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<SaleItem> SaleItems { get; set; }
    }
}
