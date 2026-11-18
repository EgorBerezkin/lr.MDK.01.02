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

            table.Columns.Add("Номер заказа");
            table.Columns.Add("Дата заказа");
            table.Columns.Add("ФИО покупателя");
            table.Columns.Add("Категория");
            table.Columns.Add("Товар");
            table.Columns.Add("Производство");
            table.Columns.Add("Размер");
            table.Columns.Add("Количество");
            table.Columns.Add("Цена");

            List<Order> orders = orderModel_.Load();

            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.Items)
                {
                    table.Rows.Add(
                        order.OrderNumber,
                        order.OrderDate.ToShortDateString(),
                        order.FIO,
                        item.Category,
                        item.ProductItem,
                        item.Supplier,
                        item.Size,
                        item.Count,
                        item.Price
                    );
                }
            }

            dataGridViewOrders.DataSource = table;
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

    }
}
