using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TastyDots.Controllers
{
    private readonly 
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
