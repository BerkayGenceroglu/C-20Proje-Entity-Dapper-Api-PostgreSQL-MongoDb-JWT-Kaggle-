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
    public partial class FRMCity : Form
    {
        public FRMCity()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True;");
        private void btnSelect_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand select = new SqlCommand("Select * from TBLCITY", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(select);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            dataGridView1.RowHeadersVisible = false;
            baglantı.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand insert = new SqlCommand("insert into TBLCITY (CityName,CityCountry) values (@cityname,@citycountry)", baglantı);
            insert.Parameters.AddWithValue("@cityname", txtCityName.Text);
            insert.Parameters.AddWithValue("@citycountry", txtCountry.Text);
            insert.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı bir şekilde yapıldı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand delete = new SqlCommand("delete from TBLCITY where CityID=@cityıd", baglantı);
            delete.Parameters.AddWithValue("@cityıd", txtCityId.Text);
            delete.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Silme İşlemi Başarılı bir şekilde yapıldı");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtCityId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtCityName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtCountry.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand update = new SqlCommand("update TBLCITY set CityName=@cityname,CityCountry=@citycountry where CityID=@cityıd", baglantı);
            update.Parameters.AddWithValue("@cityname", txtCityName.Text);
            update.Parameters.AddWithValue("@citycountry", txtCountry.Text);
            update.Parameters.AddWithValue("@cityıd", txtCityId.Text);
            update.ExecuteNonQuery();
            baglantı.Close() ;
            MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand search = new SqlCommand("select * from TBLCITY where CityName=@cityname", baglantı);
            search.Parameters.AddWithValue("@cityname", txtCityName.Text);
            SqlDataAdapter da = new SqlDataAdapter(search);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            baglantı.Close();
        }

        private void FRMCity_Load(object sender, EventArgs e)
        {

        }
    }
}
