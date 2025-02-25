using Project4_EntityFrameworkCodeFirstMovie.DataAccessLayer.Context;
using Project4_EntityFrameworkCodeFirstMovie.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EntityFrameworkCodeFirstMovie
{
    public partial class FrmMovie : Form
    {
        public FrmMovie()
        {
            InitializeComponent();
        }
        
        MovieContext db = new MovieContext();
        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Movies.ToList();
            dataGridView1.RowHeadersVisible = false;
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            var values=db.Categories.ToList();
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.DataSource= values;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MovieTitle = txtName.Text;
            movie.Duration = int.Parse(txtDuration.Text);
            movie.Description = txtExplanation.Text;
            movie.CreatedDate = DateTime.Parse(mskViewingDate.Text);
            movie.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            db.Movies.Add(movie);
            db.SaveChanges();
            MessageBox.Show("ekleme İşlemi Başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Movies.Find(id);
            db.Movies.Remove(value);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Movies.Find(id);
            value.MovieTitle = txtName.Text;
            value.Duration = int.Parse(txtDuration.Text);
            value.Description = txtExplanation.Text;
            value.CreatedDate = DateTime.Parse(mskViewingDate.Text);
            value.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            db.SaveChanges();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Movies.Where(x => x.MovieTitle.Contains(txtName.Text)).ToList();
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnRelationshipList_Click(object sender, EventArgs e)
        {
            var values = db.Movies.Join(db.Categories,
                movie => movie.CategoryId,
                category => category.CategoryId,
            //movie, Movies tablosundan gelen her bir satırdır category, Categories tablosundan gelen her bir satırdır.
                (movie, category) => new
                {
                    MovieId = movie.MovieId,
                    MovieTıtle = movie.MovieTitle,
                    Duration = movie.Duration,
                    Description = movie.Description,
                    Date = movie.CreatedDate,
                    CategoryName = category.CategoryName
                }).ToList();
            dataGridView1.DataSource = values;
            dataGridView1.RowHeadersVisible = false;
                
        }
    }
}
