using System;
using System.Collections.Generic;
using DemoLib;
using DemoLib.Models;
using DemoLib.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DemoTesting
{
    [TestClass]
    public class TestMockOrders
    {
        // Тест на получение заказов
        [TestMethod]
        public void TestMethodGetOrdersTrue()
        {
            Mock<IOrdersRepository> mockRepository = new Mock<IOrdersRepository>();
            // список заказов
            var orders = new List<Order>
            {
                new Order { Id = 1 },
                new Order { Id = 2 }
            };
            // mock, возврат заказов
            mockRepository.Setup(repository => repository.GetOrders()).Returns(orders);
            // создаем модели и передаём в Mock
            ProductsModel model = new ProductsModel(mockRepository.Object);
            // получаем заказы
            List<Order> result = model.LoadOrders();

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
        }

        // Тест на получение пустого списка заказов
        [TestMethod]
        public void TestMethodGetOrdersEmpty()
        {
            Mock<IOrdersRepository> mockRepository = new Mock<IOrdersRepository>();
            // возвращение пустого списка
            mockRepository.Setup(repository => repository.GetOrders()).Returns(new List<Order>());
            // получение списка заказов
            ProductsModel model = new ProductsModel(mockRepository.Object);
            List<Order> result = model.LoadOrders();

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        // Тест на проверку вызова метода репозитория
        [TestMethod]
        public void TestMethodRepositoryCalled()
        {
            Mock<IOrdersRepository> mockRepository = new Mock<IOrdersRepository>();
            mockRepository.Setup(repository => repository.GetOrders()).Returns(new List<Order>());
            // создаем модель
            ProductsModel model = new ProductsModel(mockRepository.Object);
            // вызываем метод получения заказов
            model.LoadOrders();

            mockRepository.Verify(repository => repository.GetOrders(), Times.Once);
        }
    }
}
