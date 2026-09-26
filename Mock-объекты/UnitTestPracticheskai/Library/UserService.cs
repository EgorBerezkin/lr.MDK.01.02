using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class UserService
    {
        IUserRepository repository_; // создание переменной
        public UserService(IUserRepository repository) // конструктор класса, получающий репозиторий извне
        {
            repository_ = repository;
        }

        public string Autorization(string login, string password) // создание метода авторизации
        {
            string result = "Ошибка"; // переменная
            User user = repository_.GetUser(login); // получение пользователя
            if (user.Password == password) // проверяем пароль, совпадает ли он
            {
                result = "true";
            }
            else
            {
                result = "Ошибка (проверьте введённые данные)";
            }
            return result; // возвращаем результат
        }

        public string Registrazia(string login, string password) // создание метода регистрации
        {
            // exsisting - существующий
            var exsisting = repository_.GetUser(login); // поиск пользователя с указанным логином
            if (exsisting != null) // проверка существования (пользователь найден)
            {
                return "пользователь уже существует";
            }
            User newUser = new User // создание нового пользователя
            {
                Login = login,
                Password = password,
            };
            repository_.AddUser(newUser); // передача пользователя в репозиторий
            return "успех";
        }

        
    }
}
