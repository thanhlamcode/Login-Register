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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel_QuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel_DKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        Modify modify = new Modify();

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string tentk = textBox_user.Text;
            string mk = textBox_password.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            }
            else if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '"+tentk+"' and MatKhau = '"+mk+"' and isAdmin = 0";
                string query1 = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + mk + "' and isAdmin = 1";
                if (modify.TaiKhoans(query).Count() != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cập nhật số lần đăng nhập trong bảng Manager
                    string updateQuery = $"UPDATE Manager SET soLanDangNhap = soLanDangNhap + 1 WHERE TenTaiKhoan = '{tentk}'";
                    modify.Command(updateQuery);
                    this.Hide();
                    PlayerUnity playerUnity = new PlayerUnity();
                    playerUnity.ShowDialog();
                }
                else if(modify.TaiKhoans(query1).Count() != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cập nhật số lần đăng nhập trong bảng Manager
                    string updateQuery = $"UPDATE Manager SET soLanDangNhap = soLanDangNhap + 1 WHERE TenTaiKhoan = '{tentk}'";
                    modify.Command(updateQuery);
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản và mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
