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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (BUS_NhanVien.KiemTraDangNhap(txtUsername.Text.Trim(), txtPassword.Text.Trim()) == true)
            {
               // MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                BUS_NhanVien.LuuThongTinDangNhap(txtUsername.Text.Trim());
                DialogResult = DialogResult.OK;
                QL_Shop main = new QL_Shop();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Đăng nhập thất bại!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}