using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;

namespace BUS
{
   public class BUS_XemNhanVien
    {
       DAL_XemNhanVien dal_dt = new DAL_XemNhanVien();
        public DataTable laydl()
        {
            return dal_dt.Get();
        }
        #region Nhân Viên bán hàng
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
#endregion
        #region Nhân Viên bán hàng nhiều nhất
        public DataTable layngay_NN(DateTime ngay)
        {
            return dal_dt.GetDay_NN(ngay);
        }
        public DataTable laythang_NN(string thang, string nam)
        {
            return dal_dt.GetMonth_NN(thang, nam);
        }
        public DataTable laynam_NN(string nam)
        {
            return dal_dt.GetYear_NN(nam);
        }
        #endregion
        #region Nhân Viên bán không được hàng
        public DataTable layngay_KBD(DateTime ngay)
        {
            return dal_dt.GetDay_KBD(ngay);
        }
        public DataTable laythang_KBD(string thang, string nam)
        {
            return dal_dt.GetMonth_KBD(thang, nam);
        }
        public DataTable laynam_KBD(string nam)
        {
            return dal_dt.GetYear_KBD(nam);
        }
        #endregion
  
   }
}
