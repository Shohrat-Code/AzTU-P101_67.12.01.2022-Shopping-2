using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo1 { get; set; }
        [NotMapped]
        public IFormFile Logo1File { get; set; }
        [MaxLength(250)]
        public string Logo2 { get; set; }
        [NotMapped]
        public IFormFile Logo2File { get; set; }
        [MaxLength(1000), Required]
        public string Info { get; set; }
        [MaxLength(500), Required]
        public string Address { get; set; }
        [MaxLength(15), Required]
        public string Phone { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(150), Required]
        public string WorkTime { get; set; }
        [MaxLength(2000), Required]
        public string Map { get; set; }
        [MaxLength(500), Required]
        public string AboutTitle { get; set; }
        [Column(TypeName ="ntext"), Required]
        public string AboutContent { get; set; }
        [MaxLength(250)]
        public string AboutVideo { get; set; }
        [NotMapped]
        public IFormFile AboutVideoFile { get; set; }
    }
}
