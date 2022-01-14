using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(2000), Required]
        public string Text { get; set; }
        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        [ForeignKey("ParentComment")]
        public int ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
