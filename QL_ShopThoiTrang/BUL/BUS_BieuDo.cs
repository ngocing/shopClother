using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_BieuDo
    {
        DAL_BieuDo bieudo = new DAL_BieuDo();
        public DataTable BieudoNhanVien()
        {
            return bieudo.BieudoNhanVien();
        }
        public DataTable BieudoSanPham()
        {
            return bieudo.BieudoSanPham();
        }
        public DataTable BieudoLoaiSanPham()
        {
            return bieudo.BieudoLoaiSanPham();
        }
        public DataTable BieudoNhanHieu()
        {
            return bieudo.BieudoNhanHieu();
        }
        public DataTable BieudoNCC()
        {
            return bieudo.BieudoNCC();
        }
    }
}
