using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DemoLib;

namespace WindowsFormsApp1
{
    public partial class OrderInfoForm : Form
    {
        private Order order_;
        public OrderInfoForm(Order order)
        {
            InitializeComponent();
            order_ = order;

            Text = "Информация о заказе №" + order_.Id;
            LoadOrderInfo();
        }
        private void LoadOrderInfo()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID товара");
            table.Columns.Add("Название товара");
            table.Columns.Add("Категория");
            table.Columns.Add("Производитель");
            table.Columns.Add("Размер");
            table.Columns.Add("Количество");
            table.Columns.Add("Цена");

            int itemId = 1;

            foreach (OrderItem item in order_.Items)
            {
                table.Rows.Add(
                    itemId,
                    item.ProductItem,
                    item.Category,
                    item.Supplier,
                    item.Size,
                    item.Count,
                    item.Price.ToString("0.00") + " руб."
                );

                itemId++;
            }

            dataGridViewOrder.DataSource = table;
        }

        private void OrderInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
