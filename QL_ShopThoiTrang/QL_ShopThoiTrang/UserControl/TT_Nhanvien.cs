using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QL_ShopThoiTrang
{
    public partial class TT_Nhanvien : UserControl
    {
        public TT_Nhanvien()
        {
            InitializeComponent();
        }
        BUS_NhanVien xl = new BUS_NhanVien();
        public void hien()
        {

            string s = "";
            BUS_NhanVien xl = new BUS_NhanVien();
            s = BUS_NhanVien.LayThongTinDangNhap();
            DataTable dt = xl.thongtinnv(s);

            lblma.Text = dt.Rows[0]["ma_nv"].ToString();
            txtten.Text = dt.Rows[0]["ten_nv"].ToString();
            txtgt.Text = dt.Rows[0]["gioi_tinh"].ToString();
            datens.Text = dt.Rows[0]["ngay_sinh"].ToString();
            txtdc.Text = dt.Rows[0]["dia_chi"].ToString();
            txtdt.Text = dt.Rows[0]["dien_thoai"].ToString();
            txtemail.Text = dt.Rows[0]["email"].ToString();
            groupBox1.Enabled = false;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }
        public void sua()
        {
            lblma.Enabled = false;
            //btnThem.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            groupBox1.Enabled = true;
            btnSua.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            sua();
        }

        private void TT_Nhanvien_Load(object sender, EventArgs e)
        {
            hien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            hien();
        }

        DTO_NhanVien nv = new DTO_NhanVien();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string s = "";
            s = BUS_NhanVien.LayThongTinDangNhap();
            nv.Tennv = txtten.Text;
            nv.Gioitinh = txtgt.Text;
            nv.Diachi = txtdc.Text;
            nv.Dienthoai = txtdt.Text;
            nv.Email = txtemail.Text;
            nv.Taikhoan = s;
            if (datens.Text == "" || datens.Text == null)
                nv.Ngaysinh = DateTime.Now.Date;
            else
                nv.Ngaysinh = DateTime.Parse(datens.Text);

            if (xl.suadl(nv) == true)
            {
                // bus_lop.themdl(nxb);
                MessageBox.Show("Đã sửa thành công");
                hien();
            }
            else
            {

                MessageBox.Show("Lỗi", "Vui lòng kiểm tra lại");
            }
        }
    }
}
