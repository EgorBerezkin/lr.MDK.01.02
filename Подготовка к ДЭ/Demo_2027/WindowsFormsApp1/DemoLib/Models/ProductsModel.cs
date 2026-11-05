using System;
using System.Collections.Generic;
using System.Linq;
using DemoLib.Repositories;

namespace DemoLib.Models
{
    public class ProductsModel : IProductsModel
    {
        private IOrdersRepository ordersRepository_;

        private List<Product> data_ = new List<Product>();
        private List<Order> orders_ = new List<Order>();

        public ProductsModel()
        {
            data_.Add(new Product { Name = "Кроссовки детские «Звёздочка»", Category = "Детская обувь", Count = 3,
                Price = 2190.0, Supplier = "Малыш-Спорт", Parts = "Верх — экокожа (полиуретан на хлопковой основе),\nподкладка — хлопок 100%,подошва — ПВХ, кабачок",
                ImagePath = "../../../Images/IMG_KB_164811.png" });

            data_.Add(new Product { Name = "Туфли из натурального кабачка", Category = "Мужская обувь", Count = 5, Price = 25625.0, Supplier = "Берестов", 
                Parts = "Верх — натуральная кожа, подкладка — натуральная кожа, \nстелька — натуральный кабачок,подошва — резина", ImagePath = "../../../Images/IMG_MSho_190514.png" });

            data_.Add(new Product { Name = "Босоножки «Песчаный берег»", Category = "Женская обувь", Count = 21, Price = 7500.0, Supplier = "Стиль и комфорт", 
                Parts = "Верх — 100% козья кожа, подкладка — 100% кожа; \nподошва: 100% кожа"
            });

            orders_.Add(new Order { Id = 1, Items = new List<OrderItem> { new OrderItem { ProductItem = "Кросовки детские «Звёздочка»", Count = 3, SaleDate = new System.DateTime(2026, 10, 10) },
                                                                          //new OrderItem { ProductItem = "Туфли из натурального кабачка", Count = 4, SaleDate = new System.DateTime(2026, 10, 10) },
                                                                          new OrderItem {  ProductItem= "Босоножки «Песчаный берег» коричневые", Count = 20, SaleDate = new System.DateTime(2026, 10, 10) } } });

            orders_.Add(new Order { Id = 2, Items = new List<OrderItem> { new OrderItem { ProductItem = "Кросовки детские «Звёздочка» экокожа", Count = 2, SaleDate = new System.DateTime(2026, 11, 10) },
                                                                          new OrderItem { ProductItem = "Туфли из натурального кабачка", Count = 3, SaleDate = new System.DateTime(2026, 11, 10) },
                                                                          new OrderItem {  ProductItem= "Босоножки «Песчаный берег»", Count = 15, SaleDate = new System.DateTime(2026, 11, 10) } } });

            // создание репозитория
            ordersRepository_ = new OrdersRepository(orders_);

            UpdatePrices(orders_);
        }

        public List<Product> Load()
        {
            return data_;
        }

        public int GetCountProducts()
        {
            return data_.Count;
        }

        // конструктор модели с параметром, передающий объект
        public ProductsModel(IOrdersRepository ordersRepository)
        {
            ordersRepository_ = ordersRepository;
        }
        // метод возврата списка товаров
        public List<Order> LoadOrders()
        {
            return ordersRepository_.GetOrders();
        }


        // Метод - Если товар покупали в прошлом месяце, его цена остается прежней
        // Если товар не покупали в прошлом месяце, его цена уменьшается на 25%
        // Продажи в текущем месяце или два месяца назад не учитываются
        public void UpdatePrices(List<Order> orders)
        {
            DateTime current = DateTime.Now; // 10.10.2026

            DateTime prevMontsDate = current.AddMonths(-1); // 10.09.2026
            DateTime start = new DateTime(prevMontsDate.Year, prevMontsDate.Month, 1); // 01.09.2026
            DateTime end = new DateTime(prevMontsDate.Year, prevMontsDate.Month + 1, 1).AddDays(-1);

            // улучшенная версия метода
            List<Product> discountProducts = data_
                .Where(product => !orders
                    .SelectMany(order => order.Items)
                    .Any(item => item.ProductItem == product.Name
                        && item.SaleDate >= start
                        && item.SaleDate < end))
                .ToList();
            foreach (Product product in discountProducts)
            {
                product.Price *= 0.75;
            }
        }
    }
}
