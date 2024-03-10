using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace AdminLogin
{
    public partial class DangKy : Form
    {
        Modify modify = new Modify();
        public DangKy()
        {
            InitializeComponent();
        }

        public bool CheckAccount(string account)
        {
            return Regex.IsMatch(account, @"^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTK.Text;
            string mk = textBox_MatKhau.Text;
            string email = textBox_email.Text;
            string xnmk = textBox_XNMatKhau.Text;

            if (!CheckAccount(tentk))
            {
                MessageBox.Show("Vui lòng đặt tên tài khoản đúng định dạng từ 6-24 kí tự, các kí tự bao gồm [0-9], [a-z], [A-Z]");
                return;
            }

            if (mk.Length < 6 || mk.Length > 24 || !Regex.IsMatch(mk, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Vui lòng điền mật khẩu từ 6-24 kí tự, các kí tự bao gồm [0-9], [a-z], [A-Z]");
                return;
            }

            if (xnmk != mk)
            {
                MessageBox.Show("Xác nhận mật khẩu chưa trùng khớp!");
                return;
            }

            if (!CheckEmail(email))
            {
                MessageBox.Show("Email không đúng định dạng");
                return;
            }

            if (modify.TaiKhoans($"Select * from TaiKhoan Where Email ='{email}'").Count > 0)
            {
                MessageBox.Show("Email đã tồn tại");
                return;
            }

            try
            {
                string query = $"Insert into TaiKhoan values ('{tentk}','{mk}','{email}',0)";
                modify.Command(query);

                //them vao bang manager
                string queryManager = $"INSERT INTO Manager ([TenTaiKhoan], [timeplay], [soLanDangNhap], [luongBossTieuDiet], [level], [diemCaoNhat]) " +
                          $"VALUES ('{tentk}', 0, 0, 0, 0, 0)";
                modify.Command(queryManager); // Thêm tài khoản mới vào bảng Manager với các thông số còn lại bằng 0

                if (MessageBox.Show("Đăng ký tài khoản thành công! Bạn có muốn đăng nhập không?","Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Hide();
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.ShowDialog();
                }
            }
            catch
            {
           //     MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                MessageBox.Show("Tên tài khoản này đã được đăng ký!\nVui lòng đăng ký tên tài khoản khác!");
            }
        }

    }
}
