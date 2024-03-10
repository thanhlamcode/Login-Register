namespace AdminLogin
{
    partial class QuenMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_LaylaiMK = new System.Windows.Forms.Button();
            this.textBox_EmailDK = new System.Windows.Forms.TextBox();
            this.label_Ketqua = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(40, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Email đăng ký:";
            // 
            // button_LaylaiMK
            // 
            this.button_LaylaiMK.AutoSize = true;
            this.button_LaylaiMK.BackColor = System.Drawing.Color.Blue;
            this.button_LaylaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LaylaiMK.ForeColor = System.Drawing.Color.White;
            this.button_LaylaiMK.Location = new System.Drawing.Point(220, 575);
            this.button_LaylaiMK.Name = "button_LaylaiMK";
            this.button_LaylaiMK.Size = new System.Drawing.Size(355, 67);
            this.button_LaylaiMK.TabIndex = 25;
            this.button_LaylaiMK.Text = "Lấy lại mật khẩu";
            this.button_LaylaiMK.UseVisualStyleBackColor = false;
            this.button_LaylaiMK.Click += new System.EventHandler(this.button_LaylaiMK_Click);
            // 
            // textBox_EmailDK
            // 
            this.textBox_EmailDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EmailDK.Location = new System.Drawing.Point(344, 359);
            this.textBox_EmailDK.Name = "textBox_EmailDK";
            this.textBox_EmailDK.Size = new System.Drawing.Size(405, 53);
            this.textBox_EmailDK.TabIndex = 24;
            // 
            // label_Ketqua
            // 
            this.label_Ketqua.AutoSize = true;
            this.label_Ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ketqua.ForeColor = System.Drawing.Color.Blue;
            this.label_Ketqua.Location = new System.Drawing.Point(40, 488);
            this.label_Ketqua.Name = "label_Ketqua";
            this.label_Ketqua.Size = new System.Drawing.Size(144, 37);
            this.label_Ketqua.TabIndex = 27;
            this.label_Ketqua.Text = "Kết quả:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminLogin.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(220, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 698);
            this.Controls.Add(this.label_Ketqua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_LaylaiMK);
            this.Controls.Add(this.textBox_EmailDK);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_LaylaiMK;
        private System.Windows.Forms.TextBox textBox_EmailDK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Ketqua;
    }
}