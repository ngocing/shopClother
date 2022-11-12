using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QL_ShopThoiTrang
{
    public partial class BanHang : UserControl
    {
        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            BUS_HoaDon.loadtreeview(treeView1);
            BUS_HoaDon.loadlistview(listView1);
            hienthinv();
            lblKhuyenMai.Visible = false;
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

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string Macha = "";
            string Maloai = "";
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Level == 0)
                {
                    List<DTO_SanPham> tbl1 = BUS_SanPham.LayDatatable();
                    gridControl2.DataSource = tbl1;
                }
                if (treeView1.SelectedNode.Level == 1)
                {
                    Macha = treeView1.SelectedNode.Name.Trim().ToString();
                    List<DTO_SanPham> tbl2 = BUS_SanPham.LayDatatableTheoMaCha(Macha);
                    gridControl2.DataSource = tbl2;

                }
                if (treeView1.SelectedNode.Level == 2)
                {
                    Maloai = treeView1.SelectedNode.Name.Trim().ToString();
                    List<DTO_SanPham> tbl3 = BUS_SanPham.LayDatatableTheoMaLoai(Maloai);
                    gridControl2.DataSource = tbl3;
                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Mahieu = "";
            if (listView1.SelectedItems.Count > 0)
            {
                Mahieu = listView1.SelectedItems[0].Name.ToString();
                List<DTO_SanPham> tbl3 = BUS_SanPham.LayDatatableTheoMaHieu(Mahieu);
                gridControl2.DataSource = tbl3;
            }
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
        // tìm kiếm
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
        // xóa sản phẩm
        int rowindex = 0;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc xóa  không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    dgvHoaDon.Rows.RemoveAt(rowindex);                       
                    
                    dgvHoaDon.Refresh();
                    if (checkEdit1.Checked == true)
                    {
                        lblKhuyenMai.Visible = true;
                        labelControl6.Text = String.Format("{0:0,0.0}", (BUS_HoaDon.tinhthanhtien(dgvHoaDon)) - 0.1 * BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
                        lblKhuyenMai.Text = String.Format("{0:0,0.0}", BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
                    }
                    else
                        labelControl6.Text = String.Format("{0:0,0.0}", BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy chọn sản phẩm cần xóa", "Thông báo");
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rowindex >= 0)
            {
                rowindex = e.RowIndex;
                try
                {
                    numsl.Value = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells["Column4"].Value.ToString());
                }
                catch (Exception)
                {
                }
              
            }
        }

        int soluong = 0;
        BUS_SanPham bul_sp = new BUS_SanPham();
        int vitri;
        double giamoi;
        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (vitri != e.RowHandle)
                soluong = 0;
            textBox1.Text = BUS_HoaDon.SinhMaHD();
            if (sinhma == true)
                textBox2.Text = BUS_HoaDon.SinhMaKH();
            vitri = e.RowHandle;
            string MaSP = gridView2.GetRowCellValue(e.RowHandle, "Masp").ToString();
            string TenSP = gridView2.GetRowCellValue(e.RowHandle, "Tensp").ToString();

            double dongia = double.Parse(gridView2.GetRowCellValue(e.RowHandle, "Dongia").ToString());
            double loinhuan = double.Parse(gridView2.GetRowCellValue(e.RowHandle, "Loinhuan").ToString());
            giamoi = dongia + loinhuan * dongia;

            string DonGia = String.Format("{0:0,0.0}", giamoi) + "    VND";
            string tien = giamoi.ToString();

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvHoaDon);
            row.Cells[0].Value = MaSP;
            row.Cells[1].Value = TenSP;
            row.Cells[2].Value = DonGia;
            row.Cells[4].Value = tien;
            if (kiemtratonkho(row.Cells[0].Value.ToString()) < 0)
                lblsl.Text = "Số lượng trong kho: 0 cái";
            lblsl.Text = "Số lượng trong kho: " + kiemtratonkho(row.Cells[0].Value.ToString()).ToString() +" cái";
            if (soluong < kiemtratonkho(row.Cells[0].Value.ToString()))
            {
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
                    if (MessageBox.Show("Sản phẩm trên đã có trong danh sách \nCó muốn thêm nữa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        soluong++;
                        row.Cells[3].Value = soluong;
                    }
                }


                if (checkEdit1.Checked == true)
                {
                    lblKhuyenMai.Visible = true;
                    labelControl6.Text = String.Format("{0:0,0.0}", (BUS_HoaDon.tinhthanhtien(dgvHoaDon)) - 0.1 * BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
                    lblKhuyenMai.Text = String.Format("{0:0,0.0}", BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
                }
                else
                    labelControl6.Text = String.Format("{0:0,0.0}", BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
                    
            }
            else
            {
                soluong = 0;
                MessageBox.Show("Sản phẩm đã hết hàng", "Thông báo");
                
            }
            dgvHoaDon.RefreshEdit();
        }
        private long kiemtratonkho(string sp)
        {
            long soluongton = 0;
            long nhap, xuat;
            string tam1 = bul_sp.tongSLnhap(sp).ToString();
            string tam2 = bul_sp.tongSLban(sp).ToString();
            if (tam1 == null || tam1 == "")
            {
                nhap = 0;
            }
            else
            {
                nhap = long.Parse(tam1);
            }
            if (tam2 == null || tam2 == "")
            {
                xuat = 0;
            }
            else
            {
                xuat = long.Parse(tam2);
            }
            soluongton = nhap - xuat;
            return soluongton;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDon.Rows.Count > 0)
                {
                    if (sinhma == true)
                    {
                        BUS_KhachHang.SinhKH(textBox2.Text);
                        if (checkEdit1.Checked == true)
                            BUS_HoaDon.LuuHD(textBox1.Text, textBox2.Text, manv, DateTime.Parse(dateTimePicker1.Value.ToString()), decimal.Parse((BUS_HoaDon.tinhthanhtien(dgvHoaDon) - 0.1 * BUS_HoaDon.tinhthanhtien(dgvHoaDon)).ToString()));
                        else
                            BUS_HoaDon.LuuHD(textBox1.Text, textBox2.Text, manv, DateTime.Parse(dateTimePicker1.Value.ToString()), decimal.Parse(BUS_HoaDon.tinhthanhtien(dgvHoaDon).ToString()));
                        BUS_HoaDon.LuuCTHD(dgvHoaDon, textBox1.Text);
                    }
                    else
                    {
                        if (checkEdit1.Checked == true)
                            BUS_HoaDon.LuuHD(textBox1.Text, comboBox1.SelectedValue.ToString(), manv, DateTime.Parse(dateTimePicker1.Value.ToString()), decimal.Parse((BUS_HoaDon.tinhthanhtien(dgvHoaDon) - 0.1 * BUS_HoaDon.tinhthanhtien(dgvHoaDon)).ToString()));
                        else
                            BUS_HoaDon.LuuHD(textBox1.Text, comboBox1.SelectedValue.ToString(), manv, DateTime.Parse(dateTimePicker1.Value.ToString()), decimal.Parse(BUS_HoaDon.tinhthanhtien(dgvHoaDon).ToString()));
                        BUS_HoaDon.LuuCTHD(dgvHoaDon, textBox1.Text);
                    }
                    if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        InHoaDon bill = new InHoaDon();
                        bill.Show();
                    }
                    reset();
                }
                else
                    MessageBox.Show("Cập nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Hóa đơn không có sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            labelControl6.Text = "Thành Tiền";
            dgvHoaDon.Rows.Clear();
            lblKhuyenMai.Visible = false;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            InHoaDon bill = new InHoaDon();
            bill.Show();
        }

        bool sinhma = true;
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                comboBox1.Visible = true;
                sinhma = false;
                LoadDatacboKH();
                if (dgvHoaDon.Rows.Count > 0)
                {
                    lblKhuyenMai.Visible = true;
                    labelControl6.Text = String.Format("{0:0,0.0}", (BUS_HoaDon.tinhthanhtien(dgvHoaDon)) - 0.1 * BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
                    lblKhuyenMai.Text = String.Format("{0:0,0.0}", BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
                }
            }
            else
            {
                lblKhuyenMai.Visible = false;
                comboBox1.Visible = false;
                sinhma = true;
                if (dgvHoaDon.Rows.Count > 0)
                {
                    labelControl6.Text = String.Format("{0:0,0.0}", BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
                }
            }
        }
        //Load Combobox
        private void LoadDatacboKH()
        {
            List<DTO_KhachHang> listChuDe = BUS_KhachHang.LoadKH();
            comboBox1.DataSource = listChuDe;
            comboBox1.DisplayMember = "Tenkh";
            comboBox1.ValueMember = "Makh";
        }

        private void numsl_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvHoaDon.Rows[rowindex].Cells["Column4"].Value = numsl.Value;
                if (checkEdit1.Checked == true)
                {
                    lblKhuyenMai.Visible = true;
                    labelControl6.Text = String.Format("{0:0,0.0}", (BUS_HoaDon.tinhthanhtien(dgvHoaDon)) - 0.1 * BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
                    lblKhuyenMai.Text = String.Format("{0:0,0.0}", BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
                }
                else
                    labelControl6.Text = String.Format("{0:0,0.0}", BUS_HoaDon.tinhthanhtien(dgvHoaDon)) + " VND";
            }
            catch (Exception)
            {

            }
        }

        private void dgvHoaDon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int tong = 0;
            foreach (DataGridViewRow item in dgvHoaDon.Rows)
            {
                tong += int.Parse(item.Cells["Column4"].Value.ToString());
            }
            lblTongSL.Text = "Tổng số lượng trong giỏ hàng: " + tong.ToString() + " cái";
        }

        private void dgvHoaDon_DataMemberChanged(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (DataGridViewRow item in dgvHoaDon.Rows)
            {
                tong += int.Parse(item.Cells["Column4"].Value.ToString());
            }
            lblTongSL.Text = "Tổng số lượng trong giỏ hàng: " + tong.ToString() + " cái";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.Clear();
            lblTongSL.Text = "Tổng số lượng";
            labelControl6.Text = "Thành Tiền";
            textBox1.Text = "";
            textBox2.Text = "";
            lblsl.Text = "Tồn kho";
            lblKhuyenMai.Visible = false;
        }
    }
}
