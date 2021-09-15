using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using RestaurantApp.DataAccess.Repository;
using RestaurantApp.Models;
using RestaurantApp.Models.ViewModel;


namespace RestaurantApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUnitofWork _menu;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdminController(IUnitofWork menu, IWebHostEnvironment hostEnvironment)
        {
            this._menu = menu;
            this._webHostEnvironment = hostEnvironment;
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
        public IActionResult Create(MenuViewModel item)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(item);

                Menu dish = new Menu
                {
                    DishId = item.DishId,
                    DishName = item.DishName,
                    Category = item.Category,
                    Price = item.Price,
                    Stock = item.Stock,
                    Image = uniqueFileName
                };

                _menu.MenuList.Insert(dish);
                _menu.Save();

                return RedirectToAction("Index");
            }

            return View(item);
        }

        private string UploadedFile(MenuViewModel model)
        {
            string uniqueFileName = null;

            if (model.DishImage != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.DishImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.DishImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dish = _menu.MenuList.Get((int)id);
            if (dish == null)
            {
                return NotFound();
            }

            return View(dish);

        }

        [HttpPost]
        public IActionResult Update(Menu dish)
        {
            if (ModelState.IsValid)
            {
                var myDish = _menu.MenuList.Get(dish.DishId);

                if (myDish != null)
                {
                    myDish.DishId = dish.DishId;
                    myDish.DishName = dish.DishName;
                    myDish.Category = dish.Category;
                    myDish.Price = dish.Price;
                    myDish.Stock = myDish.Stock + dish.Stock;
                }
                _menu.MenuList.Update(myDish);
                _menu.Save();
                return RedirectToAction("Index");
            }

            return View(dish);

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
