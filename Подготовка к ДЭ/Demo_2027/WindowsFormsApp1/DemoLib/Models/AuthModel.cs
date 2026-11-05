using System.Collections.Generic;

namespace DemoLib.Models
{
    public class AuthModel : IAuthModel
    {
        private List<User> users_ = new List<User>();

        public AuthModel()
        {
            users_.Add(new User { Login = "administrator", FIO = "Берёзкин Егор Витальевич", Role = "Администратор", ImageUser = "../../../Images/closeup-shot-cute-ginger-kitten-staring-camera-isolated-white-wall.jpg" });
            users_.Add(new User { Login = "meneger", FIO = "Будина Ирина Сергеевна", Role = "Менеджер", ImageUser = "../../../Images/IMG_KB_164811.png" });
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
