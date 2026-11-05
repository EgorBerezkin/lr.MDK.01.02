using System.Collections.Generic;

namespace DemoLib.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private List<Order> orders_; // хранение списка заказов

        public OrdersRepository(List<Order> orders)
        {
            orders_ = orders;
        }

        // метод возвращения списка
        public List<Order> GetOrders()
        {
            return orders_;
        }
    }
}
