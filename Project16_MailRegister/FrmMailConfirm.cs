using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project16_MailRegister
{
    public partial class FrmMailConfirm : Form
    {
        public FrmMailConfirm()
        {
            InitializeComponent();
        }
        public string email;
        Db16Project20Entities2 context = new Db16Project20Entities2();
        private void txtProcessActivation_Click(object sender, EventArgs e)
        {
            
            var value = context.TBLUSER.Where(x => x.Email == email).Select(y => y.ConfirmCode).FirstOrDefault();

            if (txtConfirmCode.Text == value)
            {
                var value2 = context.TBLUSER.Where(x => x.Email == email).FirstOrDefault();
                value2.IsConfirm = true;
                context.SaveChanges();
                MessageBox.Show("Hesabınız Aktif Edildi");
            }
            else
            {
                MessageBox.Show("Hatalı Kod Tekrar Deneyiniz");

            }
        }

        private void FrmMailConfirm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = email;
        }
    }
}
