using System.Windows.Forms;
using DemoLib;
using DemoLib.Models;
using DemoLib.Presenters;
using DemoLib.Views;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private ProductsPresenter productsPresenter_;
        private ProductsModel model_ = new ProductsModel();
        private User user_;
        public MainForm(User user)
        {
            InitializeComponent();
            productsPresenter_ = new ProductsPresenter(model_);
            user_ = user;

            labelFIO.Text = user.FIO;
            labelRol.Text = user.Role;


        }

        public void ShowImage(string imageUser)
        {
            pictureBoxImageUser.Load(imageUser);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            int countProducts = model_.GetCountProducts();
            for (int i = 0; i < countProducts; i++)
            {
                DemoUIComponents.ProductCard card = new DemoUIComponents.ProductCard();
                MainLayout.Controls.Add(card);

                productsPresenter_.AddView(card);
            }

            productsPresenter_.Update();
            ShowImage(user_.ImageUser);
        }
    }
}
