using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                    new Category {categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category {categoryName = "Классический автомобиль", desc = "Машины с двигателем внутреннего згорания"}
                };
            }
        }
    }
}
