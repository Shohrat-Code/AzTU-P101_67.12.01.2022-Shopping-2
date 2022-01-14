using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class CustomUser : IdentityUser
    {
        [MaxLength(30), Required]
        public string Name { get; set; }
        [MaxLength(30), Required]
        public string Surname { get; set; }
        [MaxLength(500), Required]
        public string Address { get; set; }
        public bool IsRegistered { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
