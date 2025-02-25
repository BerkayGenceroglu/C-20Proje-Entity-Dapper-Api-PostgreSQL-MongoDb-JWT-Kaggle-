using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project19_TableStatusMomentary
{
    public partial class FrmRestaruant : Form
    {
        public FrmRestaruant()
        {
            InitializeComponent();
        }

        private void FrmRestaruant_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Db18Project20Entities db = new Db18Project20Entities();

            var buttons = this.Controls.OfType<Button>().ToList();
            foreach (var item in buttons)
            {
               this.Controls.Remove(item);
            }


            var values = db.TBLTABLES.ToList();
            int buttonWidth = 100;
            int buttonHeight = 100;
            int padding = 10;
            int xoffset = 200;
            int yoffset = 50;

            for (int i = 0; i < values.Count; i++)
            {
                var item = values[i];
                Button button = new Button();
                button.Text = $"{item.TableNumber}";
                button.Size = new Size(buttonWidth, buttonHeight);
                button.Location = new Point(xoffset + (i % 4) * (buttonWidth + padding), yoffset + (i / 4) * (buttonHeight + padding));
                if (item.Status == true)
                {
                    button.BackColor = Color.LightGreen;
                }
                else
                {
                    button.BackColor = Color.Red;
                }
                this.Controls.Add(button);
            }
        }
    }
}

//X KORDİNATI
/*
 xoffset: Başlangıçtaki yatay boşluk (kenardan ne kadar mesafede başlayacak).
(i % 4): Sütun numarasını hesaplar, yani bir satırda en fazla 4 buton olacaksa, i % 4 ile bu butonun kaçıncı sütunda olması gerektiği bulunur.
(buttonWidth + padding): Buton genişliği ve aralarındaki boşluk hesaplanarak her butonun bir öncekinin yanına eklenmesi sağlanır.
*/
//YKORDİNATI
/*
 yoffset: Başlangıçtaki dikey boşluk (üstten ne kadar mesafede başlayacak).
(i / 4): Satır numarasını hesaplar, her 4 butonda bir alt satıra geçmeyi sağlar.
(buttonHeight + padding): Buton yüksekliği ve boşluğu eklenerek her satırın bir altına buton eklenmesi sağlanır.
*/

