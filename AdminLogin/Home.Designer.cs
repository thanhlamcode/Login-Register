namespace AdminLogin
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_excel = new System.Windows.Forms.Button();
            this.button_PDF = new System.Windows.Forms.Button();
            this.comboBox_luachon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Sapxep = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.managerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new AdminLogin.Database1DataSet1();
            this.database1DataSet = new AdminLogin.Database1DataSet();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableAdapter = new AdminLogin.Database1DataSetTableAdapters.ManagerTableAdapter();
            this.managerTableAdapter1 = new AdminLogin.Database1DataSet1TableAdapters.ManagerTableAdapter();
            this.database1DataSet2 = new AdminLogin.Database1DataSet2();
            this.managerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableAdapter2 = new AdminLogin.Database1DataSet2TableAdapters.ManagerTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLanDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongBossTieuDiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCaoNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_Exit);
            this.groupBox1.Controls.Add(this.button_excel);
            this.groupBox1.Controls.Add(this.button_PDF);
            this.groupBox1.Controls.Add(this.comboBox_luachon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_Sapxep);
            this.groupBox1.Controls.Add(this.label_Total);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1682, 1198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người chơi";
            // 
            // button_excel
            // 
            this.button_excel.Location = new System.Drawing.Point(1233, 937);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(288, 154);
            this.button_excel.TabIndex = 7;
            this.button_excel.Text = "PDF";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // button_PDF
            // 
            this.button_PDF.Location = new System.Drawing.Point(882, 937);
            this.button_PDF.Name = "button_PDF";
            this.button_PDF.Size = new System.Drawing.Size(288, 154);
            this.button_PDF.TabIndex = 6;
            this.button_PDF.Text = "Excel";
            this.button_PDF.UseVisualStyleBackColor = true;
            this.button_PDF.Click += new System.EventHandler(this.button_PDF_Click);
            // 
            // comboBox_luachon
            // 
            this.comboBox_luachon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_luachon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_luachon.FormattingEnabled = true;
            this.comboBox_luachon.Items.AddRange(new object[] {
            "Thời Gian Chơi",
            "Số Lần Đăng Nhập",
            "Lượng Boss Tiêu Diệt",
            "Level",
            "Điểm Cao Nhất"});
            this.comboBox_luachon.Location = new System.Drawing.Point(418, 966);
            this.comboBox_luachon.Name = "comboBox_luachon";
            this.comboBox_luachon.Size = new System.Drawing.Size(338, 45);
            this.comboBox_luachon.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 960);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiêu chí sắp xếp";
            // 
            // button_Sapxep
            // 
            this.button_Sapxep.AutoSize = true;
            this.button_Sapxep.BackColor = System.Drawing.Color.Blue;
            this.button_Sapxep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Sapxep.Location = new System.Drawing.Point(242, 1054);
            this.button_Sapxep.Name = "button_Sapxep";
            this.button_Sapxep.Size = new System.Drawing.Size(281, 142);
            this.button_Sapxep.TabIndex = 3;
            this.button_Sapxep.Text = "Sắp xếp";
            this.button_Sapxep.UseVisualStyleBackColor = false;
            this.button_Sapxep.Click += new System.EventHandler(this.button_Sapxep_Click);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(444, 884);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(318, 37);
            this.label_Total.TabIndex = 2;
            this.label_Total.Text = "Tổng số người chơi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 872);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng số người chơi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TenTaiKhoan,
            this.timeplay,
            this.soLanDangNhap,
            this.luongBossTieuDiet,
            this.diemCaoNhat,
            this.level});
            this.dataGridView1.DataSource = this.managerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1658, 782);
            this.dataGridView1.TabIndex = 0;
            // 
            // managerBindingSource1
            // 
            this.managerBindingSource1.DataMember = "Manager";
            this.managerBindingSource1.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "Manager";
            this.managerBindingSource.DataSource = this.database1DataSet;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // managerTableAdapter1
            // 
            this.managerTableAdapter1.ClearBeforeFill = true;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource2
            // 
            this.managerBindingSource2.DataMember = "Manager";
            this.managerBindingSource2.DataSource = this.database1DataSet2;
            // 
            // managerTableAdapter2
            // 
            this.managerTableAdapter2.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 200;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "Username";
            this.TenTaiKhoan.MinimumWidth = 10;
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.Width = 200;
            // 
            // timeplay
            // 
            this.timeplay.DataPropertyName = "timeplay";
            this.timeplay.HeaderText = "TimePlay";
            this.timeplay.MinimumWidth = 10;
            this.timeplay.Name = "timeplay";
            this.timeplay.Width = 200;
            // 
            // soLanDangNhap
            // 
            this.soLanDangNhap.DataPropertyName = "soLanDangNhap";
            this.soLanDangNhap.HeaderText = "Number of Login";
            this.soLanDangNhap.MinimumWidth = 10;
            this.soLanDangNhap.Name = "soLanDangNhap";
            this.soLanDangNhap.Width = 200;
            // 
            // luongBossTieuDiet
            // 
            this.luongBossTieuDiet.DataPropertyName = "luongBossTieuDiet";
            this.luongBossTieuDiet.HeaderText = "Boss";
            this.luongBossTieuDiet.MinimumWidth = 10;
            this.luongBossTieuDiet.Name = "luongBossTieuDiet";
            this.luongBossTieuDiet.Width = 200;
            // 
            // diemCaoNhat
            // 
            this.diemCaoNhat.DataPropertyName = "diemCaoNhat";
            this.diemCaoNhat.HeaderText = "Max Score";
            this.diemCaoNhat.MinimumWidth = 10;
            this.diemCaoNhat.Name = "diemCaoNhat";
            this.diemCaoNhat.Width = 200;
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            this.level.HeaderText = "Level";
            this.level.MinimumWidth = 10;
            this.level.Name = "level";
            this.level.Width = 200;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(1094, 1123);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(288, 154);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1682, 1198);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Total;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private Database1DataSetTableAdapters.ManagerTableAdapter managerTableAdapter;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource managerBindingSource1;
        private Database1DataSet1TableAdapters.ManagerTableAdapter managerTableAdapter1;
        private System.Windows.Forms.Button button_Sapxep;
        private System.Windows.Forms.ComboBox comboBox_luachon;
        private System.Windows.Forms.Label label2;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource managerBindingSource2;
        private Database1DataSet2TableAdapters.ManagerTableAdapter managerTableAdapter2;
        private System.Windows.Forms.Button button_PDF;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLanDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongBossTieuDiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemCaoNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.Button button_Exit;
    }
}