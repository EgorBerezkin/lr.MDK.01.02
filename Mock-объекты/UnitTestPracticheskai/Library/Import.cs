using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Import
    {
        // создание переменной для объекта, отвечающий за чтение файла
        private IFileImport file_;
        // создание переменной для репозитория бд
        private IUserRepository userRepository_;
        // конструктор класса
        public Import(IFileImport file, IUserRepository userRepository)
        {
            file_ = file;
            userRepository_ = userRepository;
        }
        // метод отвечающий за импорт пользователей
        public string ImportData(string dataFilePath)
        {
            // чтение данных из файла
            List<User> userData = file_.ReadDataFromFile(dataFilePath);
            // цикл, берет каждого пользователя из списка по очереди
            foreach (var user in userData)
            {
                // проверка пользователя
                if (file_.ValidateUser(user.Login, user.Password))
                {
                    // добавление в бд
                    userRepository_.AddUser(user);
                    // после добавления сохраняем изменения
                    userRepository_.SaveChanges();
                    return "успех";
                }
            }
            return "Ошибка";
        }
    }
}
