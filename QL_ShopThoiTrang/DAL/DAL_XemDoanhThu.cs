using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
   public  class DAL_XemDoanhThu
    {
        static SqlConnection connect;
        public DataTable Get()
        {
            string lenh = @"SELECT Hoa_Don.ngay_lap, San_Pham.ten_sp,Ct_Hoa_Don.so_luong,Ct_Hoa_Don.don_gia , Hoa_Don.ma_hd, Ct_Hoa_Don.so_luong*Ct_Hoa_Don.don_gia as tri_gia
FROM            ((Ct_Hoa_Don INNER JOIN Hoa_Don ON Ct_Hoa_Don.ma_hd = Hoa_Don.ma_hd) INNER JOIN San_Pham ON Ct_Hoa_Don.ma_sp = San_Pham.ma_sp)";

            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetDay(DateTime day)
        {
            string lenh = string.Format(@"SELECT        Hoa_Don.ngay_lap, San_Pham.ten_sp,Ct_Hoa_Don.so_luong,Ct_Hoa_Don.don_gia, Hoa_Don.ma_hd, Ct_Hoa_Don.so_luong*Ct_Hoa_Don.don_gia as tri_gia
FROM            ((Ct_Hoa_Don INNER JOIN Hoa_Don ON Ct_Hoa_Don.ma_hd = Hoa_Don.ma_hd) INNER JOIN San_Pham ON Ct_Hoa_Don.ma_sp = San_Pham.ma_sp) where DAY(Hoa_Don.ngay_lap)={0} and MONTH(Hoa_Don.ngay_lap)={1} and YEAR(Hoa_Don.ngay_lap)={2}", day.Day, day.Month, day.Year);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetMonth(string month, string year)
        {
            string lenh = string.Format(@"SELECT        Hoa_Don.ngay_lap, San_Pham.ten_sp,Ct_Hoa_Don.so_luong,Ct_Hoa_Don.don_gia, Hoa_Don.ma_hd, Ct_Hoa_Don.so_luong*Ct_Hoa_Don.don_gia as tri_gia
FROM            ((Ct_Hoa_Don INNER JOIN Hoa_Don ON Ct_Hoa_Don.ma_hd = Hoa_Don.ma_hd) INNER JOIN San_Pham ON Ct_Hoa_Don.ma_sp = San_Pham.ma_sp) where MONTH(Hoa_Don.ngay_lap)={0} and YEAR(Hoa_Don.ngay_lap)={1}", month, year);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetYear(string year)
        {
            string lenh = string.Format(@"SELECT        Hoa_Don.ngay_lap, San_Pham.ten_sp,Ct_Hoa_Don.so_luong,Ct_Hoa_Don.don_gia , Hoa_Don.ma_hd, Ct_Hoa_Don.so_luong*Ct_Hoa_Don.don_gia as tri_gia
FROM            ((Ct_Hoa_Don INNER JOIN Hoa_Don ON Ct_Hoa_Don.ma_hd = Hoa_Don.ma_hd) INNER JOIN San_Pham ON Ct_Hoa_Don.ma_sp = San_Pham.ma_sp) where YEAR(Hoa_Don.ngay_lap)={0}", year);

            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable LoadCmb()
        {
            connect = DataProvider.KetNoi();
            string lenh = "select *  from San_Pham";
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
    }
}
