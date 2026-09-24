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
        public async Task TestMethodImportTrue()
        {
            // создание Mock-файл
            Mock<IFileImport> mockFile = new Mock<IFileImport>();
            // создание Mock-БД
            Mock<IUserRepository> mockDatabase = new Mock<IUserRepository>();
            // пользователь, которого прочитали из файла
            var users = new List<User>
            {
                new User
                {
                    Login = "Berezkin123",
                    Password = "123",
                    Name = "Егор",
                    Familia = "Берёзкин"
                }
            };
            // программа читает файл, Mock-файл возвращает нашего пользователя
            mockFile.Setup(file => file.ReadDataFromFile("users.txt")).ReturnsAsync(users);
            // проверка на правильность данных
            mockFile.Setup(file => file.ValidateUser("Berezkin123", "123")).Returns(true);
            // создание Import и передача ему наши Mock-объекты
            var import = new Import(mockFile.Object, mockDatabase.Object);
            // запускание импорта
            await import.ImportData("users.txt");
            // проверка, что пользователь действительно был добавлен в БД
            mockDatabase.Verify(db => db.AddUser(It.Is<User>(u => u.Login == "Berezkin123" && u.Password == "123")), Times.Once);
            // проверка на сохранение изменений
            mockDatabase.Verify(db => db.SaveChanges(), Times.Once);
        }
        // тест на неуспешный импорт пользователя
        [TestMethod]
        public async Task TestMethodImportFalse()
        {
            // Mock-файл
            Mock<IFileImport> mockFile = new Mock<IFileImport>();
            // Mock-БД
            Mock<IUserRepository> mockDatabase = new Mock<IUserRepository>();
            // пользователь из файла
            var users = new List<User>
            {
                new User
                {
                    Login = "Berezkin123",
                    Password = "",
                    Name = "Егор",
                    Familia = "Берёзкин"
                }
            };
            // файл возвращает пользователя
            mockFile.Setup(file => file.ReadDataFromFile("users.txt")).ReturnsAsync(users);
            // проверка данных не пройдена
            mockFile.Setup(file => file.ValidateUser("Berezkin123", "")).Returns(false);
            // создание Import
            var import = new Import(mockFile.Object, mockDatabase.Object);
            // запуск импорта
            await import.ImportData("users.txt");
            // пользователь не должен добавляться в БД
            mockDatabase.Verify(db => db.AddUser(It.IsAny<User>()), Times.Never);
            // сохранения тоже не должно быть
            mockDatabase.Verify(db => db.SaveChanges(), Times.Never);
        }
    }
}
