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
    public class HomeController : Controller
    {
        public IAllCars _carsRep;

        public HomeController(IAllCars carRep)
        {
            _carsRep = carRep;
        }
        public ViewResult Index()
        {
            var homeCars = new HomeViewModels
            {
                favCars = _carsRep.getFavCars
            };

            return View(homeCars);
        }
    }
}
