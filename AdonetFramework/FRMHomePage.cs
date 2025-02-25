using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdonetFramework
{
    public partial class FRMHomePage : Form
    {
        public FRMHomePage()
        {
            InitializeComponent();
        }

        private void btnOpenCustomer_Click(object sender, EventArgs e)
        {
            FRMCustomer fr = new FRMCustomer();
            fr.ShowDialog();
        }

        private void btnOpenCity_Click(object sender, EventArgs e)
        {
            FRMCity x = new FRMCity();
            x.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
