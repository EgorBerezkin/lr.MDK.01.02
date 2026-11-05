using DemoLib.Models;
using DemoLib.Views;

namespace DemoLib.Presenters
{
    public class AuthPresenter
    {
        private IAuthModel model_;
        private ILoginView view_;

        public AuthPresenter(IAuthModel model, ILoginView view)
        {
            model_ = model;
            view_ = view;
        }
        // метод для проверки пользователя
        public void Login()
        {
            if (string.IsNullOrWhiteSpace(view_.Login))
            {
                view_.ShowMessage("Введите логин!");
                return;
            }

            User user = model_.Authorize(view_.Login);

            if (user == null)
            {
                view_.ShowMessage("Пользователь не найден!");
                return;
            }

            view_.OpenMainForm(user);
        }
    }
}
