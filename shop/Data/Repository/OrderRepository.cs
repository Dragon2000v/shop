using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrderRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }
        /* public void createOrder(Order order)
         {
             order.orderTime = DateTime.Now;
             appDBContent.Order.Add(order);
             appDBContent.SaveChanges();
             var items = shopCart.listShopItems;

             foreach(var el in items)
             {
                 var orderDetail = new OrderDetails()
                 {
                     CarId = el.car.id,
                     orderID = order.id,
                     price = el.car.price
                 };
                 appDBContent.OrderDetails.Add(orderDetail);
                // appDBContent.SaveChanges();
             }
             appDBContent.SaveChanges();
         }*/
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            //Нужно добавить сохранение в базу иначе выбивает ошибку и не сохраняет
            appDBContent.SaveChanges();
            var items = shopCart.listShopItems;

            foreach (var el in items)
            {

                var orderDeteil = new OrderDetails
                {
                    CarId = el.car.id,
                    orderID = order.id,
                    price = el.car.price
                };
                appDBContent.OrderDetails.Add(orderDeteil);


            }

            appDBContent.SaveChanges();
        }
    }
}
