using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project18_DasshboardSuperStoreDataset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=Db17Project20;Integrated Security=True;");

        public void urunListele()
        {
            baglantı.Open();
            SqlCommand listProduct = new SqlCommand("select count(*) from superstore",baglantı);
            SqlDataReader dr = listProduct.ExecuteReader();
            while (dr.Read())
            {
                lblProductCount.Text = dr[0].ToString();
            }
            baglantı.Close();   
        }

        public void sehirSayısı() {
            baglantı.Open();
            SqlCommand listProduct = new SqlCommand("select count(distinct(state)) from superstore", baglantı);
            SqlDataReader dr = listProduct.ExecuteReader();
            while (dr.Read())
            {
                lblCityCount.Text = dr[0].ToString();
            }
            baglantı.Close();
        }

        public void turkiyeSiparis()
        {
            baglantı.Open();
            SqlCommand listProduct = new SqlCommand("select count(*) from superstore where country ='Turkey'", baglantı);
            SqlDataReader dr = listProduct.ExecuteReader();
            while (dr.Read())
            {
                lblOrderCountbyTurkey.Text = dr[0].ToString();
            }
            baglantı.Close();
        }

        public void orderCount()
        {
            baglantı.Open();
            SqlCommand listProduct = new SqlCommand("select sum(Quantity) from superstore", baglantı);
            SqlDataReader dr = listProduct.ExecuteReader();
            while (dr.Read())
            {
                lblSumOrder.Text = dr[0].ToString();
            }
            baglantı.Close();
        }

        public void ulke_satıs()
        {
            //GROUP BY country ifadesi ile her ülke için ayrı bir grup oluşturulur.
            //COUNT(*) bu gruplardaki toplam satır sayısını hesaplar.
            baglantı.Open();
            SqlCommand listProduct = new SqlCommand("select top(7) country,count(*) from superstore group by country order by count(*) desc", baglantı);
            SqlDataReader dr = listProduct.ExecuteReader();
            while (dr.Read())
            {
               chart1.Series["Satış-Ülke"].Points.AddXY(dr[0], dr[1]);
            }
            baglantı.Close();
        }
       
        public void urun_satıs()
        {
            baglantı.Open();
            SqlCommand listProduct = new SqlCommand("select top(4) country,count(*) from superstore group by country order by count(*) desc", baglantı);
            SqlDataReader dr = listProduct.ExecuteReader();
            while (dr.Read())
            {
                chart2.Series["ToplamSatıs"].Points.AddXY(dr[0], dr[1]);
            }
            baglantı.Close();
        }

        public void oncelik()
        {
            baglantı.Open();
            SqlCommand listProduct = new SqlCommand("select Order_Priority ,count(*) from superstore group by Order_Priority order by count(*) desc", baglantı);
            SqlDataReader dr = listProduct.ExecuteReader();
            while (dr.Read())
            {
                chart3.Series["Oncelik"].Points.AddXY(dr[0], dr[1]);
            }
            baglantı.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            urunListele(); 
            sehirSayısı();
            turkiyeSiparis();   
            orderCount();
            ulke_satıs();
            urun_satıs();
            oncelik();
        }


    }
}
