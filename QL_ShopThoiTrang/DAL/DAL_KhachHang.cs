using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DAL_KhachHang
    {
        static SqlConnection connect;
        public static List<DTO_KhachHang> LoadKH()
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM Khach_Hang";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            if (data.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_KhachHang> lstNCC = new List<DTO_KhachHang>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["ten_kh"].ToString().Trim() != "Chua xac dinh")
                {
                    DTO_KhachHang ncc = new DTO_KhachHang();
                    ncc.Makh = data.Rows[i]["ma_kh"].ToString();
                    ncc.Tenkh = data.Rows[i]["ten_kh"].ToString();
                    lstNCC.Add(ncc);
                }
            }
            DataProvider.DongKetNoi(connect);
            return lstNCC;
        }
        public static bool ThemKhachHang(DTO_KhachHang khachhang)
        {
            string chuoilenh = string.Format(@"INSERT INTO Khach_Hang (ma_kh, ten_kh, gioi_tinh, ngay_sinh, dia_chi,dien_thoai,email)
                                            VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}')",
                                            khachhang.Makh, khachhang.Tenkh, khachhang.Gioitinh, khachhang.Ngaysinh, khachhang.Diachi, khachhang.Dienthoai, khachhang.Email);
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
        public static string SinhMaKH()
        {
            return DataProvider.MaKeTiep(DataProvider.LayMaCuoi("Khach_Hang", "ma_kh"), "KH");
        }
        public DataTable Get()
        {
            string lenh = "select * from Khach_Hang";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable searchHD(string ma)
        {
            string lenh = string.Format("select * from Hoa_Don where ma_kh='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable searchKH(string ma)
        {
            string lenh = string.Format("select * from Khach_Hang where ma_kh='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public void Insert(DTO_KhachHang kh)
        {
            string lenh = string.Format(@"insert into Khach_Hang (ma_kh, ten_kh, gioi_tinh, ngay_sinh, dia_chi,dien_thoai,email) 
                                        values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                        kh.Makh,kh.Tenkh,kh.Gioitinh,kh.Ngaysinh,kh.Diachi,kh.Dienthoai,kh.Email);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        public void Update(DTO_KhachHang kh)
        {
            string lenh = string.Format(@"update Khach_Hang set ten_kh=N'{0}', gioi_tinh=N'{1}', ngay_sinh=N'{2}', dia_chi=N'{3}',dien_thoai=N'{4}' where ma_kh=N'{6}'",
                                    kh.Tenkh, kh.Gioitinh, kh.Ngaysinh, kh.Diachi, kh.Dienthoai, kh.Email, kh.Makh);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        public void Delete(string ma)
        {

            string lenh = string.Format("delete from Khach_Hang where ma_kh='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
    }
}
