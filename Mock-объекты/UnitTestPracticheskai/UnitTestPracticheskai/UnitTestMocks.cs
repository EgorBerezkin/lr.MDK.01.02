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
            var users = new List<User>
            {
                new User {Login = "Berezkin123", Password = "berezkin123"},
                new User {Login = "Irina1234", Password = "irina12346"}
            };
            // программа читает файл, Mock-файл возвращает нашего пользователя
            mockFile.Setup(file => file.ReadDataFromFile("users.txt")).Returns(users);            
            // проверка на правильность данных
            mockFile.Setup(file => file.ValidateUser("Berezkin123", "berezkin123")).Returns(true);
            mockFile.Setup(file => file.ValidateUser("Irina1234", "irina12346")).Returns(true);
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
            // пользователь, которого прочитали из файла
            var users = new List<User>
            {
                new User {Login = "Berezkin123", Password = "berezkin123"},
                new User {Login = "Irina1234", Password = "irina12346"}
            };
            // программа читает файл, Mock-файл возвращает нашего пользователя
            mockFile.Setup(file => file.ReadDataFromFile("users.txt")).Returns(users);
            // проверка на правильность данных
            mockFile.Setup(file => file.ValidateUser("Berezkin123", "")).Returns(true);
            mockFile.Setup(file => file.ValidateUser("", "irina12346")).Returns(true);
            // создание Import
            var import = new Import(mockFile.Object, mockDatabase.Object);
            // запуск импорта
            string result = import.ImportData("users.txt");
            // проверка результата
            Assert.AreEqual("Ошибка", result);
        }
    }
}
