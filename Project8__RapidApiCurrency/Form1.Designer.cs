namespace Project8__RapidApiCurrency
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDolarAlıs = new System.Windows.Forms.Label();
            this.lblEuroAlıs = new System.Windows.Forms.Label();
            this.radiodolar = new System.Windows.Forms.RadioButton();
            this.radioEuro = new System.Windows.Forms.RadioButton();
            this.radioSterlin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBirimTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtÖdenecekTutar = new System.Windows.Forms.TextBox();
            this.btnİşlemiYap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSterlinAlıs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDolarAlıs
            // 
            this.lblDolarAlıs.AutoSize = true;
            this.lblDolarAlıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDolarAlıs.Location = new System.Drawing.Point(161, 39);
            this.lblDolarAlıs.Name = "lblDolarAlıs";
            this.lblDolarAlıs.Size = new System.Drawing.Size(57, 20);
            this.lblDolarAlıs.TabIndex = 0;
            this.lblDolarAlıs.Text = "label1";
            // 
            // lblEuroAlıs
            // 
            this.lblEuroAlıs.AutoSize = true;
            this.lblEuroAlıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblEuroAlıs.Location = new System.Drawing.Point(161, 158);
            this.lblEuroAlıs.Name = "lblEuroAlıs";
            this.lblEuroAlıs.Size = new System.Drawing.Size(57, 20);
            this.lblEuroAlıs.TabIndex = 2;
            this.lblEuroAlıs.Text = "label3";
            // 
            // radiodolar
            // 
            this.radiodolar.AutoSize = true;
            this.radiodolar.Location = new System.Drawing.Point(509, 39);
            this.radiodolar.Name = "radiodolar";
            this.radiodolar.Size = new System.Drawing.Size(70, 24);
            this.radiodolar.TabIndex = 4;
            this.radiodolar.TabStop = true;
            this.radiodolar.Text = "Dolar";
            this.radiodolar.UseVisualStyleBackColor = true;
            // 
            // radioEuro
            // 
            this.radioEuro.AutoSize = true;
            this.radioEuro.Location = new System.Drawing.Point(509, 87);
            this.radioEuro.Name = "radioEuro";
            this.radioEuro.Size = new System.Drawing.Size(65, 24);
            this.radioEuro.TabIndex = 5;
            this.radioEuro.TabStop = true;
            this.radioEuro.Text = "Euro";
            this.radioEuro.UseVisualStyleBackColor = true;
            // 
            // radioSterlin
            // 
            this.radioSterlin.AutoSize = true;
            this.radioSterlin.Location = new System.Drawing.Point(509, 139);
            this.radioSterlin.Name = "radioSterlin";
            this.radioSterlin.Size = new System.Drawing.Size(79, 24);
            this.radioSterlin.TabIndex = 6;
            this.radioSterlin.TabStop = true;
            this.radioSterlin.Text = "Sterlin";
            this.radioSterlin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(93, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dolar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Euro :";
            // 
            // txtBirimTutar
            // 
            this.txtBirimTutar.Location = new System.Drawing.Point(509, 222);
            this.txtBirimTutar.Name = "txtBirimTutar";
            this.txtBirimTutar.Size = new System.Drawing.Size(186, 26);
            this.txtBirimTutar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Birim Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ödenecek Tutar:";
            // 
            // txtÖdenecekTutar
            // 
            this.txtÖdenecekTutar.Enabled = false;
            this.txtÖdenecekTutar.Location = new System.Drawing.Point(509, 268);
            this.txtÖdenecekTutar.Name = "txtÖdenecekTutar";
            this.txtÖdenecekTutar.Size = new System.Drawing.Size(186, 26);
            this.txtÖdenecekTutar.TabIndex = 13;
            // 
            // btnİşlemiYap
            // 
            this.btnİşlemiYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnİşlemiYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİşlemiYap.ForeColor = System.Drawing.Color.Black;
            this.btnİşlemiYap.Location = new System.Drawing.Point(555, 310);
            this.btnİşlemiYap.Name = "btnİşlemiYap";
            this.btnİşlemiYap.Size = new System.Drawing.Size(140, 28);
            this.btnİşlemiYap.TabIndex = 15;
            this.btnİşlemiYap.Text = "İşlemi Yap";
            this.btnİşlemiYap.UseVisualStyleBackColor = false;
            this.btnİşlemiYap.Click += new System.EventHandler(this.btnİşlemiYap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(306, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 390);
            this.panel1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sterlin :";
            // 
            // lblSterlinAlıs
            // 
            this.lblSterlinAlıs.AutoSize = true;
            this.lblSterlinAlıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSterlinAlıs.Location = new System.Drawing.Point(161, 286);
            this.lblSterlinAlıs.Name = "lblSterlinAlıs";
            this.lblSterlinAlıs.Size = new System.Drawing.Size(57, 20);
            this.lblSterlinAlıs.TabIndex = 17;
            this.lblSterlinAlıs.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(777, 391);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSterlinAlıs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnİşlemiYap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtÖdenecekTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBirimTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioSterlin);
            this.Controls.Add(this.radioEuro);
            this.Controls.Add(this.radiodolar);
            this.Controls.Add(this.lblEuroAlıs);
            this.Controls.Add(this.lblDolarAlıs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDolarAlıs;
        private System.Windows.Forms.Label lblEuroAlıs;
        private System.Windows.Forms.RadioButton radiodolar;
        private System.Windows.Forms.RadioButton radioEuro;
        private System.Windows.Forms.RadioButton radioSterlin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBirimTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtÖdenecekTutar;
        private System.Windows.Forms.Button btnİşlemiYap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSterlinAlıs;
    }
}

