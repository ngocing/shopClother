using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Windows.Forms;
using System.Data;
namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_NV = new DAL_NhanVien();
        #region Nhân Viên
        public static void SinhNV(string _maNV)
        {
            DTO_NhanVien nhanvien = new DTO_NhanVien();
            nhanvien.Manv = _maNV;
            nhanvien.Tennv = "Chua xac dinh";
            nhanvien.Gioitinh = "Chua xac dinh";
            nhanvien.Diachi = "Chua xac dinh";
            nhanvien.Dienthoai = "Chua xac dinh";
            nhanvien.Email = "Chua xac dinh";
            nhanvien.Ngaysinh = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
            try
            {
                ThemNhanvien(nhanvien);
                //MessageBox.Show("ok kh");

            }
            catch (Exception)
            {

            }
        }
        public static bool ThemNhanvien(DTO_NhanVien nhanvien)
        {
            return DAL_NhanVien.ThemNhanvien(nhanvien);
        }
        public static string SinhMaNV()
        {
            return DAL_NhanVien.SinhMaNV();
        }
        public DataTable laydl()
        {
            return dal_NV.Get();
        }
        public bool themdl(DTO_NhanVien nv)
        {
            try
            {
                if (nv.Tennv != "" && nv.Gioitinh != null && nv.Ngaysinh != null && nv.Email != null && nv.Dienthoai != null && nv.Diachi != "")
                {
                    dal_NV.Insert(nv);
                    return true;
                }
                else return false;
            }
            catch
            { return false; }
        }
        public bool suadl(DTO_NhanVien nv)
        {
            try
            {
                if (nv.Tennv != "" && nv.Gioitinh != null && nv.Ngaysinh != null && nv.Email != null && nv.Dienthoai != null && nv.Diachi != "" && nv.Manv != "")
                {
                    dal_NV.Update(nv);
                    return true;
                }
                else return false;
            }
            catch
            { return false; }
        }
        public bool xoadl(string ma)
        {
            try
            {
                if (ma != "")
                {
                    dal_NV.Delete(ma);
                    return true;
                }
                else return false;
            }
            catch
            { return false; }
        }
        public DataTable thongtinnv(string ma)
        {
            return dal_NV.Get_NV(ma);
        }
        public DataTable timhdban(string ma)
        {
            return dal_NV.searchHDban(ma);
        }
        public DataTable timhdnhap(string ma)
        {
            return dal_NV.searchHDnhap(ma);
        }
        public DataTable timnv(string ma)
        {
            return dal_NV.searchNV(ma);
        }
        public static List<DTO_NhanVien> LoadNV()
        {
            return DAL_NhanVien.LoadNV();
        }
          #endregion
        public static bool KiemTraDangNhap(string _username, string _password)
        {

            if (_username == "" || _password == "")
            {
                return false;
            }
            List<DTO_NhanVien> lstAdmin = DAL_NhanVien.LoadNV();
            foreach (DTO_NhanVien item in lstAdmin)
            {
                if (_username == item.Taikhoan && _password == item.Matkhau)
                {
                    return true;
                }
            }
            return false;
        }
        static string user = "";
        public static void LuuThongTinDangNhap(string _user)
        {
            user = _user;
        }
        public static string LayThongTinDangNhap()
        {
            return user;
        }
        DAL_NhanVien dl_xl = new DAL_NhanVien();
        public DataTable Getlogin(string m)
        {
            return dl_xl.Getlogin(m);
        }
        public static List<DTO_PhanQuyen> Loadquyen()
        {
            return DAL_NhanVien.Loadquyen();
        }
        public static bool DoiMatKhau(string _username, string _password)
        {

            if (_username == "" || _password == "")
            {
                return false;
            }
            DTO_NhanVien login = new DTO_NhanVien();
            login.Taikhoan = _username;
            login.Matkhau = _password;
            if (DAL_NhanVien.UpdateMK(login) == true)
            {
                return true;
            }
            return false;
        }
    }
}
