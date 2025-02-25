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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        Db2project2Entities1 db = new Db2project2Entities1 ();

        void productlist()
        {
            var values = db.TBLPRODUCT.Join(db.TBLCATEGORY, product => product.CategoryId, category => category.CategoryId, (product, category) => new
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                ProductStock = product.ProductStock,
                CategoryName = category.CategoryName,
            }).ToList();
            dataGridView1.DataSource = values;
            /*  product değişkeni, TBLPRODUCT tablosundaki bir satırı temsil ediyor.
                category değişkeni, TBLCATEGORY tablosundaki bir satırı temsil ediyor.
                new { ... } → Bir nesne (anonim tip) oluşturuyor ve sadece belirlenen sütunları alıyor.
            */
            dataGridView1.DataSource = values;
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            productlist();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TBLPRODUCT productexample = new TBLPRODUCT();
            productexample.ProductName = txtProductName.Text;
            productexample.ProductPrice = decimal.Parse(txtProductPrice.Text);
            productexample.ProductStock = int.Parse(txtProductStock.Text);
            productexample.CategoryId = int.Parse(cmbCategoryId.SelectedValue.ToString());
            db.TBLPRODUCT.Add(productexample);
            db.SaveChanges();
            productlist();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = db.TBLPRODUCT.Find(id);
            db.TBLPRODUCT.Remove(value);
            db.SaveChanges();
            productlist();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = db.TBLPRODUCT.Find(id);
            value.ProductId = int.Parse(txtProductId.Text);
            value.ProductName = txtProductName.Text;
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductStock = int.Parse(txtProductStock.Text);
            value.CategoryId = int.Parse(cmbCategoryId.SelectedValue.ToString());
            db.SaveChanges();
            productlist();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            var value = db.TBLCATEGORY.ToList();
            cmbCategoryId.DataSource = value; 
            cmbCategoryId.DisplayMember = "CategoryName";
            cmbCategoryId.ValueMember = "CategoryId";

        }

        private void btnlist2_Click(object sender, EventArgs e)
        {
           productlist();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = db.TBLPRODUCT.Where(x => x.ProductName == txtProductName.Text ).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
