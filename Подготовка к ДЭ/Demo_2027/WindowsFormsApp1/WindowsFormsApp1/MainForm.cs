using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DemoLib;
using DemoLib.Models;
using DemoLib.Presenters;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private ProductsPresenter productsPresenter_;
        private PostgreProductsModel model_;
        private PostgreOrderModel orderModel_;
        private User user_;
        private List<Order> orders_;
        private FilterParametr parametrs_ = new FilterParametr();
        public MainForm(User user)
        {
            InitializeComponent();
            model_ = new PostgreProductsModel();
            orderModel_ = new PostgreOrderModel();

            productsPresenter_ = new ProductsPresenter(model_);
            user_ = user;

            labelFIO.Text = user.FIO;
            labelRol.Text = user.Role;

            if (user_.Role == "пользователь")
            {
                panelFunctional.Visible = false;
                tabControlVklads.TabPages.Remove(tabPageOrders);
            }

            // Добавление категорий в ComboBox
            CategoryComboBox.Items.Add("Все товары");
            CategoryComboBox.Items.AddRange(model_.GetAllCategories().ToArray());

            CategoryComboBox.SelectedIndex = 0;
            parametrs_.Category = "Все товары";
            parametrs_.SearchText = "";
        }

        private void LoadOrders()
        {
            System.Data.DataTable table = new System.Data.DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Дата заказа");
            table.Columns.Add("ФИО покупателя");
            table.Columns.Add("Общая сумма");

            List<Order> orders = orderModel_.Load();
            orders_ = orders;

            foreach (Order order in orders)
            {
                table.Rows.Add(order.Id, order.OrderDate.ToShortDateString(), order.FIO, order.TotalSum.ToString() + " руб.");
            }
            dataGridViewOrders.DataSource = table; // table - предварительтная запись информации о заказах
            dataGridViewOrders.CellDoubleClick += dataGridViewOrders_CellDoubleClick;
        }

        public void ShowImage(string imageUser)
        {
            // Проверка, чтобы не было ошибки при пустой строке
            if (!string.IsNullOrEmpty(imageUser))
            {
                pictureBoxImageUser.Load(imageUser);
            }
            // pictureBoxImageUser.Load(imageUser);
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

            productsPresenter_.Update(model_.Load());
            productsPresenter_.Filter(parametrs_);
            ShowImage(user_.ImageUser);

            LoadOrders();
        }

        private void PriceSortingCombobox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (PriceSortingCombobox.SelectedIndex < 0)
            {
                return;
            }
            DemoLib.SortOrder sortingOrder = (DemoLib.SortOrder)PriceSortingCombobox.SelectedIndex;
            productsPresenter_.SortByPrice(sortingOrder);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            parametrs_.SearchText = textBoxSearch.Text.ToLower();
            productsPresenter_.Filter(parametrs_);
        }
        
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex < 0)
            {
                return;
            }
            parametrs_.Category = CategoryComboBox.SelectedItem.ToString(); productsPresenter_.Filter(parametrs_);
            productsPresenter_.Filter(parametrs_);
        }

        private void dataGridViewOrders_CellDoubleClick( object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int orderId = Convert.ToInt32( dataGridViewOrders.Rows[e.RowIndex].Cells["ID"].Value);

            Order selectedOrder = orders_.Find(x => x.Id == orderId);

            if (selectedOrder != null)
            {
                using (OrderInfoForm form = new OrderInfoForm(selectedOrder))
                {
                    form.ShowDialog(this);
                }
            }
        }

        private void MainLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
