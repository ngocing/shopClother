using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_LoaiSanPham
    {
        public static DataTable LayDatatable(string macha)
        {
            return DAL_LoaiSanPham.LayDatatable(macha);
        }
        public static string SinhMaLSP()
        {
            return DAL_LoaiSanPham.SinhMaSP();
        }
        DAL_LoaiSanPham dal_lsp = new DAL_LoaiSanPham();
        public DataTable laydl()
        {
            return dal_lsp.Get();
        }
        public DataTable hienthicmb()
        {
            return dal_lsp.LoadComBoBox();
        }
        public bool themdl(DTO_LoaiSanPham plsp)
        {
            try
            {
                if (plsp.Tenloai != "" && plsp.Mota != null & plsp.Maloaicha != "" && plsp.Hinh != null)
                {
                    dal_lsp.Insert(plsp);
                    return true;
                }
                else return false;
            }
            catch
            { return false; }
        }
        public bool suadl(DTO_LoaiSanPham plsp)
        {
            try
            {
                if (plsp.Tenloai != "" && plsp.Mota != null && plsp.Maloaicha != "" && plsp.Hinh != null && plsp.Maloai != "")
                {
                    dal_lsp.Update(plsp);
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
                    dal_lsp.Delete(ma);
                    return true;
                }
                else return false;
            }
            catch
            { return false; }
        }
    }
}
