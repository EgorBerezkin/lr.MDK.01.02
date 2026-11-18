using System;
using System.Windows.Forms;
using DemoLib;
using DemoLib.Models;
using DemoLib.Presenters;
using DemoLib.Views;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form, ILoginView
    {
        private AuthPresenter presenter_;

        private Color normalColor_ = ColorTranslator.FromHtml("#FFFFFF");
        private Color enteringColor_ = ColorTranslator.FromHtml("#70B2AF");

        public LoginForm()
        {
            InitializeComponent();
            presenter_ = new AuthPresenter(new AuthModel(), this);

            buttonLogin.MouseMove += buttonLogin_MouseMove;
            buttonLogin.MouseLeave += buttonLogin_MouseLeave;

            buttonLoginClient.MouseMove += buttonLoginClient_MouseMove;
            buttonLoginClient.MouseLeave += buttonLoginClient_MouseLeave;
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
                ImageUser = "../../../Images/images.png"
            };
            Hide();
            using (MainForm form = new MainForm(guestUser))
            {
                form.ShowDialog();
            }
            this.Close();
        }
        private void buttonLogin_MouseMove(object sender, MouseEventArgs e)
        {
            buttonLogin.BackColor = enteringColor_;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = normalColor_;
        }

        private void buttonLoginClient_MouseMove(object sender, MouseEventArgs e)
        {
            buttonLoginClient.BackColor = enteringColor_;
        }

        private void buttonLoginClient_MouseLeave(object sender, EventArgs e)
        {
            buttonLoginClient.BackColor = normalColor_;
        }
    }
}
