using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IUserRepository
    {
        List<User> GetUsers(); // мы берем с бд
        User GetUser(string login); // метод ищущий пользователя по логину
        void AddUser(User user); // добавление пользователя
        void SaveChanges(); // сохранение изменения
    }
}
