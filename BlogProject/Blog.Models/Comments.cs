using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Comments
    {
        public int CommentId { get; set; }

        [Required(ErrorMessage ="Content is Required")]
        public string Comment { get; set; }
    }
}
