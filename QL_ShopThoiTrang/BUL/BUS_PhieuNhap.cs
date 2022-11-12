using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using System.Windows.Forms;
using System.Data;
namespace BUS
{
    public class BUS_PhieuNhap
    {

        public static bool ThemHoaDon(DTO_PhieuNhap hoadon)
        {
            return DAL_PhieuNhap.ThemHoaDon(hoadon);
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
        public static string SinhMaPN()
        {
            return DataProvider.MaKeTiep(DataProvider.LayMaCuoi("Hoa_Don_Nhap", "ma_hdn"), "HDN");
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
        public static void LuuHD(string _Mahdn, string _Mancc,string _Manv, DateTime _NgayNhap, decimal _Giatri)
        {
            DTO_PhieuNhap hoadon = new DTO_PhieuNhap();
            hoadon.Mahdn = _Mahdn;
            hoadon.Mancc = _Mancc;
            hoadon.Manv = _Manv;
            hoadon.Ngaynhap = _NgayNhap;
            hoadon.Giatri = _Giatri;
            BUS_PhieuNhap.ThemHoaDon(hoadon);
               // MessageBox.Show("ok hd");
        }
        public static void LuuCTHD(DataGridView dgvHoaDon,string _Mahdn)
        {
            DTO_ChiTietPhieuNhap cthoadon = new DTO_ChiTietPhieuNhap();
            for (int i = 0; i < dgvHoaDon.RowCount; i++)
            {
                DataGridViewRow row1 = dgvHoaDon.Rows[i];
                cthoadon.Mahdn = _Mahdn;
                cthoadon.Masp = row1.Cells[0].Value.ToString();
                cthoadon.Soluong = int.Parse(row1.Cells[3].Value.ToString());
                cthoadon.Dongia = decimal.Parse(row1.Cells[4].Value.ToString());
                BUS_ChiTietPhieuNhap.ThemCTHoaDon(cthoadon);
                    //MessageBox.Show("ok cthd");
            }
        }
        public static void LuuSP(DataGridView dgvHoaDon)
        {
            for (int i = 0; i < dgvHoaDon.RowCount; i++)
            {
                DataGridViewRow row1 = dgvHoaDon.Rows[i];
                DTO_SanPham sanpham = new DTO_SanPham(row1.Cells[0].Value.ToString(),decimal.Parse(row1.Cells[4].Value.ToString()));
                BUS_SanPham.UpdateDonGia(sanpham);
            }
        }
        DAL_PhieuNhap dal_hdn = new DAL_PhieuNhap();
        public DataTable laydl()
        {
            return dal_hdn.Get();
        }
        public DataTable laydl(string ma)
        {
            return dal_hdn.Get(ma);
        }
        public object tongngay(DateTime  ngay)
        {
            return dal_hdn.SumD(ngay);
        }
        public object tongthang(string thang, string nam)
        {
            return dal_hdn.SumM(thang, nam);
        }
        public object tongnam(string nam)
        {
            return dal_hdn.SumY(nam);
        }
        public DataTable hienthiNCC()
        {
            return dal_hdn.LoadCmb();
        }
        public DataTable layngay(DateTime ngay)
        {
            return dal_hdn.GetDay(ngay);
        }
        public DataTable laythang(string thang, string nam)
        {
            return dal_hdn.GetMonth(thang, nam);
        }
        public DataTable laynam(string nam)
        {
            return dal_hdn.GetYear(nam);
        }
    }
}
