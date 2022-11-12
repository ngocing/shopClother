using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace QL_ShopThoiTrang
{
    public partial class ChangePass : DevExpress.XtraEditors.XtraForm
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void buttom_confirm_Click(object sender, EventArgs e)
        {
             if ((account.Text == "") || (pass.Text == "") || (newpass.Text == "") || (confirmpass.Text == ""))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            }
            else if (BUS_NhanVien.KiemTraDangNhap(account.Text.Trim(), pass.Text.Trim()) != true)
            {
                MessageBox.Show("Tên đăng nhập cũ hoặc mật khẩu cũ không đúng không đúng", "Thông báo");
                account.Text = "";
                account.Focus();
                pass.Text = "";
                pass.Focus();
            }
             else if (newpass.Text != confirmpass.Text)
             {
                 MessageBox.Show("Nhập lại mật khẩu không chính xác", "Thông báo");
                 confirmpass.Text = "";
                 confirmpass.Focus();
             }
             else
             {
                 BUS_NhanVien.DoiMatKhau(account.Text.Trim(), newpass.Text.Trim());
                 MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                 this.Hide();
             }
        }

        private void buttom_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void newpass_TextChanged(object sender, EventArgs e)
        {
            if (pass.Text == newpass.Text)
            {
                pictureBox1.Visible = true;
                label1.Visible = true;
                label1.Text = "Mật khẩu mới không được trùng với mật khẩu cũ";
            }
            else
            {
                pictureBox1.Visible = false;
                label1.Visible = false;
            }
        }

        private void confirmpass_TextChanged(object sender, EventArgs e)
        {
            if (confirmpass.Text != newpass.Text)
            {
                pictureBox1.Visible = true;
                label1.Visible = true;
                label1.Text = "Xác nhận sai mật khẩu";
            }
            else
            {
                pictureBox1.Visible = false;
                label1.Visible = false;
            }
        }
    }
}