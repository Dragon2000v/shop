using Microsoft.AspNetCore.Mvc;
using shop.Data.interfaces;
using shop.Data.Models;

using shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    public class ShopCartController : Controller
    {
        public readonly IAllCars _carRepository;
        public readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRepository = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModels
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _carRepository.Cars.FirstOrDefault(i => i.id == id);
            if(item != null)
            {

                _shopCart.AddToCart(item);

            }
            return RedirectToAction("Index");
        }

    }
}
