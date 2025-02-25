using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EntityFrameworkDbFirstProduct
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        Db2project2Entities1 db = new Db2project2Entities1();

        void categorylist()
        {
            dataGridView1.DataSource = db.TBLCATEGORY.ToList();
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            categorylist();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TBLCATEGORY tBLCATEGORY = new TBLCATEGORY();
            tBLCATEGORY.CategoryName = txtCategoryAd.Text;
            db.TBLCATEGORY.Add(tBLCATEGORY);
            db.SaveChanges();
            //Kod nesne tabanlı (OOP) çalıştığı için önce nesne oluşturup sonra içine değer atıyoruz.
            categorylist();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryID.Text);
            var value = db.TBLCATEGORY.Find(id);
            db.TBLCATEGORY.Remove(value);
            db.SaveChanges();
            categorylist();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryID.Text);
            var value = db.TBLCATEGORY.Find(id);
            value.CategoryName = txtCategoryAd.Text;
            db.SaveChanges();
            categorylist();
        }
    }
}
