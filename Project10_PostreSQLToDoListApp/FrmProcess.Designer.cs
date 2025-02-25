namespace Project10_PostreSQLToDoListApp
{
    partial class FrmProcess
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.txtProcessId = new System.Windows.Forms.TextBox();
            this.txtTıtle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioComplated = new System.Windows.Forms.RadioButton();
            this.radioContinue = new System.Windows.Forms.RadioButton();
            this.btnCreat = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTrueList = new System.Windows.Forms.Button();
            this.btnCheckedList = new System.Windows.Forms.Button();
            this.btnContinueList = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnCategory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Id:";
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnList.Location = new System.Drawing.Point(373, 24);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(192, 34);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtProcessId
            // 
            this.txtProcessId.Location = new System.Drawing.Point(107, 24);
            this.txtProcessId.Name = "txtProcessId";
            this.txtProcessId.Size = new System.Drawing.Size(231, 26);
            this.txtProcessId.TabIndex = 2;
            // 
            // txtTıtle
            // 
            this.txtTıtle.Location = new System.Drawing.Point(107, 64);
            this.txtTıtle.Name = "txtTıtle";
            this.txtTıtle.Size = new System.Drawing.Size(231, 26);
            this.txtTıtle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlık:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategori:";
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(107, 154);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(231, 26);
            this.txtPriority.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Öncelik:";
            // 
            // txtExplanation
            // 
            this.txtExplanation.Location = new System.Drawing.Point(107, 207);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(231, 171);
            this.txtExplanation.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Açıklama:";
            // 
            // radioComplated
            // 
            this.radioComplated.AutoSize = true;
            this.radioComplated.Location = new System.Drawing.Point(107, 384);
            this.radioComplated.Name = "radioComplated";
            this.radioComplated.Size = new System.Drawing.Size(123, 24);
            this.radioComplated.TabIndex = 11;
            this.radioComplated.TabStop = true;
            this.radioComplated.Text = "Tamamlandı";
            this.radioComplated.UseVisualStyleBackColor = true;
            // 
            // radioContinue
            // 
            this.radioContinue.AutoSize = true;
            this.radioContinue.Location = new System.Drawing.Point(107, 420);
            this.radioContinue.Name = "radioContinue";
            this.radioContinue.Size = new System.Drawing.Size(137, 24);
            this.radioContinue.TabIndex = 12;
            this.radioContinue.TabStop = true;
            this.radioContinue.Text = "Devam Ediyor";
            this.radioContinue.UseVisualStyleBackColor = true;
            // 
            // btnCreat
            // 
            this.btnCreat.BackColor = System.Drawing.Color.Red;
            this.btnCreat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreat.Location = new System.Drawing.Point(373, 71);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(192, 34);
            this.btnCreat.TabIndex = 13;
            this.btnCreat.Text = "Oluştur";
            this.btnCreat.UseVisualStyleBackColor = false;
            this.btnCreat.Click += new System.EventHandler(this.btnCreat_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(373, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 34);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(373, 186);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 34);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTrueList
            // 
            this.btnTrueList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTrueList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrueList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrueList.Location = new System.Drawing.Point(373, 357);
            this.btnTrueList.Name = "btnTrueList";
            this.btnTrueList.Size = new System.Drawing.Size(192, 34);
            this.btnTrueList.TabIndex = 16;
            this.btnTrueList.Text = "Doğru Liste";
            this.btnTrueList.UseVisualStyleBackColor = false;
            this.btnTrueList.Click += new System.EventHandler(this.btnTrueList_Click);
            // 
            // btnCheckedList
            // 
            this.btnCheckedList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheckedList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckedList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckedList.Location = new System.Drawing.Point(373, 302);
            this.btnCheckedList.Name = "btnCheckedList";
            this.btnCheckedList.Size = new System.Drawing.Size(192, 34);
            this.btnCheckedList.TabIndex = 17;
            this.btnCheckedList.Text = "Tamamlananlar";
            this.btnCheckedList.UseVisualStyleBackColor = false;
            this.btnCheckedList.Click += new System.EventHandler(this.btnCheckedList_Click);
            // 
            // btnContinueList
            // 
            this.btnContinueList.BackColor = System.Drawing.Color.Gray;
            this.btnContinueList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinueList.Location = new System.Drawing.Point(373, 240);
            this.btnContinueList.Name = "btnContinueList";
            this.btnContinueList.Size = new System.Drawing.Size(192, 34);
            this.btnContinueList.TabIndex = 18;
            this.btnContinueList.Text = "Devam Edenler";
            this.btnContinueList.UseVisualStyleBackColor = false;
            this.btnContinueList.Click += new System.EventHandler(this.btnContinueList_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(107, 103);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(231, 28);
            this.cmbCategory.TabIndex = 19;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Blue;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCategory.Location = new System.Drawing.Point(373, 410);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(192, 34);
            this.btnCategory.TabIndex = 20;
            this.btnCategory.Text = "Kategori Listesi";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(608, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 420);
            this.dataGridView1.TabIndex = 21;
            // 
            // FrmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(191)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1382, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnContinueList);
            this.Controls.Add(this.btnCheckedList);
            this.Controls.Add(this.btnTrueList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreat);
            this.Controls.Add(this.radioContinue);
            this.Controls.Add(this.radioComplated);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTıtle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProcessId);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtProcessId;
        private System.Windows.Forms.TextBox txtTıtle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioComplated;
        private System.Windows.Forms.RadioButton radioContinue;
        private System.Windows.Forms.Button btnCreat;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTrueList;
        private System.Windows.Forms.Button btnCheckedList;
        private System.Windows.Forms.Button btnContinueList;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

