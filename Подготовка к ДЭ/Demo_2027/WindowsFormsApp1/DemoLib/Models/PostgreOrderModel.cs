using System;
using System.Collections.Generic;
using Npgsql;

namespace DemoLib.Models
{
    public class PostgreOrderModel : IOrdersModel
    {
        private string connectionString_ = "Host=localhost;Port=5432;Database=ShoeStoreDB;Username=postgres;";
        // private string connectionString_ = "Host=192.168.1.48;Port=5432;Database=ShoeStoreBD;Username=st56-8;Password=568";

        // Загрузка заказов из PostgreSQL
        public List<Order> Load()
        {
            List<Order> orders = new List<Order>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString_))
            {
                connection.Open();
                // создание временного набора данных, также группировка записей по дате и ФИО; в конце происходит сортировка по номеру заказа
                string query = @"WITH unique_orders AS (SELECT ROW_NUMBER() OVER (ORDER BY MIN(id)) AS order_id, order_date, fio
                                        FROM orders
                                        GROUP BY order_date, fio)
                                SELECT u.order_id, u.order_date, u.fio, oi.id AS item_id, oi.kategoriya, oi.name, oi.proizvodstvo, oi.size, oi.quantity, oi.price
                                        FROM unique_orders u
                                        LEFT JOIN order_items oi ON oi.order_id = u.order_id
                                        ORDER BY u.order_id, oi.id";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // чтение заказов
                            int orderId = Convert.ToInt32(reader["order_id"]);
                            // поиск заказов с таким Id
                            Order order = orders.Find(x => x.Id == orderId); 

                            if (order == null)
                            {
                                order = new Order();

                                order.Id = orderId;
                                order.OrderDate = Convert.ToDateTime(reader["order_date"]);
                                order.FIO = reader["fio"].ToString();

                                orders.Add(order);
                            }
                            // добавление товаров в заказ, если товар есть, создаем объект OrderItem
                            if (reader["item_id"] != DBNull.Value)
                            {
                                OrderItem item = new OrderItem();

                                item.Category = reader["kategoriya"].ToString();
                                item.ProductItem = reader["name"].ToString();
                                item.Supplier = reader["proizvodstvo"].ToString();

                                item.Size = reader["size"] == DBNull.Value ? "" : reader["size"].ToString();
                                item.Count = Convert.ToInt32(reader["quantity"]);
                                item.Price = Convert.ToDouble(reader["price"]);

                                order.Items.Add(item);
                                // расчет суммы
                                order.TotalSum += item.Count * item.Price;
                            }
                        }
                    }
                }
            }
            return orders;
        }
    }
}
