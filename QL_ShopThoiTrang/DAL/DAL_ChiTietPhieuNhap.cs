using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DAL_ChiTietPhieuNhap
    {
        static SqlConnection connect;
        public static bool ThemCTHoaDon(DTO_ChiTietPhieuNhap cthoadon)
        {
            string chuoilenh = string.Format(@"INSERT INTO Ct_Hoa_Don_Nhap (ma_hdn, ma_sp, so_luong,don_gia)
                                            VALUES ('{0}', '{1}', {2}, {3})",
                                            cthoadon.Mahdn, cthoadon.Masp, cthoadon.Soluong, cthoadon.Dongia);
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
        public DataTable Get(string ma)
        {
            string lenh = string.Format(@"SELECT        San_Pham.ma_sp, San_Pham.ten_sp, Ct_Hoa_Don_Nhap.so_luong, Ct_Hoa_Don_Nhap.don_gia, Nha_Cung_Cap.ten_ncc, Hoa_Don_Nhap.ma_hdn, 
                         Hoa_Don_Nhap.ngay_lap, Ct_Hoa_Don_Nhap.so_luong*Ct_Hoa_Don_Nhap.don_gia as thanh_tien
FROM            (((Ct_Hoa_Don_Nhap INNER JOIN
                         Hoa_Don_Nhap ON Ct_Hoa_Don_Nhap.ma_hdn = Hoa_Don_Nhap.ma_hdn) INNER JOIN
                         Nha_Cung_Cap ON Hoa_Don_Nhap.ma_ncc = Nha_Cung_Cap.ma_ncc) INNER JOIN
                         San_Pham ON Ct_Hoa_Don_Nhap.ma_sp = San_Pham.ma_sp) where Hoa_Don_Nhap.ma_hdn='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
    }
}
