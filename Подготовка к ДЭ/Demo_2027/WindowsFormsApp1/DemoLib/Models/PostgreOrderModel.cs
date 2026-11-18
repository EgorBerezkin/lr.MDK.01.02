using System;
using System.Collections.Generic;
using Npgsql;

namespace DemoLib.Models
{
    public class PostgreOrderModel : IOrdersModel
    {
        private string connectionString_ = "Host=localhost;Port=5432;Database=ShoeStoreDB;Username=postgres;";
        //private string connectionString_ = "Host=192.168.1.48;Port=5432;Database=ShoeStoreBD;Username=st50-1;Password=501";

        // Загрузка заказов из PostgreSQL
        public List<Order> Load()
        {
            List<Order> orders = new List<Order>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString_))
            {
                connection.Open();

                string query = @"SELECT o.id, oi.order_id, o.order_date, o.fio, oi.kategoriya, oi.name, oi.proizvodstvo, oi.size, oi.quantity, oi.price
                                    FROM orders o
                                    INNER JOIN order_items oi ON oi.order_id = o.id
                                    ORDER BY o.id, oi.id";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int orderId = Convert.ToInt32(reader["id"]);

                            Order order = orders.Find(x => x.Id == orderId);

                            if (order == null)
                            {
                                order = new Order();

                                order.Id = orderId;
                                order.OrderNumber = reader["order_id"].ToString();
                                order.OrderDate = Convert.ToDateTime(reader["order_date"]);
                                order.FIO = reader["fio"].ToString();
                                order.Items = new List<OrderItem>();

                                orders.Add(order);
                            }

                            OrderItem item = new OrderItem();

                            item.ProductItem = reader["name"].ToString();
                            item.Category = reader["kategoriya"].ToString();
                            item.Supplier = reader["proizvodstvo"].ToString();

                            item.Size = reader["size"] == DBNull.Value ? "" : reader["size"].ToString();

                            item.Count = Convert.ToInt32(reader["quantity"]);
                            item.Price = Convert.ToDouble(reader["price"]);

                            order.Items.Add(item);
                        }
                    }
                }
            }
            return orders;
        }
    }
}
