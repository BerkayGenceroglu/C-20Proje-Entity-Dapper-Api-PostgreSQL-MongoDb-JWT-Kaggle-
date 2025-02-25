using Project4_EntityFrameworkCodeFirstMovie.DataAccessLayer.Context;
using Project4_EntityFrameworkCodeFirstMovie.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EntityFrameworkCodeFirstMovie
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        MovieContext db = new MovieContext();
            /*✔ Veritabanı işlemlerini yönetir.
            ✔ Veri ekleme, silme, güncelleme ve sorgulama yapmamızı sağlar.
            ✔ EF Core’un veritabanıyla etkileşime geçmesini sağlar.

            ✅ MovieContext db = new MovieContext(); diyerek, EF Core ile veritabanına erişim sağlayan bir nesne oluşturmuş oluyoruz. */
        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Categories.ToList();
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            db.Categories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Categories.Find(id);
            db.Categories.Remove(value);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Categories.Find(id);
            value.CategoryName = txtCategoryName.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Categories.Where(x => x.CategoryName.Contains(txtCategoryName.Text)).ToList();
            dataGridView1.RowHeadersVisible = false;
        }
    }
}
