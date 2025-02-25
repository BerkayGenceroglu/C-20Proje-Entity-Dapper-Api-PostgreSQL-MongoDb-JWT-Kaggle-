using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_PostreSQLToDoListApp
{
    public partial class FrmProcess : Form
    {
        public FrmProcess()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=275454;Database='ToDoLists';");

        void toDoLists()
        {
            string query = "SELECT * FROM todolists order by todolistid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.RowHeadersVisible = false;
        }

        void dataUploadtoCombobox()
        {
            string query = "SELECT * FROM categories";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmbCategory.DataSource = ds;
            cmbCategory.DisplayMember = "categoryname";
            cmbCategory.ValueMember = "categoryid";
        }
        private void FrmProcess_Load(object sender, EventArgs e)
        {
            toDoLists();
            dataUploadtoCombobox();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory category = new FrmCategory();
            category.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            toDoLists();
        }

        

        private void btnCreat_Click(object sender, EventArgs e)
        {
            using (connection)
            {

                bool selectedValue = radioComplated.Checked ? true : false;
                connection.Open();
                string query = "insert into todolists (title,description,status,priority,categoryid) values (@p1,@p2,@p3,@p4,@p5)";
                using (var komut = new NpgsqlCommand(query, connection)) 
                {
                    komut.Parameters.AddWithValue("@p1", txtTıtle.Text);
                    komut.Parameters.AddWithValue("@p2", txtExplanation.Text);
                    BitArray bitValue = new BitArray(1);
                    bitValue[0] = selectedValue; // Eğer `true` ise 1, `false` ise 0 olacak
                    /*
                    BitArray(1) → 1 elemanlı bir bit dizisi oluşturur (başlangıçta 0 olur).
                    bitValue[0] = selectedValue; → Eğer true ise 1, false ise 0 olarak günceller.
                    Bu işlem PostgreSQL BIT veri tipiyle uyumlu çalışmasını sağlar
                    */
                    komut.Parameters.AddWithValue("@p3", bitValue);
                    komut.Parameters.AddWithValue("@p4", txtPriority.Text);
                    komut.Parameters.AddWithValue("@p5",int.Parse(cmbCategory.SelectedValue.ToString()));
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ekleme İşlemi Başarılı");
                }
                
                toDoLists();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "delete from todolists where todolistid=@todolistıd";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@todolistıd", int.Parse(txtProcessId.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
            }
            connection.Close();
            toDoLists();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            bool selectedValue = radioComplated.Checked ? true : false;
            string query = "Update todolists set title=@p1,description=@p2,status=@p3,priority=@p4,categoryid=@p5 where todolistid=@todolistıd";
            using (var komut = new NpgsqlCommand(query, connection))
            {
                komut.Parameters.AddWithValue("@p1", txtTıtle.Text);
                komut.Parameters.AddWithValue("@p2", txtExplanation.Text);
                BitArray bitValue = new BitArray(1);
                bitValue[0] = selectedValue; // Eğer `true` ise 1, `false` ise 0 olacak
                komut.Parameters.AddWithValue("@p3", bitValue);
                komut.Parameters.AddWithValue("@p4", txtPriority.Text);
                komut.Parameters.AddWithValue("@p5", int.Parse(cmbCategory.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@todolistıd", int.Parse(txtProcessId.Text));
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme İşlemi Gerçekleşti");
            }
            connection.Close();
            toDoLists();
        }

        private void btnContinueList_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM todolists where status='0' order by todolistid ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnCheckedList_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM todolists where status='1' order by todolistid ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnTrueList_Click(object sender, EventArgs e)
        {
            string query = "select todolistid,title,description,status,priority,categoryname from todolists \r\ninner join categories on todolists.todolistid = categories.categoryid order by todolistid ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.RowHeadersVisible = false;
        }
    }
}
