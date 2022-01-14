using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class FAQCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150), Required]
        public string Name { get; set; }
        public List<FAQ> FAQs { get; set; }
    }
}
