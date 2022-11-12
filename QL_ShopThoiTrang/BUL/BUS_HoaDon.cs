using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using System.Windows.Forms;
using System.Data;
namespace BUS
{
    public class BUS_HoaDon
    {
        public static string SinhMaHD()
        {
            return DAL_HoaDon.SinhMaHD();
        }
        public static string SinhMaKH()
        {
            return DAL_HoaDon.SinhMaKH();
        }
        public static bool ThemHoaDon(DTO_HoaDon hoadon)
        {
            return DAL_HoaDon.ThemHoaDon(hoadon);
        }
        public static bool ThemCTHoaDon(DTO_ChiTietHoaDon hoadon)
        {
            return DAL_HoaDon.ThemCTHoaDon(hoadon);
        }
        public static int kiemtratontai(string TenSP, DataGridView dgvHoaDon)
        {
            for (int i = 0; i < dgvHoaDon.RowCount; i++)
            {
                string Tenkiemtra = dgvHoaDon[0, i].Value.ToString();
                if (Tenkiemtra == TenSP)
                    return i;
            }
            return -1;
        }
        public static void loadtreeview(TreeView treeView1)
        {
            DataTable tbl1 = BUS_LoaiCha.LayDatatable();
            foreach (DataRow drwLoaiCha in tbl1.Rows)
            {
                TreeNode nodeLoai = new TreeNode();
                nodeLoai.Name = drwLoaiCha["ma_loai_cha"].ToString();
                nodeLoai.Text = drwLoaiCha["ten_loai_cha"].ToString();
                TreeNode Goc = treeView1.Nodes[0];
                Goc.Text = "Danh Sách";
                treeView1.ImageIndex = 0;
                treeView1.Tag = drwLoaiCha["ma_loai_cha"].ToString();
                Goc.Nodes.Add(nodeLoai);
                DataTable tbl2 = BUS_LoaiSanPham.LayDatatable(drwLoaiCha["ma_loai_cha"].ToString());
                foreach (DataRow drwLoaiSP in tbl2.Rows)
                {
                    TreeNode nodeCon = new TreeNode(drwLoaiSP["ten_loai"].ToString());
                    nodeCon.Name = drwLoaiSP["ma_loai"].ToString();
                    nodeCon.Text = drwLoaiSP["ten_loai"].ToString();
                    nodeLoai.Nodes.Add(nodeCon);
                    //treeView1.Tag = drwLoaiSP["ma_loai"].ToString();
                    treeView1.ImageIndex = 1;

                }
            }
        }
        public static void loadlistview(ListView listView1)
        {
            DataTable tbl1 = BUS_NhanHieu.LayDatatable();
            int i = 0;
            foreach (DataRow drwNhanHieu in tbl1.Rows)
            {
                i++;
                ListViewItem lvw = new ListViewItem();
                lvw.Text = drwNhanHieu["ten_hieu"].ToString();
                lvw.Name = drwNhanHieu["ma_hieu"].ToString();
                lvw.SubItems.Add(drwNhanHieu["ma_hieu"].ToString());
                //lvw.SubItems.IndexOfKey(drwNhanHieu["ma_hieu"].ToString());
                lvw.ImageIndex = i;
                listView1.Items.Add(lvw);
            }
        }
        public static double tinhthanhtien(DataGridView dgvHoaDon)
        {
            double tong = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                tong += Convert.ToDouble(dgvHoaDon[3, i].Value) * Convert.ToDouble(dgvHoaDon[4, i].Value);
            }
            return tong;
        }
        public static void LuuHD(string _Mahd,string _Makh,string _Manv,DateTime _Ngaylap,decimal _trigia)
        {
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.Mahd = _Mahd;
            hoadon.Makh = _Makh;
            hoadon.Manv = _Manv;
            hoadon.Ngaylap = _Ngaylap;
            hoadon.Tri_gia = _trigia;
            BUS_HoaDon.ThemHoaDon(hoadon);
                //MessageBox.Show("ok hd");
        }
        public static void LuuCTHD(DataGridView dgvHoaDon,string _mahd)
        {
            DTO_ChiTietHoaDon cthoadon = new DTO_ChiTietHoaDon();
            for (int i = 0; i < dgvHoaDon.RowCount; i++)
            {
                DataGridViewRow row1 = dgvHoaDon.Rows[i];
                cthoadon.Mahd = _mahd;
                cthoadon.Masp = row1.Cells[0].Value.ToString();
                cthoadon.Soluong = int.Parse(row1.Cells[3].Value.ToString());
                cthoadon.Dongia = decimal.Parse(row1.Cells[4].Value.ToString());
                BUS_HoaDon.ThemCTHoaDon(cthoadon);
                    //MessageBox.Show("ok cthd");
            }
        }
        DAL_HoaDon dal_hd = new DAL_HoaDon();
        public DataTable laydl()
        {
            return dal_hd.Get();
        }
        public DataTable layct(string ma)
        {
            return dal_hd.GetCt(ma);
        }
        public DataTable laydl(string ma)
        {
            return dal_hd.Get(ma);
        }
    }
}
