using System;
using System.Collections.Generic;
using DemoLib;
using DemoLib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoTesting
{
    [TestClass]
    public class TOrders
    {
        // Тест - Проверка скидки на товар который не покупали один месяц
        [TestMethod]
        public void TestCalcDiscount()
        {
            ProductsModel model = new ProductsModel();
            List<Product> products = model.Load();

            products.Clear();
            products.Add(new Product { Name = "a", Price = 1000 });
            products.Add(new Product { Name = "b", Price = 2000 });

            /// заказ в октябре на товар а
            Order order_1 = new Order();
            order_1.Items = new List<OrderItem>();
            order_1.Items.Add(new OrderItem
            {
                ProductItem = "a",
                Count = 10,
                SaleDate = new System.DateTime(2026, 10, 10)
            });

            /// заказ в сентябре на товар а и b
            Order order_2 = new Order();
            order_2.Items = new List<OrderItem>();
            order_2.Items.Add(new OrderItem
            {
                ProductItem = "a",
                Count = 10,
                SaleDate = new System.DateTime(2026, 9, 10)
            });
            order_2.Items.Add(new OrderItem
            {
                ProductItem = "b",
                Count = 1,
                SaleDate = new System.DateTime(2026, 9, 10)
            });

            List<Order> orders = new List<Order>();
            orders.Add(order_1);
            orders.Add(order_2);

            model.UpdatePrices(orders);
            List<Product> new_products = model.Load();

            List<double> prices = new List<double>();
            prices.Add(1000);
            prices.Add(2000);

            int i = 0;
            foreach (Product product in new_products)
            {
                Assert.AreEqual(prices[i], new_products[i].Price, 0.01);
                i++;
            }

            // Assert.AreEqual(1000.0, new_products[0].Price, 0.01);
            // Assert.AreEqual(2000.0, new_products[1].Price, 0.01);
        }
        // Тест - Заказов нет
        [TestMethod]
        public void TestNoOrders()
        {
            ProductsModel model = new ProductsModel();
            List<Product> products = model.Load();

            products.Clear();
            products.Add(new Product { Name = "a", Price = 1000 });
            products.Add(new Product { Name = "b", Price = 2000 });

            List<Order> orders = new List<Order>();

            model.UpdatePrices(orders);

            Assert.AreEqual(750.0, products[0].Price, 0.01);
            Assert.AreEqual(1500.0, products[1].Price, 0.01);
        }
        // Тест - Товар a покупали в текущем месяце
        [TestMethod]
        public void TestOrderThisMonth()
        {
            ProductsModel model = new ProductsModel();
            List<Product> products = model.Load();

            products.Clear();
            products.Add(new Product { Name = "a", Price = 1000 });

            Order order_1 = new Order();
            order_1.Items = new List<OrderItem>();
            order_1.Items.Add(new OrderItem
            {
                ProductItem = "a",
                Count = 10,
                SaleDate = new DateTime(2026, 10, 10)
            });

            List<Order> orders = new List<Order>();
            orders.Add(order_1);

            model.UpdatePrices(orders);

            Assert.AreEqual(750.0, products[0].Price, 0.01);
        }
        // Тест - Товар a покупали два месяца назад
        [TestMethod]
        public void TestOrderTwoMonthsAgo()
        {
            ProductsModel model = new ProductsModel();
            List<Product> products = model.Load();

            products.Clear();
            products.Add(new Product { Name = "a", Price = 1000 });

            Order order_1 = new Order();
            order_1.Items = new List<OrderItem>();
            order_1.Items.Add(new OrderItem
            {
                ProductItem = "a",
                Count = 10,
                SaleDate = new DateTime(2026, 8, 10)
            });

            List<Order> orders = new List<Order>();
            orders.Add(order_1);

            model.UpdatePrices(orders);

            Assert.AreEqual(750.0, products[0].Price, 0.01);
        }
    }
}
