using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Windows.Forms;
using System.Data;
namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dal_kh = new DAL_KhachHang();
        public static void SinhKH(string _maKH)
        {
            DTO_KhachHang khachhang = new DTO_KhachHang();
            khachhang.Makh = _maKH;
            khachhang.Tenkh = "Chua xac dinh";
            khachhang.Gioitinh = "Chua xac dinh";
            khachhang.Diachi = "Chua xac dinh";
            khachhang.Dienthoai = "Chua xac dinh";
            khachhang.Email = "Chua xac dinh";
            khachhang.Ngaysinh = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
            try
            {
                ThemKhachHang(khachhang);
                    //MessageBox.Show("ok kh");

            }
            catch (Exception)
            {
                
            }
        }
        public static bool ThemKhachHang(DTO_KhachHang khachhang)
        {
            return DAL_KhachHang.ThemKhachHang(khachhang);
        }
        public static string SinhMaKH()
        {
            return DAL_KhachHang.SinhMaKH();
        }
        public DataTable laydl()
        {
            return dal_kh.Get();
        }
        public bool themdl(DTO_KhachHang kh)
        {
            try
            {
                if (kh.Tenkh!="" &&kh.Gioitinh!=null&&kh.Ngaysinh!=null&&kh.Email!=null&&kh.Dienthoai!=null&&kh.Diachi!="")
                {
                    dal_kh.Insert(kh);
                    return true;
                }
                else return false;
            }
            catch
            { return false; }
        }
        public bool suadl(DTO_KhachHang kh)
        {
            try
            {
                if (kh.Tenkh != "" && kh.Gioitinh != null && kh.Ngaysinh != null && kh.Email != null && kh.Dienthoai != null && kh.Diachi != ""&&kh.Makh!="")
                {
                    dal_kh.Update(kh);
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
                    dal_kh.Delete(ma);
                    return true;
                }
                else return false;
            }
            catch
            { return false; }
        }
        public DataTable timhd(string ma)
        {
            return dal_kh.searchHD(ma);
        }
        public DataTable timkh(string ma)
        {
            return dal_kh.searchKH(ma);
        }
        public static List<DTO_KhachHang> LoadKH()
        {
            return DAL_KhachHang.LoadKH();
        }
    }
}
