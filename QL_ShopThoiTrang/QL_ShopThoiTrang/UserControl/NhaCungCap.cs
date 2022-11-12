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
    public partial class NhaCungCap : UserControl
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnCapnhat.Enabled = false;
            btnXoa.Text = "HỦY";
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnGhi.Enabled = true;
            txtten.Clear();
            txtdc.Clear();
            txtdt.Clear();
            txtemail.Clear();
            txtten.Enabled = true;
            txtdc.Enabled = true;
            txtdt.Enabled = true;
            txtemail.Enabled = true;
            txtten.Focus();
            txtma.Text = BUS_NhaCungCap.SinhMaNCC();
        }
        void LoadThontin()
        {
            List<DTO_NhaCungCap> listnh = BUS_NhaCungCap.LoadNCC();
            dataGridView1.DataSource = listnh;
        }
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            reset();
            LoadThontin();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Bạn cần chọn nhà cung cấp cần sửa!", "Thông báo");
                return;
            }
            btnCapnhat.Enabled = false;
            btnXoa.Text = "HỦY";
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnGhi.Text = "LƯU";
            btnGhi.Enabled = true;
            txtten.Enabled = true;
            txtdc.Enabled = true;
            txtdt.Enabled = true;
            txtemail.Enabled = true;
            txtten.Focus();
        }
        private void reset()
        {
            btnCapnhat.Enabled = true;
            btnXoa.Text = "XÓA";
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnGhi.Enabled = false;
            txtten.Enabled = false;
            txtdc.Enabled = false;
            txtdt.Enabled = false;
            txtemail.Enabled = false;
            txtten.Clear();
            txtdc.Clear();
            txtdt.Clear();
            txtma.Clear();
            txtemail.Clear();
            txtten.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnXoa.Text == "HỦY")
                {
                    reset();
                }
                else if (btnXoa.Text == "XÓA")
                {
                    if (txtma.Text == "")
                    {
                        MessageBox.Show("Bạn cần chọn nhà cung cấp cần xóa!", "Thông báo");
                        return;
                    }
                    DTO_NhaCungCap cungcap = new DTO_NhaCungCap();
                    cungcap.Mancc = txtma.Text;
                    if (BUS_NhaCungCap.Xoa(cungcap) == true)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                        LoadThontin();
                        return;
                    }
                    MessageBox.Show("Xóa thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
            
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGhi.Text == "LƯU")
                {
                    DTO_NhaCungCap cungcap = new DTO_NhaCungCap();
                    cungcap.Mancc = txtma.Text;
                    cungcap.Tenncc = txtten.Text;
                    cungcap.Diachi = txtdc.Text;
                    cungcap.Dienthoai = txtdt.Text;
                    cungcap.Email = txtemail.Text;
                    cungcap.Mancc = txtma.Text;

                    if (BUS_NhaCungCap.Sua(cungcap) == true)
                    {
                        MessageBox.Show("Cập nhập thành công!", "Thông báo");
                        LoadThontin();
                        return;
                    }
                    MessageBox.Show("Cập nhập thất bại!", "Thông báo");
                }
                else if (btnGhi.Text == "GHI")
                {
                    if (txtten.Text == "" || txtdc.Text == "" || txtdt.Text == "" || txtemail.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đử dữ liệu!", "Thông báo");
                        return;
                    }
                    DTO_NhaCungCap cungcap = new DTO_NhaCungCap();
                    cungcap.Mancc = txtma.Text;
                    cungcap.Tenncc = txtten.Text;
                    cungcap.Diachi = txtdc.Text;
                    cungcap.Dienthoai = txtdt.Text;
                    cungcap.Email = txtemail.Text;

                    if (BUS_NhaCungCap.Them(cungcap) == true)
                    {
                        btnThem.Enabled = true;
                        btnCapnhat.Enabled = true;
                        btnXoa.Enabled = true;
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LoadThontin();
                        reset();
                        return;
                    }
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
           
        }

        private void txtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        string ma;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtma.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            this.txtten.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            this.txtdc.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            this.txtdt.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
            this.txtemail.Text = dataGridView1.Rows[dong].Cells[4].Value.ToString();
            // ma dùng để lưu giá trị Mnxb khi nhấn chọn 1 dòng trên gridview
            //việc lưu lại này giúp cho việc sửa và xóa dl d9uoc5 chính xác hơn
            ma = dataGridView1.Rows[dong].Cells[0].Value.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtma.Text = dr.Cells["Macc"].Value.ToString();
            txtten.Text = dr.Cells["Tencc"].Value.ToString();
            txtdc.Text = dr.Cells["Diachi"].Value.ToString();
            txtdt.Text = dr.Cells["Dienthoai"].Value.ToString();
            txtemail.Text = dr.Cells["Email"].Value.ToString();
        }
    }
}
