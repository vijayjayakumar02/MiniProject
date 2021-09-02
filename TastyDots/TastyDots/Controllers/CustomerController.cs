using Microsoft.AspNetCore.Mvc;
using TastyDots.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyDots.Models;
using TastyDots.DataAccess.Repository;

namespace TastyDots.Controllers
{

    public class CustomerController : Controller
    {
        private readonly IUnitofWork _menu;

        public CustomerController(IUnitofWork menu)
        {
            this._menu = menu;
        }
        public IActionResult Index()
        {
            var menu = _menu.MenuList.GetAll();
            return View(menu);
        }
    }
}
