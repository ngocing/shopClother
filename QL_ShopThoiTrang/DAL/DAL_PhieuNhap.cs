using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_PhieuNhap
    {
        public static string SinhMaPN()
        {
            return DataProvider.MaKeTiep(DataProvider.LayMaCuoi("Hoa_Don_Nhap", "ma_hdn"), "HDN");
        }
        static SqlConnection connect;
        public static bool ThemHoaDon(DTO_PhieuNhap hoadon)
        {
            string chuoilenh = string.Format(@"INSERT INTO Hoa_Don_Nhap (ma_hdn, ma_ncc,ma_nv, ngay_lap, tri_gia)
                                            VALUES ('{0}', '{1}', '{2}', '{3}','{4}')",
                                            hoadon.Mahdn, hoadon.Mancc,hoadon.Manv, hoadon.Ngaynhap, hoadon.Giatri);
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
            string lenh = "select Nha_Cung_Cap.ten_ncc,Hoa_Don_Nhap.* from (Hoa_Don_Nhap INNER JOIN Nha_Cung_Cap on Hoa_Don_Nhap.ma_ncc=Nha_Cung_Cap.ma_ncc)";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable Get(string ma)
        {
            string lenh = string.Format("select Nha_Cung_Cap.ten_ncc,Hoa_Don_Nhap.* from (Hoa_Don_Nhap INNER JOIN Nha_Cung_Cap on Hoa_Don_Nhap.ma_ncc=Nha_Cung_Cap.ma_ncc) where ma_hdn='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetDay(DateTime day)
        {
            string lenh = string.Format("select * from Hoa_Don_Nhap where DAY(ngay_lap)={0} and MONTH(ngay_lap)={1} and YEAR(ngay_lap)={2}", day.Day, day.Month, day.Year);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetMonth(string month, string year)
        {
            string lenh = string.Format("select * from Hoa_Don_Nhap where MONTH(ngay_lap)={0} and YEAR(ngay_lap)={1}", month, year);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetYear(string year)
        {
            string lenh = string.Format("select * from Hoa_Don_Nhap where YEAR(ngay_lap)={0}", year);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public object SumD(DateTime day)
        {
            string lenh = string.Format("select SUM(tri_gia) from Hoa_Don_Nhap where DAY(ngay_lap)={0} and MONTH(ngay_lap)={1} and YEAR(ngay_lap)={2}", day.Day, day.Month, day.Year);
            connect = DataProvider.KetNoi();
            return DataProvider.LayGiaTri(lenh, connect);
            // connect.Close();
        }
        public object SumM(string month, string year)
        {
            string lenh = string.Format("select SUM(tri_gia) from Hoa_Don_Nhap where MONTH(ngay_lap)={0} and YEAR(ngay_lap)={1}", month, year);
            connect = DataProvider.KetNoi();
            return DataProvider.LayGiaTri(lenh, connect);
            // connect.Close();
        }
        public object SumY(string year)
        {
            string lenh = string.Format("select SUM(tri_gia) from Hoa_Don_Nhap where YEAR(ngay_lap)={0}", year);
            connect = DataProvider.KetNoi();
            return DataProvider.LayGiaTri(lenh, connect);
            // connect.Close();
        }
        //lệnh delete xóa dữ liệu
        public void Delete(string ma)
        {

            string lenh = string.Format("delete from Hoa_Don_Nhap where ma_hdn={0}", ma);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        public DataTable LoadCmb()
        {
            connect = DataProvider.KetNoi();
            string lenh = "select *  from Nha_Cung_Cap";
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
    }
}
