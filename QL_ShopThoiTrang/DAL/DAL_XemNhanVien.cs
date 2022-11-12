using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
   public class DAL_XemNhanVien
    {
        static SqlConnection connect;
        public DataTable Get()
        {
            string lenh = @"SELECT Nhan_vien.ma_nv, Nhan_vien.ten_nv, COUNT(Hoa_Don.ma_hd) AS Soluong FROM Nhan_vien INNER JOIN Hoa_Don ON Nhan_vien.ma_nv = Hoa_Don.ma_nv WHERE Nhan_vien.ma_quyen = '2' or Nhan_vien.ma_quyen = '1' GROUP BY Nhan_vien.ma_nv, Nhan_vien.ten_nv";

            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        #region Nhân Viên bán hàng
        public DataTable GetDay(DateTime day)
        {
            string lenh = string.Format(@"SELECT Nhan_vien.ma_nv, Nhan_vien.ten_nv, COUNT(Hoa_Don.ma_hd) AS Soluong FROM Nhan_vien INNER JOIN Hoa_Don ON Nhan_vien.ma_nv = Hoa_Don.ma_nv WHERE  DAY(Hoa_Don.ngay_lap)='{0}' and MONTH(Hoa_Don.ngay_lap)='{1}' and YEAR(Hoa_Don.ngay_lap)='{2}'  and (Nhan_vien.ma_quyen = '1' or Nhan_vien.ma_quyen = '2') GROUP BY Nhan_vien.ma_nv, Nhan_vien.ten_nv", day.Day, day.Month, day.Year);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetMonth(string month, string year)
        {
            string lenh = string.Format(@"SELECT Nhan_vien.ma_nv, Nhan_vien.ten_nv, COUNT(Hoa_Don.ma_hd) AS Soluong FROM Nhan_vien INNER JOIN Hoa_Don ON Nhan_vien.ma_nv = Hoa_Don.ma_nv WHERE  MONTH(Hoa_Don.ngay_lap)='{0}' and YEAR(Hoa_Don.ngay_lap)='{1}' and (Nhan_vien.ma_quyen = '1' or Nhan_vien.ma_quyen = '2') GROUP BY Nhan_vien.ma_nv, Nhan_vien.ten_nv", month, year);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetYear(string year)
        {
            string lenh = string.Format(@"SELECT Nhan_vien.ma_nv, Nhan_vien.ten_nv,COUNT(Hoa_Don.ma_hd) AS Soluong FROM Nhan_vien INNER JOIN Hoa_Don ON Nhan_vien.ma_nv = Hoa_Don.ma_nv WHERE  YEAR(Hoa_Don.ngay_lap)='{0}' and (Nhan_vien.ma_quyen = '1' or Nhan_vien.ma_quyen = '2') GROUP BY Nhan_vien.ma_nv, Nhan_vien.ten_nv", year);

            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        #endregion
        #region Nhân Viên bán hàng nhiều nhất
        public DataTable GetDay_NN(DateTime day)
        {
            string lenh = string.Format(@"SELECT TOP 1 Nhan_vien.ma_nv, Nhan_vien.ten_nv, COUNT(Hoa_Don.ma_hd) AS Soluong FROM Nhan_vien INNER JOIN Hoa_Don ON Nhan_vien.ma_nv = Hoa_Don.ma_nv WHERE  DAY(Hoa_Don.ngay_lap)='{0}' and MONTH(Hoa_Don.ngay_lap)='{1}' and YEAR(Hoa_Don.ngay_lap)='{2}'  and (Nhan_vien.ma_quyen = '1' or Nhan_vien.ma_quyen = '2') GROUP BY Nhan_vien.ma_nv, Nhan_vien.ten_nv ORDER BY COUNT(Hoa_Don.ma_hd) DESC", day.Day, day.Month, day.Year);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetMonth_NN(string month, string year)
        {
            string lenh = string.Format(@"SELECT top 1 Nhan_vien.ma_nv, Nhan_vien.ten_nv, COUNT(Hoa_Don.ma_hd) AS Soluong FROM Nhan_vien INNER JOIN Hoa_Don ON Nhan_vien.ma_nv = Hoa_Don.ma_nv WHERE  MONTH(Hoa_Don.ngay_lap)='{0}' and YEAR(Hoa_Don.ngay_lap)='{1}' and (Nhan_vien.ma_quyen = '1' or Nhan_vien.ma_quyen = '2') GROUP BY Nhan_vien.ma_nv, Nhan_vien.ten_nv ORDER BY COUNT(Hoa_Don.ma_hd) DESC", month, year);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetYear_NN(string year)
        {
            string lenh = string.Format(@"SELECT top 1 Nhan_vien.ma_nv, Nhan_vien.ten_nv, COUNT(Hoa_Don.ma_hd) AS Soluong FROM Nhan_vien INNER JOIN Hoa_Don ON Nhan_vien.ma_nv = Hoa_Don.ma_nv WHERE  YEAR(Hoa_Don.ngay_lap)='{0}' and (Nhan_vien.ma_quyen = '1' or Nhan_vien.ma_quyen = '2') GROUP BY Nhan_vien.ma_nv, Nhan_vien.ten_nv ORDER BY COUNT(Hoa_Don.ma_hd) DESC", year);

            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        #endregion
        #region Nhân Viên bán không được hàng
        public DataTable GetDay_KBD(DateTime day)
        {
            string lenh = string.Format(@"SELECT Nhan_vien.ma_nv,Nhan_vien.ten_nv,Nhan_vien.email FROM Nhan_vien WHERE Nhan_vien.ma_nv  not in (SELECT Nhan_vien.ma_nv FROM Nhan_vien INNER JOIN Hoa_Don ON Nhan_vien.ma_nv = Hoa_Don.ma_nv WHERE DAY(Hoa_Don.ngay_lap)='{0}' and MONTH(Hoa_Don.ngay_lap)='{1}' and YEAR(Hoa_Don.ngay_lap)='{2}' )  and (Nhan_vien.ma_quyen = '1' or Nhan_vien.ma_quyen = '2')", day.Day, day.Month, day.Year);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetMonth_KBD(string month, string year)
        {
            string lenh = string.Format(@"SELECT Nhan_vien.ma_nv,Nhan_vien.ten_nv,Nhan_vien.email FROM Nhan_vien WHERE Nhan_vien.ma_nv  not in (SELECT Nhan_vien.ma_nv FROM Nhan_vien INNER JOIN Hoa_Don ON Nhan_vien.ma_nv = Hoa_Don.ma_nv WHERE MONTH(Hoa_Don.ngay_lap)='{0}' and YEAR(Hoa_Don.ngay_lap)='{1}' )  and (Nhan_vien.ma_quyen = '1' or Nhan_vien.ma_quyen = '2')", month, year);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetYear_KBD(string year)
        {
            string lenh = string.Format(@"SELECT Nhan_vien.ma_nv, Nhan_vien.ten_nv,Nhan_vien.email FROM Nhan_vien WHERE Nhan_vien.ma_nv  not in (SELECT Nhan_vien.ma_nv FROM Nhan_vien INNER JOIN Hoa_Don ON Nhan_vien.ma_nv = Hoa_Don.ma_nv WHERE YEAR(Hoa_Don.ngay_lap)='{0}' )  and (Nhan_vien.ma_quyen = '1' or Nhan_vien.ma_quyen = '2')", year);

            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        #endregion
     
   }
}
