using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           
            
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                         new Car
                         {
                             name = "Tesla Model s",
                             sortDesc = "Илон",
                             longDesc = "Пушка гонкано не далеко",
                             img = "/img/tesla.jpg",
                             price = 45000,
                             isFavorite = true,
                             available = true,
                             Category = Categories["Электромобили"]
                         },
                        new Car
                        {
                            name = "Nissan Leaf",
                            sortDesc = "Нисан",
                            longDesc = "Пушка но не стреляет",
                            img = "/img/nissan leaf.jpg",
                            price = 40000,
                            isFavorite = true,
                            available = true,
                            Category = Categories["Электромобили"]
                        },
                        new Car
                        {
                            name = "Skoda Kodiaq",
                            sortDesc = "Шкода",
                            longDesc = "Сингента",
                            img = "/img/skoda kodiaq.jpg",
                            price = 55000,
                            isFavorite = true,
                            available = true,
                            Category = Categories["Классический автомобиль"]
                        },
                        new Car
                        {
                            name = "Subaru Forester",
                            sortDesc = "Субару",
                            longDesc = "Дом",
                            img = "/img/subaru.jpg",
                            price = 53338,
                            isFavorite = true,
                            available = true,
                            Category = Categories["Классический автомобиль"]
                        }
                    );

            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category {categoryName = "Классический автомобиль", desc = "Машины с двигателем внутреннего згорания"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
