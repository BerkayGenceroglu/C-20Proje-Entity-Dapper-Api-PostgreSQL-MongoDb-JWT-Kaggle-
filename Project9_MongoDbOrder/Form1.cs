using Project9_MongoDbOrder.Entities;
using Project9_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OrderOperation operation = new OrderOperation();

        private void ClearValues()
        {
            txtCity.Text = "";
            txtCustomerName.Text = "";
            txtDistrict.Text = "";
            txtTotalPrice.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                CustomerName = txtCustomerName.Text,
                City = txtCity.Text,
                District = txtDistrict.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
            };
            operation.AddOrder(order);
            MessageBox.Show("Ekleme İşlemi Gerçekleşti");
            ClearValues();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Order> orders = operation.GetAllOrders();
            dataGridView1.DataSource = orders;
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            operation.DeleteOrder(orderId);
            MessageBox.Show("Silme İşlemi Gerçekleşti");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Order updatedOrder = new Order();
            updatedOrder.City = txtCity.Text;
            updatedOrder.OrderId = txtOrderId.Text;
            updatedOrder.District = txtDistrict.Text;
            updatedOrder.CustomerName = txtCustomerName.Text;
            updatedOrder.TotalPrice = decimal.Parse(txtTotalPrice.Text);
            operation.UpdateOrder(updatedOrder);
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtOrderId.Text;
            Order searchedOrder = operation.GetByOrder(id);
            dataGridView1.DataSource = new List<Order> { searchedOrder} ;
            dataGridView1.RowHeadersVisible = false;
        }
    }
}
