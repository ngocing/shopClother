using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_NhanHieu
    {
        static SqlConnection connect;
        public static DataTable LayDatatable()
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM Nhan_Hieu ";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            DataProvider.DongKetNoi(connect);
            return data;

        }
        public static List<DTO_NhanHieu> Load()
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * from Nhan_Hieu";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            if (data.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhanHieu> lstNH = new List<DTO_NhanHieu>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DTO_NhanHieu hieu = new DTO_NhanHieu();

                hieu.Manhanhieu = data.Rows[i]["ma_hieu"].ToString();
                hieu.Tennhanhieu = data.Rows[i]["ten_hieu"].ToString();

                lstNH.Add(hieu);
            }
            DataProvider.DongKetNoi(connect);
            return lstNH;

        }
        public static bool Them(DTO_NhanHieu nhanhieu)
        {
            string chuoilenh = string.Format(@"INSERT INTO Nhan_Hieu ( ma_hieu,ten_hieu) VALUES (N'{0}',N'{1}')",nhanhieu.Manhanhieu, nhanhieu.Tennhanhieu);
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
        public static bool Sua(DTO_NhanHieu nhanhieu)
        {
            string chuoilenh = string.Format(@"UPDATE Nhan_Hieu SET ten_hieu = N'{0}' WHERE ma_hieu =N'{1}';", nhanhieu.Tennhanhieu, nhanhieu.Manhanhieu);
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
        public static bool Xoa(DTO_NhanHieu nhanhieu)
        {
            string chuoilenh = string.Format(@"DELETE FROM Nhan_Hieu WHERE ma_hieu ='{0}'", nhanhieu.Manhanhieu);
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
        public static string SinhMaNH()
        {
            return DataProvider.MaKeTiep(DataProvider.LayMaCuoi("Nhan_Hieu", "ma_hieu"), "NH");
        }
    }
}
