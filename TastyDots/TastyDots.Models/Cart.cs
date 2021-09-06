using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyDots.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        public string Dish { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
    }
}
