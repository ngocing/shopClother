using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_NhaCungCap
    {
        static SqlConnection connect;
        public static List<DTO_NhaCungCap> LoadNCC()
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM Nha_Cung_Cap";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            if (data.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhaCungCap> lstNCC = new List<DTO_NhaCungCap>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DTO_NhaCungCap ncc = new DTO_NhaCungCap();

                ncc.Mancc = data.Rows[i]["ma_ncc"].ToString();
                ncc.Tenncc = data.Rows[i]["ten_ncc"].ToString();
                ncc.Diachi = data.Rows[i]["dia_chi"].ToString();
                ncc.Dienthoai = data.Rows[i]["dien_thoai"].ToString();
                ncc.Email = data.Rows[i]["email"].ToString();
                lstNCC.Add(ncc);
            }
            DataProvider.DongKetNoi(connect);
            return lstNCC;
        }

        public static bool Them(DTO_NhaCungCap cungcap)
        {
            string chuoilenh = string.Format(@"INSERT INTO Nha_Cung_Cap (ma_ncc,ten_ncc,dia_chi,dien_thoai,email)
                                    VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",cungcap.Mancc, cungcap.Tenncc, cungcap.Diachi, cungcap.Dienthoai, cungcap.Email);
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
        public static bool Sua(DTO_NhaCungCap cungcap)
        {
            string chuoilenh = string.Format(@"UPDATE Nha_Cung_Cap SET ten_ncc = N'{0}',dia_chi=N'{1}',dien_thoai=N'{2}',email=N'{3}' WHERE ma_ncc =N'{4}';", cungcap.Tenncc, cungcap.Diachi, cungcap.Dienthoai, cungcap.Email, cungcap.Mancc);
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
        public static bool Xoa(DTO_NhaCungCap cungcap)
        {
            string chuoilenh = string.Format(@"DELETE FROM Nha_Cung_Cap WHERE ma_ncc ='{0}'", cungcap.Mancc);
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
        public static string SinhMaNCC()
        {
            return DataProvider.MaKeTiep(DataProvider.LayMaCuoi("Nha_Cung_Cap", "ma_ncc"), "NCC");
        }
    }
}
