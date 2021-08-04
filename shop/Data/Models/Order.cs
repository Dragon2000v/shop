using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Models
{
    public class Order
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime orderTime { get; set; }
        public List<OrderDetails> orderDetails { get; set;}
        

    }
}
