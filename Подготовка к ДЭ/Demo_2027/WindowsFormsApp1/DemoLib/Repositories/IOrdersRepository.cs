using System.Collections.Generic;

namespace DemoLib.Repositories
{
    public interface IOrdersRepository
    {
        // возвращает список заказов
        List<Order> GetOrders();
    }
}
