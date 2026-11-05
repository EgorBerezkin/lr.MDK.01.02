using System.Collections.Generic;

namespace DemoLib
{
    public class Order
    {
        public List<OrderItem> Items { get; set; }
        public int Id { get; set; } // номер заказа
    }
    
}
