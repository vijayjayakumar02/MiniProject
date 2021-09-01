using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyDots.Models.Models
{
    class Menu
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public String Category { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
    }
}
