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

        private double _tempPrice;

        
        public ActionResult PriceUpdate(double Price, int qnty)
        {
            this._tempPrice += Price * qnty;

            return Json(new
            {
                result = "OK"
            });
        }

        [HttpPost]
        public IActionResult Cart(Menu dish)
        {
            //var tempDish = _menu.MenuList.Get();

            _tempPrice += dish.Price * dish.Stock;

            return RedirectToAction("Index"); 
        }


        public IActionResult PlaceOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder(OrderDetails order)
        {
            ICollection<Cart> items = (ICollection<Cart>)_menu.ItemList.GetAll();

            Order ord = new Order
            {
                CustomerName = order.Name,
                MobileNo = order.PhoneNumber,
                Item= items,
                TotalCost = _tempPrice
            };

            _menu.Orders.Insert(ord);
            _menu.Save();
            foreach (var item in items)
            {
                _menu.ItemList.Delete(item.CartId);

            }


            return View("OrderSuccess",ord);
        }

        public IActionResult OrderSuccess()
        {
            //ViewBag.item = items;
            return View();
        }

        //private List<Menu> _itemList;
        public IActionResult AddItem(int id)
        {
            var dish = _menu.MenuList.Get(id);

            Cart item = new Cart
            {
                Dish = dish.DishName,
                Price = dish.Price,

            };

            _menu.ItemList.Insert(item);
            _menu.Save();
            //_itemList.Add(dish);

            return RedirectToAction("Index");
        }


    }
}
