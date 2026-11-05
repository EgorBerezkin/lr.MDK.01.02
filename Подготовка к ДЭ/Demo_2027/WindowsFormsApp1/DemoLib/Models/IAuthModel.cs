namespace DemoLib.Models
{
    public interface IAuthModel
    {
        // определение метода авторизации
        User Authorize(string login);
    }
}
