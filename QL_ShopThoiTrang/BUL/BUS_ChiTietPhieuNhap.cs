using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_ChiTietPhieuNhap
    {
        public static bool ThemCTHoaDon(DTO_ChiTietPhieuNhap hoadon)
        {
            return DAL_ChiTietPhieuNhap.ThemCTHoaDon(hoadon);
        }
        DAL_ChiTietPhieuNhap dal_ct = new DAL_ChiTietPhieuNhap();
        public DataTable lay(string ma)
        {
            return dal_ct.Get(ma);
        }
    }
}
