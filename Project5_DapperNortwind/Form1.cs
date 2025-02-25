using Dapper;
using Project5_DapperNortwind.Dtos;
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

namespace Project5_DapperNortwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=Db5Project20;Integrated Security=True;");
        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "Select * from Categories";
            //Eğer await kullanmazsan, işlem tamamlanmadan kod akışı devam eder ve sonuç eksik olabilir. await kullandığında, o işlemin tamamlanmasını bekler ama uygulamanın diğer işlemleri çalışmaya devam eder.
            dataGridView1.DataSource = await baglantı.QueryAsync<ResultCategoryDtos>(query);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query2 = "insert into Categories (CategoryName,Description) values (@p1,@p2)";
            var parametres = new DynamicParameters();
            //parametres adında bir DynamicParameters nesnesi oluşturduk.
            // DynamicParameters, SQL sorgularına güvenli ve dinamik bir şekilde parametre eklemek için kullanılan bir araçtır. 🚀
            parametres.Add("@p1", txtAd.Text);
            parametres.Add("@p2",txtAçıklama.Text);
            await baglantı.ExecuteAsync(query2, parametres);
            // Eğer ExecuteAsync() yerine senkron(Execute()) kullanırsan, SQL işlemi bitene kadar program diğer kodlara geçemez ve "donabilir".
            //Ama await kullanırsan, işlemin tamamlanmasını beklerken uygulamanın diğer işlemleri devam edebilir.
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query3 = "delete from Categories where CategoryID=@p1";
            var parametres = new DynamicParameters();
            parametres.Add("@p1", int.Parse(txtId.Text));
            await baglantı.ExecuteAsync(query3, parametres);
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query4 = "Update Categories Set CategoryName=@categoryname,Description=@description where CategoryID=@categoryId";
            var parametres = new DynamicParameters();
            parametres.Add("@categoryId", txtId.Text);
            parametres.Add("@categoryname", txtAd.Text);
            parametres.Add("@description", txtAçıklama.Text);
            await baglantı.ExecuteAsync(query4 , parametres);
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }
    }
}
