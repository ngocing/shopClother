using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
    public class BUS_LoaiCha
    {
        public static List<DTO_LoaiCha> LayLoaiCha()
        {
            return DAL_LoaiCha.LayLoaiCha();
        }
        public static DataTable LayDatatable()
        {
            return DAL_LoaiCha.LayDatatable();
        }
        public static string SinhMaLC()
        {
            return DAL_LoaiCha.SinhMaLC();
        }
        DAL_LoaiCha dal_lc = new DAL_LoaiCha();
        public DataTable laydl()
        {
            return dal_lc.Get();
        }
        public bool themdl(DTO_LoaiCha lc)
        {
            try
            {
                if (lc.Tenloaicha != "" && lc.Mota != null)
                {
                    dal_lc.Insert(lc);
                    return true;
                }
                else return false;
            }
            catch
            { return false; }
        }
        public bool suadl(DTO_LoaiCha lc)
        {
            try
            {
                if (lc.Tenloaicha != "" && lc.Mota != null && lc.Maloaicha != "")
                {
                    dal_lc.Update(lc);
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
                    dal_lc.Delete(ma);
                    return true;
                }
                else return false;
            }
            catch
            { return false; }
        }
    }
}
