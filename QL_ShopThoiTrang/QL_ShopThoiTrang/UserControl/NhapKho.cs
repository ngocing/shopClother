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
    public partial class NhapKho : UserControl
    {
        public NhapKho()
        {
            InitializeComponent();
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            List<DTO_SanPham> tbl1 = BUS_SanPham.LayDatatable();
            gridControl2.DataSource = tbl1;
            LoadDatacboNCC();
            hienthinv();
        }
        string manv = "";
        void hienthinv()
        {
            string s = "";
            BUS_NhanVien xl = new BUS_NhanVien();
            s = BUS_NhanVien.LayThongTinDangNhap();
            DataTable login = xl.Getlogin(s);

            for (int i = 0; i < login.Rows.Count; i++)
            {
                txtnv.Text = login.Rows[i]["ten_nv"].ToString().Trim();
                manv = login.Rows[i]["ma_nv"].ToString().Trim();
            }
        }
        //Load Combobox
        private void LoadDatacboNCC()
        {
            List<DTO_NhaCungCap> listChuDe = BUS_NhaCungCap.LoadNCC();
            comboBox1.DataSource = listChuDe;
            comboBox1.DisplayMember = "Tenncc";
            comboBox1.ValueMember = "Mancc";
        }
       
        //Tìm kiếm
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                string Masp = "";
                Masp = textEdit5.Text;
                List<DTO_SanPham> tbl4 = BUS_SanPham.LayDatatableTheoMaSP(Masp);
                gridControl2.DataSource = tbl4;
                if (gridView2.RowCount == 0)
                    MessageBox.Show("Không tìm thấy mã sản phẩm trên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy mã sản phẩm trên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit5.Text == "" || textEdit5.Text == null)
            {
                List<DTO_SanPham> tbl1 = BUS_SanPham.LayDatatable();
                gridControl2.DataSource = tbl1;
            }
        }
        int soluong = 0;
        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
            textBox1.Text = BUS_PhieuNhap.SinhMaPN();
            string MaSP = gridView2.GetRowCellValue(e.RowHandle, "Masp").ToString();
            string TenSP = gridView2.GetRowCellValue(e.RowHandle, "Tensp").ToString();
            string DonGia = String.Format("{0:0,0.0}", gridView2.GetRowCellValue(e.RowHandle, "Dongia")) + "    VND";
            string tien = gridView2.GetRowCellValue(e.RowHandle, "Dongia").ToString();
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvHoaDon);
            row.Cells[0].Value = MaSP;
            row.Cells[1].Value = TenSP;
            row.Cells[2].Value = DonGia;
            row.Cells[4].Value = tien;
            int kiemtra = BUS_HoaDon.kiemtratontai(MaSP, dgvHoaDon);
            if (kiemtra == -1)
            {
                soluong = 1;
                row.Cells[3].Value = soluong;
                dgvHoaDon.Rows.Add(row);
            }
            else
            {
                row = dgvHoaDon.Rows[kiemtra];
                if (MessageBox.Show("Sản phẩm trên đã có trong danh sách \n Có muốn thêm nữa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    soluong++;
                    row.Cells[3].Value = soluong;
                }
            }
            labelControl6.Text = String.Format("{0:0,0.0}", BUS_PhieuNhap.tinhthanhtien(dgvHoaDon)) + " VND";
        }
        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvHoaDon.SelectedRows[0];
                numericUpDown1.Value = int.Parse(dr.Cells[3].Value.ToString());
                txtDonGia.Text = dr.Cells[4].Value.ToString();
            }
            catch(Exception)
            {
            }
        }
        // Cập nhập số lượng
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtDonGia == null)
            {
                DataGridViewRow dr = dgvHoaDon.SelectedRows[0];
                if (MessageBox.Show("Bạn muốn cập nhập số lượng của " + dr.Cells[1].Value, "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    dr.Cells[3].Value = numericUpDown1.Value.ToString();
                    dgvHoaDon.Refresh();
                }
            }
            else
            {
                DataGridViewRow dr = dgvHoaDon.SelectedRows[0];
                if (MessageBox.Show("Bạn muốn cập nhập số lượng và đơn giá của " + dr.Cells[1].Value, "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    dr.Cells[3].Value = numericUpDown1.Value.ToString();
                    dr.Cells[4].Value = txtDonGia.Text;
                    dr.Cells[2].Value = String.Format("{0:0,0.0}", double.Parse(txtDonGia.Text)) + "    VND";
                    dgvHoaDon.Refresh();
                }
            }
        }
        private void dgvHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            labelControl6.Text = String.Format("{0:0,0.0}", BUS_PhieuNhap.tinhthanhtien(dgvHoaDon)) + " VND";
        }
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rowindex >= 0)
                rowindex = e.RowIndex;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDon.Rows.Count > 0)
                {
                    BUS_PhieuNhap.LuuHD(textBox1.Text, comboBox1.SelectedValue.ToString(), manv, DateTime.Parse(dateTimePicker1.Value.ToString()), decimal.Parse(BUS_PhieuNhap.tinhthanhtien(dgvHoaDon).ToString()));
                    BUS_PhieuNhap.LuuCTHD(dgvHoaDon, textBox1.Text);
                    BUS_PhieuNhap.LuuSP(dgvHoaDon);
                    MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Bạn có muốn in phiếu nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        InPhieuNhap bill = new InPhieuNhap();
                        bill.Show();
                    }
                    reset();
                }
                else
                    MessageBox.Show("Không có sản phẩm nhập kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reset()
        {
            textBox1.Text = "";
            numericUpDown1.Value = 0;
            labelControl6.Text = "Thành Tiền";
            dgvHoaDon.Rows.Clear();
        }
        int rowindex = 0;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {             
                    if (MessageBox.Show("Bạn chắc xóa  không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        dgvHoaDon.Rows.RemoveAt(rowindex);
                        labelControl6.Text = String.Format("{0:0,0.0}", BUS_PhieuNhap.tinhthanhtien(dgvHoaDon)) + " VND";
                        dgvHoaDon.Refresh();
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy chọn sản phẩm cần xóa", "Thông báo");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            HienThi sp = new HienThi("them");
            sp.Show();
            
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
       
    }
}
