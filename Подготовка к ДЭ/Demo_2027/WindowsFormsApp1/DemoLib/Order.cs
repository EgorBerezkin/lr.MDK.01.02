using System;
using System.Collections.Generic;

namespace DemoLib
{
    public class Order
    {
        public int Id { get; set; } // номер заказа
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string FIO { get; set; }
        public double TotalSum { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order()
        {
            Items = new List<OrderItem>();
        }
    }
    
}
