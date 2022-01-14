using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class Size
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        public List<SizeColorToProduct> SizeColorToProducts { get; set; }
    }
}
