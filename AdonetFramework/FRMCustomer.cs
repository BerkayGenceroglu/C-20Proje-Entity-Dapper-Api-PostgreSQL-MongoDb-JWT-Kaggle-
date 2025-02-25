using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdonetFramework
{
    public partial class FRMCustomer : Form
    {
        public FRMCustomer()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True;");


        private void btnSelect_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand select = new SqlCommand("execute customerlistwithcity", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(select);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            baglantı.Close();
        }

        private void FRMCustomer_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand select = new SqlCommand("select * from TBLCITY", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(select);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCity.ValueMember = "CityID";
            cmbCity.DisplayMember = "CityName";
            cmbCity.DataSource = dt;
            baglantı.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand insert = new SqlCommand("insert into TBLCUSTOMER (CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CustomerCity) values (@customername,@customersurname,@customerbalance,@customerstatus,@customercity)", baglantı);
            insert.Parameters.AddWithValue("customername", txtCustomerName.Text);
            insert.Parameters.AddWithValue("customersurname", txtCustomerSurname.Text);
            insert.Parameters.AddWithValue("customerbalance", txtCustomerBalance.Text);
            insert.Parameters.AddWithValue("customercity", cmbCity.SelectedValue);
            if (radioActive.Checked)
            {
                insert.Parameters.AddWithValue("customerstatus", true);
            }
            if (radioİnactive.Checked)
            {
                insert.Parameters.AddWithValue("customerstatus", false);
            }
            insert.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("ekleme işlemi başarılı");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand delete = new SqlCommand("delete from TBLCUSTOMER where CustomerID=@customerıd ", baglantı);
            delete.Parameters.AddWithValue("@customerıd", txtCustomerId.Text);
            delete.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Silme İşlemi Başarılı bir şekilde yapıldı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand update = new SqlCommand("update TBLCUSTOMER set CUSTOMERNAME=@customername ,CUSTOMERSURNAME=@customersurname,CustomerBalance=@customerbalance,  CustomerStatus=@customerbalance,CustomerCity=@customercity where CustomerID=@p1", baglantı);
            update.Parameters.AddWithValue("@p1", txtCustomerId.Text);
            update.Parameters.AddWithValue("@customername", txtCustomerName.Text);
            update.Parameters.AddWithValue("@customersurname", txtCustomerSurname.Text);
            update.Parameters.AddWithValue("@customerbalance", txtCustomerBalance.Text);
            if (radioActive.Checked)
            {
                update.Parameters.AddWithValue("customerstatus", true);
            }
            if (radioİnactive.Checked)
            {
                update.Parameters.AddWithValue("customerstatus", false);
            }
            update.Parameters.AddWithValue("@customercity", cmbCity.SelectedValue);
            update.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand search = new SqlCommand("select * from TBLCUSTOMER where CustomerID=@customerıd", baglantı);
            search.Parameters.AddWithValue("@customerıd", txtCustomerId.Text);
            SqlDataAdapter da = new SqlDataAdapter(search);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            baglantı.Close();
        }
    }
}
