using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Fullname { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(2000), Required]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
