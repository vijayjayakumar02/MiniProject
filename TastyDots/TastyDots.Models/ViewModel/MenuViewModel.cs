using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyDots.Models.ViewModel
{
    public class MenuViewModel
    {
        [Key]
        public int DishId { get; set; }

        [Required(ErrorMessage = "DishName is Required")]
        public string DishName { get; set; }

        [Required(ErrorMessage = "You have to enter the Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Price is a Required Feild")]
        public double Price { get; set; }

        [Display(Name = "In Stock")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Image is a Required")]
        [Display(Name ="Picture")]
        public IFormFile DishImage { get; set; }
    }
}
