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
    public partial class KhachHang : UserControl
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        BUS_KhachHang bul_kh = new BUS_KhachHang();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            hienthi();
            groupBox1.Enabled = false;
            btnHuy.Enabled = false;
            btnGhi.Enabled = false;
            btnre.Enabled = false;
        }
        public void hienthi()
        {
            dataGridView1.DataSource = bul_kh.laydl();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            lblma.Text = dr.Cells["ma_kh"].Value.ToString();
            txtten.Text = dr.Cells["ten_kh"].Value.ToString();
            txtgt.Text = dr.Cells["gioi_tinh"].Value.ToString();
            datens.Text = dr.Cells["ngay_sinh"].Value.ToString();
            txtdc.Text = dr.Cells["dia_chi"].Value.ToString();
            txtdt.Text = dr.Cells["dien_thoai"].Value.ToString();
            txtemail.Text = dr.Cells["email"].Value.ToString();

          
        }
        int kt = 0;
        public void reset()
        {
            btnGhi.Enabled = true;
            btnXoa.Enabled = false;
            //btnThem.Enabled = false;
            btnCapnhat.Enabled = false;
            groupBox1.Enabled = true;
            btnHuy.Enabled = true;
        }
        public void clear()
        {
            txtdc.Text = "";
            txtten.Text = "";
            lblma.Text = "";
            txtdt.Text = "";
            txtemail.Text = "";
            txtgt.Text = "";
            datens.Text = "";
        }
        public void resethuy()
        {
            lblma.Visible = true;
            //btnThem.Enabled = true;
            btnCapnhat.Enabled = true;
            btnHuy.Enabled = false;
            btnGhi.Enabled = false;
            btnXoa.Enabled = true;
            groupBox1.Enabled = false;
        }
        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    kt = 1;
        //    clear();
        //    reset();
        //    //lblID.Visible = false;
        //    lblma.Text = BUL_KhachHang.SinhMaKH();
        //}

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resethuy();
            clear();
        }
        DTO_KhachHang kh = new DTO_KhachHang();
        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                kh.Makh = lblma.Text;
                kh.Tenkh = txtten.Text;
                kh.Gioitinh = txtgt.Text;
                kh.Diachi = txtdc.Text;
                kh.Dienthoai = txtdt.Text;
                kh.Email = txtemail.Text;
                if (datens.Text == "" || datens.Text == null)
                    kh.Ngaysinh = DateTime.Now.Date;
                else
                    kh.Ngaysinh = DateTime.Parse(datens.Text);
                if (kt == 2)
                //{
                //    if (bul_kh.themdl(kh) == true)
                //    {
                //        // bus_lop.themdl(nxb);
                //        MessageBox.Show("Đã thêm thành công");
                //        hienthi();
                //    }
                //    else
                //    {

                //        MessageBox.Show("Nhập thông tin không đầy đủ hoặc mã đã tồn tại", "Vui lòng kiểm tra lại");
                //    }

                //}

                //else
                {

                    if (bul_kh.suadl(kh) == true)
                    {
                        // bus_lop.themdl(nxb);
                        MessageBox.Show("Đã sửa thành công");
                        hienthi();
                    }
                    else
                    {

                        MessageBox.Show("Nhập thông tin không đầy đủ");
                    }
                }
                resethuy();
                //clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
           
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            kt = 2;
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = lblma.Text;
                if (bul_kh.xoadl(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    hienthi();
                    clear();
                }
                else MessageBox.Show("bạn chưa chọn dữ liệu để xóa hoặc dữ liệu không được phép xóa");
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (bul_kh.timhd(txttim.Text) != null && bul_kh.timkh(txttim.Text) != null)
            {
                dataGridView2.DataSource = bul_kh.timhd(txttim.Text);
                dataGridView1.DataSource = bul_kh.timkh(txttim.Text);
            }
            else MessageBox.Show("Không tìm thấy khách hàng");
            btnre.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            hienthi();
            btnre.Enabled = false;
        }

        private void txtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
