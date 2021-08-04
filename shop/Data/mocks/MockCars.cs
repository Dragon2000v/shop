using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car> {
                    new Car{
                        name = "Tesla Model s",
                        sortDesc="Илон",
                        longDesc="Пушка гонкано не далеко",
                        img="/img/tesla.jpg",
                        price=45000,
                        isFavorite=true,
                        available=true,
                        Category=_carsCategory.AllCategories.First()
                    },
                    new Car{
                        name = "Nissan Leaf",
                        sortDesc="Нисан",
                        longDesc="Пушка но не стреляет",
                        img="/img/nissan leaf.jpg",
                        price=40000,
                        isFavorite=true,
                        available=true,
                        Category=_carsCategory.AllCategories.First()
                    },
                    new Car{
                        name = "Skoda Kodiaq",
                        sortDesc="Шкода",
                        longDesc="Сингента",
                        img="/img/skoda kodiaq.jpg",
                        price=55000,
                        isFavorite=true,
                        available=true,
                        Category=_carsCategory.AllCategories.Last()
                    },
                    new Car{
                        name = "Subaru Forester",
                        sortDesc="Субару",
                        longDesc="Дом",
                        img="/img/subaru.jpg",
                        price=53338,
                        isFavorite=true,
                        available=true,
                        Category=_carsCategory.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
