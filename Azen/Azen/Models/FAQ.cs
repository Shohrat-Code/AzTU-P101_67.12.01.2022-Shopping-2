using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500), Required]
        public string Title { get; set; }
        [MaxLength(2000), Required]
        public string Content { get; set; }
        [ForeignKey("FAQCategory")]
        public int FAQCategoryId { get; set; }
        public FAQCategory FAQCategory { get; set; }
    }
}
