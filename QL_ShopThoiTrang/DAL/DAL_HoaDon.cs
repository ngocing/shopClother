using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_HoaDon
    {
        public static string SinhMaHD()
        {
            return DataProvider.MaKeTiep(DataProvider.LayMaCuoi("Hoa_Don", "ma_hd"), "HD");
        }
        public static string SinhMaKH()
        {
            return DataProvider.MaKeTiep(DataProvider.LayMaCuoi("Khach_Hang", "ma_kh"), "KH");
        }
        static SqlConnection connect;
        public static bool ThemHoaDon(DTO_HoaDon hoadon)
        {
            string chuoilenh = string.Format(@"INSERT INTO Hoa_Don (ma_hd, ngay_lap, ma_kh, tri_gia,ma_nv)
                                            VALUES ('{0}', '{1}', '{2}','{3}','{4}')",
                                           hoadon.Mahd, hoadon.Ngaylap, hoadon.Makh, hoadon.Tri_gia,hoadon.Manv);
            connect = DataProvider.KetNoi();
            try
            {
                DataProvider.CauLenhNonQuery(chuoilenh, connect);
                DataProvider.DongKetNoi(connect);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(connect);
                return false;
            }
        }
        public static bool ThemCTHoaDon(DTO_ChiTietHoaDon cthoadon)
        {
            string chuoilenh = string.Format(@"INSERT INTO Ct_Hoa_Don (ma_hd, ma_sp, so_luong,don_gia)
                                            VALUES ('{0}', '{1}', {2}, {3})",
                                            cthoadon.Mahd, cthoadon.Masp, cthoadon.Soluong, cthoadon.Dongia);
            connect = DataProvider.KetNoi();
            try
            {
                DataProvider.CauLenhNonQuery(chuoilenh, connect);
                DataProvider.DongKetNoi(connect);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(connect);
                return false;
            }
        }
        public DataTable Get()
        {
            string lenh = "select Khach_Hang.ten_kh,Hoa_Don.* from (Hoa_Don INNER JOIN Khach_Hang on Hoa_Don.ma_kh=Khach_Hang.ma_kh)";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable Get(string ma)
        {
            string lenh = string.Format("select Khach_Hang.ten_kh,Hoa_Don.* from (Hoa_Don INNER JOIN Khach_Hang on Hoa_Don.ma_kh=Khach_Hang.ma_kh) where ma_hd='{0}'", ma) ;
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetCt(string ma)
        {
            string lenh = string.Format(@"SELECT        San_Pham.ma_sp, San_Pham.ten_sp, Ct_Hoa_Don.so_luong, San_Pham.don_gia, Hoa_Don.ma_hd, 
                         Hoa_Don.ngay_lap, Ct_Hoa_Don.so_luong*San_Pham.don_gia as thanh_tien
FROM            ((Ct_Hoa_Don INNER JOIN
                         Hoa_Don ON Ct_Hoa_Don.ma_hd = Hoa_Don.ma_hd)  INNER JOIN
                         San_Pham ON Ct_Hoa_Don.ma_sp = San_Pham.ma_sp) where Hoa_Don.ma_hd='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
    }
}
