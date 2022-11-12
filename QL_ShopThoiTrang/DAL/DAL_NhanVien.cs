using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
   public class DAL_NhanVien
    {
        static SqlConnection connect;
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>   NHÂN VIÊN
        #region Nhân Viên
        public static List<DTO_NhanVien> LoadNV()
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM Nhan_vien";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            if (data.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhanVien> lstnv = new List<DTO_NhanVien>();
            
            for (int i = 0; i < data.Rows.Count; i++)
            {
               
                if (data.Rows[i]["ten_nv"].ToString().Trim() != "Chua xac dinh")
                {
                    DTO_NhanVien nv = new DTO_NhanVien();  
                    nv.Manv = data.Rows[i]["ma_nv"].ToString();
                    nv.Tennv = data.Rows[i]["ten_nv"].ToString();
                    nv.Taikhoan = data.Rows[i]["tai_khoan"].ToString();
                    nv.Matkhau = data.Rows[i]["mat_khau"].ToString();
                    nv.Maquyen = data.Rows[i]["ma_quyen"].ToString();
                    lstnv.Add(nv);
                }
            }
            DataProvider.DongKetNoi(connect);
            return lstnv;
        }
        public static bool ThemNhanvien(DTO_NhanVien nv)
        {
            string chuoilenh = string.Format(@"INSERT INTO Nhan_vien (ma_nv, ten_nv, gioi_tinh, ngay_sinh, dia_chi,dien_thoai,email,tai_khoan,mat_khau,ma_quyen)
                                                    VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}')",
                                            nv.Manv, nv.Tennv, nv.Gioitinh, nv.Ngaysinh, nv.Diachi, nv.Dienthoai, nv.Email, nv.Taikhoan, nv.Matkhau, nv.Maquyen);
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
        public static string SinhMaNV()
        {
            return DataProvider.MaKeTiep(DataProvider.LayMaCuoi("Nhan_Vien", "ma_nv"), "NV");
        }
        public DataTable Get()
        {
            string lenh = "select ma_nv, ten_nv, gioi_tinh, ngay_sinh, dia_chi,dien_thoai,email,tai_khoan,ma_quyen from Nhan_vien";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable Get_NV(string ma)
        {
            string lenh = string.Format("SELECT * from Nhan_vien where tai_khoan ='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable searchHDban(string ma)
        {
            string lenh = string.Format("select * from Hoa_Don where ma_nv='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable searchHDnhap(string ma)
        {
            string lenh = string.Format("select * from Hoa_Don_Nhap where ma_nv='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable searchNV(string ma)
        {
            string lenh = string.Format("SELECT ma_nv, ten_nv, gioi_tinh, ngay_sinh, dia_chi,dien_thoai,email,tai_khoan,ma_quyen FROM Nhan_vien WHERE ten_nv like '%" + ma + "%'");
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public void Insert(DTO_NhanVien nv)
        {
             string lenh = string.Format(@"INSERT INTO Nhan_vien (ma_nv, ten_nv, gioi_tinh, ngay_sinh, dia_chi,dien_thoai,email,tai_khoan,mat_khau,ma_quyen)
                                            VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}',N'{6}',N'{7}',N'{8}',N'{9}')",
                                           nv.Manv, nv.Tennv, nv.Gioitinh, nv.Ngaysinh, nv.Diachi, nv.Dienthoai, nv.Email,nv.Taikhoan,nv.Matkhau,nv.Maquyen);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        public void Update(DTO_NhanVien nv)
        {
            string lenh = string.Format(@"update Nhan_vien set ten_nv=N'{0}', gioi_tinh=N'{1}', ngay_sinh=N'{2}', dia_chi=N'{3}',dien_thoai=N'{4}',email=N'{5}' where tai_khoan=N'{6}'",
                                    nv.Tennv, nv.Gioitinh, nv.Ngaysinh, nv.Diachi, nv.Dienthoai, nv.Email,nv.Taikhoan);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        public void Delete(string ma)
        {

            string lenh = string.Format("delete from Nhan_vien where ma_nv='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }

        #endregion
       // >>>>>>>>>>>>>>>>>Login
        public DataTable Getlogin(string ma)
        {
            string lenh = "select * from Nhan_vien where tai_khoan='" + ma + "'";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public static List<DTO_PhanQuyen> Loadquyen()
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM Phan_quyen";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            if (data.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_PhanQuyen> lstq = new List<DTO_PhanQuyen>();
            for (int i = 0; i < data.Rows.Count; i++)
            {

                    DTO_PhanQuyen q = new DTO_PhanQuyen();
                    q.Maquyen = data.Rows[i]["ma_quyen"].ToString();
                    q.Tenquyen = data.Rows[i]["ten_quyen"].ToString();
                    lstq.Add(q);
   
            }
            DataProvider.DongKetNoi(connect);
            return lstq;
        }
        public static bool UpdateMK(DTO_NhanVien login)
        {
            string chuoilenh = "Update Nhan_vien set mat_khau = N'" + login.Matkhau + "' where tai_khoan = N'" + login.Taikhoan + "'";
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
       
    }
}
