using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DemoLib;
using DemoLib.Models;
using DemoLib.Presenters;
using DemoLib.Views;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form, ILoginView
    {
        private AuthPresenter presenter_;
        public LoginForm()
        {
            InitializeComponent();
            presenter_ = new AuthPresenter(new AuthModel(), this);
        }
        public string Login // получение текста, который был введен в текст бокс
        {
            get { return textBoxLogin.Text; }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            presenter_.Login();
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void OpenMainForm(User user)
        {
            Hide();
            using (MainForm form = new MainForm(user))
            {
                form.ShowDialog();
            }
            this.Close();
        }

        private void buttonLoginClient_Click(object sender, EventArgs e)
        {
            User guestUser = new User
            {
                Login = "guest",
                FIO = "Неавторизованный",
                Role = "пользователь",
                ImageUser = "../../../Images/kotik.png"
            };
            Hide();
            using (MainForm form = new MainForm(guestUser))
            {
                form.ShowDialog();
            }
            this.Close();
        }
    }
}
