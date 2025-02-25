using Project12_JwtToken.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=Db12Project20;Integrated Security=True");

        public string token;
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = token;
            TokenValidator validator = new TokenValidator();
            var principal = validator.validateJwtToken(token);
            if (principal != null)
            {
                string userName = principal.FindFirst(ClaimTypes.NameIdentifier).Value;
                MessageBox.Show("Hoşgeldiniz " + userName);
                connection.Open();
                SqlCommand select = new SqlCommand("Select * from TBLEMPLOYEE", connection);
                SqlDataAdapter da = new SqlDataAdapter(select);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
                connection.Close();
            }
            else
            {
                MessageBox.Show("Geçersiz Token!"); 
            }
            //-----------------------------------------------
            /*
             out keywordü, bir metottan birden fazla değer döndürmek için kullanılır.
             Eğer metot çağırırken out parametresi varsa, o değişkene metot içinde bir değer atanmalıdır.*/
        }
    }
}
