using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestPracticheskai
{
    [TestClass]
    public class UnitTestMocks
    {
        // тест на проверку успешного импорта пользователей из файла в бд
        [TestMethod]
        public void TestMethodImportTrue()
        {
            // создание Mock-файл
            Mock<IFileImport> mockFile = new Mock<IFileImport>();
            // создание Mock-БД
            Mock<IUserRepository> mockDatabase = new Mock<IUserRepository>();
            // пользователь, которого прочитали из файла
            User user = new User
            {
                Login = "Berezkin123",
                Password = "123",
                Name = "Егор",
                Familia = "Берёзкин"
            };
            // программа читает файл, Mock-файл возвращает нашего пользователя
            mockFile.Setup(file => file.ReadDataFromFile("users.txt")).Returns(new List<User> { user });            
            // проверка на правильность данных
            mockFile.Setup(file => file.ValidateUser("Berezkin123", "123")).Returns(true);
            // создание Import и передача ему наши Mock-объекты
            var import = new Import(mockFile.Object, mockDatabase.Object);
            // запускание импорта
            string result = import.ImportData("users.txt");
            // проверка результата
            Assert.AreEqual("успех", result);
        }
        // тест на неуспешный импорт пользователя
        [TestMethod]
        public void TestMethodImportFalse()
        {
            // Mock-файл
            Mock<IFileImport> mockFile = new Mock<IFileImport>();
            // Mock-БД
            Mock<IUserRepository> mockDatabase = new Mock<IUserRepository>();
            // пользователь из файла
            User user = new User
            {
                Login = "Berezkin123",
                Password = "",
                Name = "Егор",
                Familia = "Берёзкин"
            };
            // файл возвращает пользователя
            mockFile.Setup(file => file.ReadDataFromFile("users.txt")).Returns(new List<User> { user });
            // проверка данных не пройдена
            mockFile.Setup(file => file.ValidateUser("Berezkin123", "")).Returns(false);
            // создание Import
            var import = new Import(mockFile.Object, mockDatabase.Object);
            // запуск импорта
            string result = import.ImportData("users.txt");
            // проверка результата
            Assert.AreEqual("Ошибка", result);
        }
    }
}
