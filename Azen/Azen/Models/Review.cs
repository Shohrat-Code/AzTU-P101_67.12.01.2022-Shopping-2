using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(2000), Required]
        public string Text { get; set; }
        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public byte Rating { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
