using System;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestPracticheskai
{
    [TestClass]
    public class UnitTestAuthAndRegistr
    {
        [TestMethod]
        public void TestMethodPasswordTrue()
        {
            Mock<IUserRepository> mock = new Mock<IUserRepository>(); // метод мок для имитации бд
            mock.Setup(repo => repo.GetUser("Berezkins")) // если будет вызван метод репозитория с аргументом логин, какие ожидают от этого результаты
                .Returns(new User { Login = "Berezkins", Password = "rikis123" });   // в ответе я хочу чтобы выдавал пользователя с таким логиным и паролем

            var service = new UserService(mock.Object); // используем имитацию

            string result = service.Autorization("Berezkins", "rikis123"); // проверка авторизации, происходит проверка метода авторизация

            Assert.AreEqual("true", result); // проверка результата
        }


        [TestMethod] 
        public void TestMethodPasswordFalse()
        {
            Mock<IUserRepository> mock = new Mock<IUserRepository>();

            mock.Setup(repo => repo.GetUser("Berezkins"))
                .Returns(new User { Login = "Berezkins", Password = "rikis123" });

            var service = new UserService(mock.Object);

            string result = service.Autorization("Berezkins", "rikis234");

            Assert.AreEqual("Ошибка (проверьте введённые данные)", result);
        }

        [TestMethod]
        public void TestMethodRegistraziaTrue()
        {
            Mock<IUserRepository> mock = new Mock<IUserRepository>();

            mock.Setup(repo => repo.GetUser("Berezkins23")) // если программа попробует найти пользователя логином "login"
                .Returns((User)null); // говорим что пользователя нет (Если ищут пользователя "login", верни null)

            var service = new UserService(mock.Object); // создаем UserService, работающий с имитацией

            string result = service.Registrazia("Berezkins23", "Kulebaka"); // запускаем регистрацию

            Assert.AreEqual("успех", result); // для проверки результата теста
        }

        [TestMethod]
        public void TestMethodPasswordPolniy()
        {
            Mock<IUserRepository> mock = new Mock<IUserRepository>();

            mock.Setup(repo => repo.GetUser("Berezkins456"))
                .Returns((User)null);

            var service = new UserService(mock.Object);
            string result = service.Registrazia("Berezkins456", "ghyrk47");

            Assert.AreEqual("Пароль должен содержать не менее 8 символов", result );
        }
    }
}
