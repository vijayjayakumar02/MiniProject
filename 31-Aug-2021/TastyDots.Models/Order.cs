using System;
using System.ComponentModel.DataAnnotations;

namespace TastyDots.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage ="Name is required to place the order")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Mobile Number is required to place the order")]
        public double MobileNo { get; set; }
        public string Item { get; set; }
        public double TotalCost { get; set; }
    }
}
