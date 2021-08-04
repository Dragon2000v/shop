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
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _carsCategory = iCarsCat;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Электромобили")).OrderBy(i => i.id);
                    currCategory = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Классический автомобиль")).OrderBy(i => i.id);
                    currCategory = "Классический автомобиль";
                }
               // currCategory = _category;               
            }
            var сarObj = new CarsListViewModels
            {
                allCars = cars,
                currCategory = currCategory
            };


            ViewBag.Title = "Страница с автомобилями";
            /*ViewBag.Category = "Same New";
            var cars = _allCars.Cars;*/
           /* CarsListViewModels obj = new CarsListViewModels();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";*/
            return View(сarObj);
        }

    }
}
