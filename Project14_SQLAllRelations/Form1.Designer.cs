namespace Project14_SQLAllRelations
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.db14Project20DataSet = new Project14_SQLAllRelations.Db14Project20DataSet();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new Project14_SQLAllRelations.Db14Project20DataSetTableAdapters.PlayersTableAdapter();
            this.db14Project20DataSet1 = new Project14_SQLAllRelations.Db14Project20DataSet1();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new Project14_SQLAllRelations.Db14Project20DataSet1TableAdapters.TeamsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.db14Project20DataSet2 = new Project14_SQLAllRelations.Db14Project20DataSet2();
            this.teamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter1 = new Project14_SQLAllRelations.Db14Project20DataSet2TableAdapters.TeamsTableAdapter();
            this.teamIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db14Project20DataSet3 = new Project14_SQLAllRelations.Db14Project20DataSet3();
            this.teamDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamDetailsTableAdapter = new Project14_SQLAllRelations.Db14Project20DataSet3TableAdapters.TeamDetailsTableAdapter();
            this.db14Project20DataSet4 = new Project14_SQLAllRelations.Db14Project20DataSet4();
            this.db14Project20DataSet5 = new Project14_SQLAllRelations.Db14Project20DataSet5();
            this.db14Project20DataSet6 = new Project14_SQLAllRelations.Db14Project20DataSet6();
            this.sponsorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sponsorsTableAdapter = new Project14_SQLAllRelations.Db14Project20DataSet6TableAdapters.SponsorsTableAdapter();
            this.sponsorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sponsorNmaeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db14Project20DataSet7 = new Project14_SQLAllRelations.Db14Project20DataSet7();
            this.teamDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamDetailsTableAdapter1 = new Project14_SQLAllRelations.Db14Project20DataSet7TableAdapters.TeamDetailsTableAdapter();
            this.db14Project20DataSet8 = new Project14_SQLAllRelations.Db14Project20DataSet8();
            this.teamSponsorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamSponsorsTableAdapter = new Project14_SQLAllRelations.Db14Project20DataSet8TableAdapters.TeamSponsorsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSponsorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sponsorIdDataGridViewTextBoxColumn,
            this.sponsorNmaeDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.sponsorsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(782, 267);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(393, 233);
            this.dataGridView3.TabIndex = 3;
            // 
            // db14Project20DataSet
            // 
            this.db14Project20DataSet.DataSetName = "Db14Project20DataSet";
            this.db14Project20DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.db14Project20DataSet;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // db14Project20DataSet1
            // 
            this.db14Project20DataSet1.DataSetName = "Db14Project20DataSet1";
            this.db14Project20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.db14Project20DataSet1;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamIdDataGridViewTextBoxColumn1,
            this.teamNameDataGridViewTextBoxColumn,
            this.teamCountryDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.teamsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 267);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(396, 233);
            this.dataGridView2.TabIndex = 4;
            // 
            // db14Project20DataSet2
            // 
            this.db14Project20DataSet2.DataSetName = "Db14Project20DataSet2";
            this.db14Project20DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource1
            // 
            this.teamsBindingSource1.DataMember = "Teams";
            this.teamsBindingSource1.DataSource = this.db14Project20DataSet2;
            // 
            // teamsTableAdapter1
            // 
            this.teamsTableAdapter1.ClearBeforeFill = true;
            // 
            // teamIdDataGridViewTextBoxColumn1
            // 
            this.teamIdDataGridViewTextBoxColumn1.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.Name = "teamIdDataGridViewTextBoxColumn1";
            this.teamIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            // 
            // teamCountryDataGridViewTextBoxColumn
            // 
            this.teamCountryDataGridViewTextBoxColumn.DataPropertyName = "TeamCountry";
            this.teamCountryDataGridViewTextBoxColumn.HeaderText = "TeamCountry";
            this.teamCountryDataGridViewTextBoxColumn.Name = "teamCountryDataGridViewTextBoxColumn";
            // 
            // db14Project20DataSet3
            // 
            this.db14Project20DataSet3.DataSetName = "Db14Project20DataSet3";
            this.db14Project20DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamDetailsBindingSource
            // 
            this.teamDetailsBindingSource.DataMember = "TeamDetails";
            this.teamDetailsBindingSource.DataSource = this.db14Project20DataSet3;
            // 
            // teamDetailsTableAdapter
            // 
            this.teamDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // db14Project20DataSet4
            // 
            this.db14Project20DataSet4.DataSetName = "Db14Project20DataSet4";
            this.db14Project20DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db14Project20DataSet5
            // 
            this.db14Project20DataSet5.DataSetName = "Db14Project20DataSet5";
            this.db14Project20DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db14Project20DataSet6
            // 
            this.db14Project20DataSet6.DataSetName = "Db14Project20DataSet6";
            this.db14Project20DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sponsorsBindingSource
            // 
            this.sponsorsBindingSource.DataMember = "Sponsors";
            this.sponsorsBindingSource.DataSource = this.db14Project20DataSet6;
            // 
            // sponsorsTableAdapter
            // 
            this.sponsorsTableAdapter.ClearBeforeFill = true;
            // 
            // sponsorIdDataGridViewTextBoxColumn
            // 
            this.sponsorIdDataGridViewTextBoxColumn.DataPropertyName = "SponsorId";
            this.sponsorIdDataGridViewTextBoxColumn.HeaderText = "SponsorId";
            this.sponsorIdDataGridViewTextBoxColumn.Name = "sponsorIdDataGridViewTextBoxColumn";
            this.sponsorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sponsorNmaeDataGridViewTextBoxColumn
            // 
            this.sponsorNmaeDataGridViewTextBoxColumn.DataPropertyName = "SponsorNmae";
            this.sponsorNmaeDataGridViewTextBoxColumn.HeaderText = "SponsorNmae";
            this.sponsorNmaeDataGridViewTextBoxColumn.Name = "sponsorNmaeDataGridViewTextBoxColumn";
            // 
            // db14Project20DataSet7
            // 
            this.db14Project20DataSet7.DataSetName = "Db14Project20DataSet7";
            this.db14Project20DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamDetailsBindingSource1
            // 
            this.teamDetailsBindingSource1.DataMember = "TeamDetails";
            this.teamDetailsBindingSource1.DataSource = this.db14Project20DataSet7;
            // 
            // teamDetailsTableAdapter1
            // 
            this.teamDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // db14Project20DataSet8
            // 
            this.db14Project20DataSet8.DataSetName = "Db14Project20DataSet8";
            this.db14Project20DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamSponsorsBindingSource
            // 
            this.teamSponsorsBindingSource.DataMember = "TeamSponsors";
            this.teamSponsorsBindingSource.DataSource = this.db14Project20DataSet8;
            // 
            // teamSponsorsTableAdapter
            // 
            this.teamSponsorsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(396, 222);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(782, 12);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(393, 222);
            this.dataGridView4.TabIndex = 8;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(414, 139);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(348, 228);
            this.dataGridView5.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(186)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1187, 512);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSponsorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView3;
        private Db14Project20DataSet db14Project20DataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private Db14Project20DataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private Db14Project20DataSet1 db14Project20DataSet1;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private Db14Project20DataSet1TableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Db14Project20DataSet2 db14Project20DataSet2;
        private System.Windows.Forms.BindingSource teamsBindingSource1;
        private Db14Project20DataSet2TableAdapters.TeamsTableAdapter teamsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamCountryDataGridViewTextBoxColumn;
        private Db14Project20DataSet3 db14Project20DataSet3;
        private System.Windows.Forms.BindingSource teamDetailsBindingSource;
        private Db14Project20DataSet3TableAdapters.TeamDetailsTableAdapter teamDetailsTableAdapter;
        private Db14Project20DataSet4 db14Project20DataSet4;
        private Db14Project20DataSet5 db14Project20DataSet5;
        private Db14Project20DataSet6 db14Project20DataSet6;
        private System.Windows.Forms.BindingSource sponsorsBindingSource;
        private Db14Project20DataSet6TableAdapters.SponsorsTableAdapter sponsorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sponsorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sponsorNmaeDataGridViewTextBoxColumn;
        private Db14Project20DataSet7 db14Project20DataSet7;
        private System.Windows.Forms.BindingSource teamDetailsBindingSource1;
        private Db14Project20DataSet7TableAdapters.TeamDetailsTableAdapter teamDetailsTableAdapter1;
        private Db14Project20DataSet8 db14Project20DataSet8;
        private System.Windows.Forms.BindingSource teamSponsorsBindingSource;
        private Db14Project20DataSet8TableAdapters.TeamSponsorsTableAdapter teamSponsorsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
    }
}

