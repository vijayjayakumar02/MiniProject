using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Blogs
    {
        [Key]
        public int BlogId { get; set; }

        [Required(ErrorMessage ="Bolg Title is required")]
        [MaxLength(30,ErrorMessage ="Blog Title can have maximum of 30 characters")]
        public string BlogTitle { get; set; }

        [Required(ErrorMessage = "Bolg Content is required")]
        public string BlogContent { get; set; }

        public ICollection<Comments> Comment { get; set; }
    }
}
