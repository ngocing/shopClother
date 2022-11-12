using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_XemLoiNhuan
    {
        DAL_XemLoiNhuan dal_dt = new DAL_XemLoiNhuan();
        public DataTable laydl()
        {
            return dal_dt.Get();
        }
        public DataTable hienthiDT()
        {
            return dal_dt.LoadCmb();
        }
        public DataTable layngay(DateTime ngay)
        {
            return dal_dt.GetDay(ngay);
        }
        public DataTable laythang(string thang, string nam)
        {
            return dal_dt.GetMonth(thang, nam);
        }
        public DataTable laynam(string nam)
        {
            return dal_dt.GetYear(nam);
        }
    }
}
