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
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien bul_nv = new BUS_NhanVien();
        private void NhanVien_Load(object sender, EventArgs e)
        {
            hienthi();
            LoadDatacboKH();
            groupBox1.Enabled = false;
            btnHuy.Enabled = false;
            btnGhi.Enabled = false;
            btnre.Enabled = false;
        }
        public void hienthi()
        {
            dataGridView1.DataSource = bul_nv.laydl();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

                row = dataGridView1.Rows[e.RowIndex];
                lblma.Text = row.Cells[0].Value.ToString().Trim();
                txtten.Text = row.Cells[1].Value.ToString().Trim();
                txtgt.Text = row.Cells[2].Value.ToString().Trim();
                datens.Text = row.Cells[3].Value.ToString().Trim();
                txtdc.Text = row.Cells[4].Value.ToString().Trim();
                txtdt.Text = row.Cells[5].Value.ToString().Trim();
                txtemail.Text = row.Cells[6].Value.ToString().Trim();
                txttk.Text = row.Cells[7].Value.ToString().Trim();
                //txtmk.Text = row.Cells[8].Value.ToString().Trim();
                comboBox2.Text = row.Cells[8].Value.ToString().Trim();

                dataGridView2.DataSource = bul_nv.timhdban(lblma.Text);
                dataGridView3.DataSource = bul_nv.timhdnhap(lblma.Text);
        }
        //Load Combobox
        private void LoadDatacboKH()
        {
            List<DTO_PhanQuyen> listChuDe = BUS_NhanVien.Loadquyen();
            comboBox2.DataSource = listChuDe;
            comboBox2.DisplayMember = "Tenquyen";
            comboBox2.ValueMember = "Maquyen";
        }
        int kt = 0;
        public void reset()
        {
            btnGhi.Enabled = true;
            btnXoa.Enabled = false;
            //btnThem.Enabled = false;
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
            txttk.Text = "";
            txtmk.Text = "";
            comboBox2.Text = "";
        }
        public void resethuy()
        {
            lblma.Visible = true;
            //btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnGhi.Enabled = false;
            btnXoa.Enabled = true;
            groupBox1.Enabled = false;
        }
        int rowindex = 0;
        DTO_NhanVien nv = new DTO_NhanVien();
        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                nv.Manv = lblma.Text;
                nv.Tennv = txtten.Text;
                nv.Gioitinh = txtgt.Text;
                nv.Diachi = txtdc.Text;
                nv.Dienthoai = txtdt.Text;
                nv.Email = txtemail.Text;
                nv.Taikhoan = txttk.Text;
                nv.Matkhau = txtmk.Text;
                nv.Maquyen = comboBox2.SelectedValue.ToString();
                if (datens.Text == "" || datens.Text == null)
                    nv.Ngaysinh = DateTime.Now.Date;
                else
                    nv.Ngaysinh = DateTime.Parse(datens.Text);

                if (bul_nv.themdl(nv) == true)
                {
                    // bus_lop.themdl(nxb);
                    MessageBox.Show("Đã thêm thành công");
                    hienthi();
                }
                else
                {

                    MessageBox.Show("Nhập thông tin không đầy đủ hoặc mã đã tồn tại", "Vui lòng kiểm tra lại");
                }
                resethuy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resethuy();
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = lblma.Text;
                if (bul_nv.xoadl(ma) == true)
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

        private void txtdt_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void txtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            hienthi();
            btnre.Enabled = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (bul_nv.timnv(txttim.Text) != null)
            {
                dataGridView1.DataSource = bul_nv.timnv(txttim.Text);

            }
            else MessageBox.Show("Không tìm thấy nhân viên");
            btnre.Enabled = true;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //DataGridViewRow dr = dataGridView1.SelectedRows[0];
            //lblma.Text = dr.Cells["ma_nv"].Value.ToString();
            //txtten.Text = dr.Cells["ten_nv"].Value.ToString();
            //txtgt.Text = dr.Cells["gioi_tinh"].Value.ToString();
            //datens.Text = dr.Cells["ngay_sinh"].Value.ToString();
            //txtdc.Text = dr.Cells["dia_chi"].Value.ToString();
            //txtdt.Text = dr.Cells["dien_thoai"].Value.ToString();
            //txtemail.Text = dr.Cells["email"].Value.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            kt = 1;
            clear();
            reset();
            //lblma.Visible = false;
            lblma.Text = BUS_NhanVien.SinhMaNV();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rowindex >= 0)
                rowindex = e.RowIndex;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int dem = 1;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dem == 1)
            {
                txtmk.UseSystemPasswordChar = false;
                dem = 0;
            }
            else
            {
                dem = 1;
                txtmk.UseSystemPasswordChar = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
