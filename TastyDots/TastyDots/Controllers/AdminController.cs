using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyDots.DataAccess.Repository;
using TastyDots.Models;

namespace TastyDots.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUnitofWork _menu;

        public AdminController(IUnitofWork menu)
        {
            this._menu = menu;
        }

        [Authorize]
        public IActionResult Index()
        {
            var menu = _menu.MenuList.GetAll();
            return View(menu);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Menu item)
        {
            if (ModelState.IsValid)
            {
                _menu.MenuList.Insert(item);
                _menu.Save();

                return RedirectToAction("Index");
            }

            return View(item);
        }

        public IActionResult Delete(int? id)
        {
            var dish = _menu.MenuList.Get((int)id);
            if (dish == null)
            {
                return NotFound();
            }

            _menu.MenuList.Delete(dish);
            _menu.Save();

            return RedirectToAction("Index");
        }
    }
}
