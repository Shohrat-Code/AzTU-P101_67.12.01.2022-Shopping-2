using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500), Required]
        public string Title { get; set; }
        [MaxLength(250), Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Column(TypeName ="ntext"), Required]
        public string Content { get; set; }
        [ForeignKey("BlogCategory")]
        public int CategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }
        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
