using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_NhaCungCap
    {
        public static List<DTO_NhaCungCap> LoadNCC()
        {
            return DAL_NhaCungCap.LoadNCC();
        }
        public static bool Them(DTO_NhaCungCap ncc)
        {
            if (ncc.Mancc == "" ||ncc.Tenncc==""||ncc.Diachi==""||ncc.Dienthoai==""|| ncc.Mancc == null)
            {
                return false;
            }
            return DAL_NhaCungCap.Them(ncc);
        }
        public static bool Sua(DTO_NhaCungCap ncc)
        {
            if (ncc.Mancc == "" || ncc.Tenncc == "" || ncc.Diachi == "" || ncc.Dienthoai == "" || ncc.Mancc == null)
            {
                return false;
            }
            return DAL_NhaCungCap.Sua(ncc);
        }
        public static bool Xoa(DTO_NhaCungCap ncc)
        {
            if (ncc.Mancc=="" || ncc.Mancc==null)
            {
                return false;
            }
            return DAL_NhaCungCap.Xoa(ncc);
        }
        public static string SinhMaNCC()
        {
            return DAL_NhaCungCap.SinhMaNCC();
        }
    }
}
