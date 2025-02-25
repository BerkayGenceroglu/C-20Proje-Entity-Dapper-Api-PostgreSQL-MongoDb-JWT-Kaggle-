using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_PostreSQLToDoListApp
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=275454;Database='ToDoLists';");

        void categoryList()
        {
            string query = "SELECT * FROM categories order by categoryid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.RowHeadersVisible = false;
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            categoryList();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
           categoryList();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            connection.Open();
            string addQuery = "insert into categories (categoryname) values (@categoryname)";
            using (var command = new NpgsqlCommand(addQuery, connection))
            {
                command.Parameters.AddWithValue("@categoryname", txtCategoryName.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Ekleme İşlemi Başarılı");
            }
            connection.Close();
            categoryList();
            //Using:komut nesnesi (command) iş bitince otomatik olarak kapatılıyor.using, command nesnesinin işi bitince otomatik olarak silinmesini sağlar.
            //Kaynak sızıntılarını önlüyor(manuel Dispose() çağırmana gerek kalmıyor).
            //Kodun daha temiz ve güvenli olmasını sağlıyor.
            //Yani using, komut nesnesini otomatik olarak temizleyen bir "kendi kendini kapatma" mekanizması gibi çalışıyor.
            //using içine yazılan nesne, işlem bitince otomatik olarak temizlenir ve kapatılır.
            //Bu, IDisposable arayüzünü uygulayan nesneler için geçerlidir. (Veritabanı bağlantıları, dosya işlemleri, ağ bağlantıları vb.)
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "delete from categories where categoryid=@categoryıd";
            using (var command  = new NpgsqlCommand(query,connection))
            {
                command.Parameters.AddWithValue("@categoryıd", int.Parse(txtCategoryId.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
            }
            connection.Close();
            categoryList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "Update categories set CategoryName=@categoryname where categoryid=@categoryıd";
            using (var command = new NpgsqlCommand(query,connection))
            {
                command.Parameters.AddWithValue("@categoryname", txtCategoryName.Text);
                command.Parameters.AddWithValue("@categoryıd", int.Parse(txtCategoryId.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Güncelleme İşlemi Gerçekleşti");
            }
            connection.Close();
            categoryList();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            if ((txtCategoryId.Text) == "")
            {
                MessageBox.Show("Lütfen ıd giriniz");

            }
            else
            {
                using (connection)
                {
                    connection.Open();
                    string query = "Select * from categories where CategoryId=@categoryıd";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@categoryıd", int.Parse(txtCategoryId.Text));
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }










        /* using: C#’ta using bloğu, işi biten nesneleri otomatik olarak temizler. Yani, belleği gereksiz yere doldurmalarını önler.

Bir nesne açtığında (örneğin bir veritabanı bağlantısı, dosya veya ağ isteği) işin bitince onu kapatman gerekir. Eğer kapatmazsan, gereksiz bellek kullanımı olur ve program yavaşlar.

İşte using, bu temizleme işini senin yerine yapar.using, işin bitince nesneyi otomatik olarak kapatır. */
    }
}
