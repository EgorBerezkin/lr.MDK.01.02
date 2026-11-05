namespace DemoLib.Views
{
    public interface ILoginView
    {
        string Login { get; } // получение логина

        void ShowMessage(string message);

        void OpenMainForm(User user); // открытие формы
    }
}
