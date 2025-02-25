namespace AdonetFramework
{
    partial class FRMHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenCity = new System.Windows.Forms.Button();
            this.btnOpenCustomer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCity
            // 
            this.btnOpenCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOpenCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenCity.Location = new System.Drawing.Point(128, 50);
            this.btnOpenCity.Name = "btnOpenCity";
            this.btnOpenCity.Size = new System.Drawing.Size(260, 61);
            this.btnOpenCity.TabIndex = 0;
            this.btnOpenCity.Text = "Şehir İşlemleri";
            this.btnOpenCity.UseVisualStyleBackColor = false;
            this.btnOpenCity.Click += new System.EventHandler(this.btnOpenCity_Click);
            // 
            // btnOpenCustomer
            // 
            this.btnOpenCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOpenCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenCustomer.Location = new System.Drawing.Point(128, 135);
            this.btnOpenCustomer.Name = "btnOpenCustomer";
            this.btnOpenCustomer.Size = new System.Drawing.Size(260, 61);
            this.btnOpenCustomer.TabIndex = 1;
            this.btnOpenCustomer.Text = "Müşteri İşlemleri";
            this.btnOpenCustomer.UseVisualStyleBackColor = false;
            this.btnOpenCustomer.Click += new System.EventHandler(this.btnOpenCustomer_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(128, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 61);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FRMHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(73)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(519, 342);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenCustomer);
            this.Controls.Add(this.btnOpenCity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRMHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCity;
        private System.Windows.Forms.Button btnOpenCustomer;
        private System.Windows.Forms.Button btnExit;
    }
}