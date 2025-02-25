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

namespace Project14_SQLAllRelations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=Db14Project20;Integrated Security=True;");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'db14Project20DataSet8.TeamSponsors' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teamSponsorsTableAdapter.Fill(this.db14Project20DataSet8.TeamSponsors);
            // TODO: Bu kod satırı 'db14Project20DataSet7.TeamDetails' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teamDetailsTableAdapter1.Fill(this.db14Project20DataSet7.TeamDetails);
            // TODO: Bu kod satırı 'db14Project20DataSet6.Sponsors' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sponsorsTableAdapter.Fill(this.db14Project20DataSet6.Sponsors);
            // TODO: Bu kod satırı 'db14Project20DataSet3.TeamDetails' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.teamDetailsTableAdapter.Fill(this.db14Project20DataSet3.TeamDetails);
            // TODO: Bu kod satırı 'db14Project20DataSet2.Teams' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teamsTableAdapter1.Fill(this.db14Project20DataSet2.Teams);
            // TODO: Bu kod satırı 'db14Project20DataSet1.Teams' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teamsTableAdapter.Fill(this.db14Project20DataSet1.Teams);
            // TODO: Bu kod satırı 'db14Project20DataSet.Players' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            this.playersTableAdapter.Fill(this.db14Project20DataSet.Players);

            baglantı.Open();
            SqlCommand komut = new SqlCommand("execute procedure1",baglantı);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.RowHeadersVisible = false;
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("execute procedure2", baglantı);
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(komut);
            DataTable dataTable2 = new DataTable();
            dataAdapter.Fill(dataTable2);
            dataGridView4.DataSource = dataTable2;
            dataGridView4.RowHeadersVisible = false;
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("execute procedure3", baglantı);
            SqlDataAdapter dataAdapter3 = new SqlDataAdapter(komut);
            DataTable dataTable3 = new DataTable();
            dataAdapter.Fill(dataTable3);
            dataGridView5.DataSource = dataTable3;
            dataGridView5.RowHeadersVisible = false;
            baglantı.Close();

        }
    }
}
