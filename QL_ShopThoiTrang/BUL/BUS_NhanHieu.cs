using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_NhanHieu
    {
        public static DataTable LayDatatable()
        {
            return DAL_NhanHieu.LayDatatable();
        }
        public static List<DTO_NhanHieu> Loadnh()
        {
            return DAL_NhanHieu.Load();
        }
        public static bool Them(DTO_NhanHieu nh)
        {
            if (nh.Manhanhieu == "" || nh.Manhanhieu == null)
            {
                return false;
            }
            return DAL_NhanHieu.Them(nh);
        }
        public static bool Sua(DTO_NhanHieu nh)
        {
            if (nh.Manhanhieu == "" || nh.Manhanhieu == null||nh.Tennhanhieu=="")
            {
                return false;
            }
            return DAL_NhanHieu.Sua(nh);
        }
        public static bool Xoa(DTO_NhanHieu nh)
        {
            if (nh.Manhanhieu == "" || nh.Manhanhieu == null||nh.Tennhanhieu=="")
            {
                return false;
            }
            return DAL_NhanHieu.Xoa(nh);
        }
        public static string SinhMaNH()
        {
            return DAL_NhanHieu.SinhMaNH();
        }
    }
}
