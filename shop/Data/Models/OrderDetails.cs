using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Models
{
    public class OrderDetails
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int CarId { get; set; }
        public uint price { get; set; }
        public virtual Car car { get; set; }
        public virtual Order order { get; set; }
       
    }
}
