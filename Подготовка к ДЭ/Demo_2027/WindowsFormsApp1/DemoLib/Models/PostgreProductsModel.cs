using System;
using System.Collections.Generic;
using Npgsql;

namespace DemoLib.Models
{
    public class PostgreProductsModel : IProductsModel
    {
        private string connectionString_ = "Host=localhost;Port=5432;Database=ShoeStoreDB;Username=postgres;";
        // private string connectionString_ = "Host=192.168.1.48;Port=5432;Database=ShoeStoreBD;Username=st56-8;Password=568";

        // Загрузка товаров из PostgreSQL
        public List<Product> Load()
        {
            List<Product> products = new List<Product>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString_))
            {
                connection.Open();
                // Left join - соединение товаров с остатками, Coalesse - если остатка нет, то 0
                string query = @"SELECT p.kategoriya, p.name, p.parts, p.price, p.proizvodstvo, p.image,
                                    COALESCE(SUM(s.quantity), 0) AS total_count
                                    FROM products p
                                    LEFT JOIN stock_items s ON s.product_id = p.id
                                    GROUP BY p.id, p.kategoriya, p.name, p.parts, p.price, p.proizvodstvo, p.image
                                    ORDER BY p.id";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())                                         // перебор записей
                        {
                            Product product = new Product();                          // сохдание объекта

                            product.Category = reader["kategoriya"].ToString();
                            product.Name = reader["name"].ToString();

                            string parts = reader["parts"].ToString();                // получение значения столбца
                            product.Parts = "";                                       // очистка свойства, чтобы записать обрабатываемый текст
                            int count = 0;                                            // подсчет количества символов

                            for (int i = 0; i < parts.Length; i++)                    // цикл перебора символов, начало с первого символа,
                                                                                      // проверка не закончилась ли строка, переход к след строке
                            {
                                product.Parts += parts[i];                            // добавление текущего символа из исходной строки
                                count++;                                              // увеличение счетчика после каждого символа

                                if (count >= 100 && parts[i] == ' ')                  // проверка что номер символа делится на 100,
                                                                                      // что номер это не начало строк, текущий символ - пробел
                                {
                                    product.Parts += "\n";                            // добавление символа переноса строки
                                    count = 0;                                        // обнуление счетчика после переноса
                                }
                            }

                            product.Price = Convert.ToDouble(reader["price"]);
                            product.Supplier = reader["proizvodstvo"].ToString();
                            product.ImagePath = "../../../Images/Images/" + reader["image"].ToString();

                            product.Count = Convert.ToInt32(reader["total_count"]);

                            products.Add(product);                                    // добавление объекта в список
                        }
                    }
                }
            }
            return products;
        }

        // Получение количества товаров
        public int GetCountProducts()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString_))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM products";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public List<string> GetAllCategories()
        {
            List<string> categories = new List<string>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString_))      // Подключение к бд
            {
                connection.Open();

                string query = "SELECT DISTINCT kategoriya FROM products ORDER BY kategoriya"; // запрос в бд, получение данных, уборка повторяемых значений, название стоолбца

                // выполнение запроса
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // получение результата
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // перебор полученных данных
                        while (reader.Read())
                        {
                            categories.Add(reader["kategoriya"].ToString());
                        }
                    }
                }
            }
            return categories;
        }
    }
}
