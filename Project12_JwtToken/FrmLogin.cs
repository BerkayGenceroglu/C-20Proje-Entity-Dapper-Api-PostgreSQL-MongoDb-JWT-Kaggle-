using Project12_JwtToken.JWT;
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

namespace Project12_JwtToken
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=Db12Project20;Integrated Security=True");


        public string token;
        private void btnLogın_Click(object sender, EventArgs e)
        {
            TokenGenarator tokenGenerator = new TokenGenarator();   
            connection.Open();
            var command = new SqlCommand("Select * from TBLUSER where USERNAME=@p1 and PASSWORD=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtUserName.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader da = command.ExecuteReader();
            if (da.Read())
            {
                string mesaj = tokenGenerator.GenerateToken2(txtUserName.Text);

                FrmEmployee frmEmployee = new FrmEmployee();
                frmEmployee.token = mesaj;
                frmEmployee.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
            connection.Close();
        }
    }
}
