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
    public partial class NhanHieu : UserControl
    {
        public NhanHieu()
        {
            InitializeComponent();
        }

        private void NhanHieu_Load(object sender, EventArgs e)
        {
            LoadThontin();
            txtten.Enabled = false;
            btnThem.Enabled = true;
            btnGhi.Enabled = false;
            btnCapnhat.Enabled = true;
            button1.Enabled = false;
        }
        void LoadThontin()
        {
            List<DTO_NhanHieu> listnh = BUS_NhanHieu.Loadnh();
            dataGridView1.DataSource = listnh;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnCapnhat.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            button1.Enabled = true;
            txtten.Enabled = true;
            btnGhi.Text = "GHI";
            txtten.Clear();
            txtten.Focus();
            txtma.Text = BUS_NhanHieu.SinhMaNH();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (btnGhi.Text == "GHI")
            {
                try
                {
                    if (txtten.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đử dữ liệu!", "Thông báo");
                        return;
                    }
                    DTO_NhanHieu nhanhieu = new DTO_NhanHieu();
                    nhanhieu.Manhanhieu = txtma.Text;
                    nhanhieu.Tennhanhieu = txtten.Text;
                    if (BUS_NhanHieu.Them(nhanhieu) == true)
                    {
                        btnCapnhat.Enabled = true;
                        btnXoa.Enabled = true;
                        btnThem.Enabled = true;
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LoadThontin();
                        txtten.Enabled = false;
                        btnThem.Enabled = true;
                        btnGhi.Enabled = false;
                        btnCapnhat.Enabled = true;
                        button1.Enabled = false;
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                }
            }
            else if (btnGhi.Text == "LƯU")
            {
                try
                {
                    if (txtma.Text == "")
                    {
                        MessageBox.Show("Bạn cần chọn nhãn hiệu cần sửa!", "Thông báo");
                        return;
                    }
                    DTO_NhanHieu tacgia = new DTO_NhanHieu();
                    tacgia.Tennhanhieu = txtten.Text;
                    tacgia.Manhanhieu = txtma.Text;
                    if (BUS_NhanHieu.Sua(tacgia) == true)
                    {
                        MessageBox.Show("Cập nhập thành công!", "Thông báo");
                        LoadThontin();
                        txtten.Enabled = false;
                        btnThem.Enabled = true;
                        btnGhi.Enabled = false;
                        btnCapnhat.Enabled = true;
                        button1.Enabled = false;
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhập thất bại!", "Thông báo");
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            btnGhi.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnCapnhat.Enabled = false;
            txtten.Enabled = true;
            btnGhi.Text = "LƯU";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Bạn cần chọn nhãn hiệu cần xóa!", "Thông báo");
            }
            DTO_NhanHieu tacgia = new DTO_NhanHieu();
            tacgia.Manhanhieu = txtma.Text;
            if (BUS_NhanHieu.Xoa(tacgia) == true)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadThontin();
                return;
            }
            MessageBox.Show("Xóa thất bại!", "Thông báo");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtma.Text = dr.Cells[0].Value.ToString();
            txtten.Text = dr.Cells[1].Value.ToString();
        }
        string ma;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtma.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            this.txtten.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            // ma dùng để lưu giá trị Mnxb khi nhấn chọn 1 dòng trên gridview
            //việc lưu lại này giúp cho việc sửa và xóa dl d9uoc5 chính xác hơn
            ma = dataGridView1.Rows[dong].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnGhi.Text == "GHI")
            {
                txtten.Enabled = false;
                btnThem.Enabled = true;
                btnGhi.Enabled = false;
                btnCapnhat.Enabled = true;
                button1.Enabled = false;
                btnXoa.Enabled = true;
            }
            else if (btnGhi.Text == "LƯU")
            {
                txtten.Enabled = false;
                btnThem.Enabled = true;
                btnGhi.Enabled = false;
                btnCapnhat.Enabled = true;
                button1.Enabled = false;
                btnXoa.Enabled = true;
            }
        }
    }
}
