using Project12_JwtToken.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
    public partial class FrmTokenGenerator : Form
    {
        public FrmTokenGenerator()
        {
            InitializeComponent();
        }

        private void btnCreateToken_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string email = txtemail.Text;
            string name = txtname.Text;
            string surname = txtsurname.Text;
            TokenGenarator tokenGenarator = new TokenGenarator();
            string token = tokenGenarator.GenerateToken(username,email,name,surname);
            rchtoken.Text = token;
        }
    }
}
