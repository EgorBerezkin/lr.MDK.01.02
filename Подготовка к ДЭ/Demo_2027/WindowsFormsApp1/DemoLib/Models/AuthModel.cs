using System.Collections.Generic;

namespace DemoLib.Models
{
    public class AuthModel : IAuthModel
    {
        private List<User> users_ = new List<User>();

        public AuthModel()
        {
            users_.Add(new User { Login = "administrator", FIO = "Берёзкин Егор Витальевич", Role = "Администратор", ImageUser = "../../../Images/kotik.png" });
            users_.Add(new User { Login = "meneger", FIO = "Будина Ирина Сергеевна", Role = "Менеджер", ImageUser = "../../../Images/1.png" });
            users_.Add(new User { Login = "isivanov", FIO = "Иванов Иван Сергеевич", Role = "Администратор" });

        }
        // Метод авторизации
        public User Authorize(string login)
        {
            foreach (User user in users_) // перебор пользователей из списка
            {
                if (user.Login == login) // сравнение логинов
                {
                    return user;
                }
            }
            return null;
        }
    }
}
