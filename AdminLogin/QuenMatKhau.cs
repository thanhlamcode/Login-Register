using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLogin
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label_Ketqua.Text = "";
        }

        private void button_LaylaiMK_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string email = textBox_EmailDK.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Mời bạn điền email để khôi phục mật khẩu");
            }
            else
            {
                string query = $"Select * from TaiKhoan Where Email = '{email}'";
                if(modify.TaiKhoans(query).Count() > 0)
                {
                    label_Ketqua.ForeColor = Color.Green;
                    label_Ketqua.Text = "Mật khẩu là: " + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label_Ketqua.ForeColor= Color.Red;
                    label_Ketqua.Text = "Email không tồn tại!!";
                }
            }
        }
    }
}
