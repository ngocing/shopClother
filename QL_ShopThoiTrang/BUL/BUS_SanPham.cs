using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
    public class BUS_SanPham
    {
        public static List<DTO_SanPham> LayListSP()
        {
            return DAL_SanPham.LayListSP();
        }
        public static List<DTO_SanPham> LayDatatable()
        {
            return DAL_SanPham.LayDatatable();
        }
        public static List<DTO_SanPham> LayDatatableTheoMaLoai(string maloai)
        {
            return DAL_SanPham.LayDatatabletheoMaLoai(maloai);
        }
        public static List<DTO_SanPham> LayDatatableTheoMaCha(string macha)
        {
            return DAL_SanPham.LayDatatabletheoMaCha(macha);
        }
        public static List<DTO_SanPham> LayDatatableTheoMaHieu(string mahieu)
        {
            return DAL_SanPham.LayDatatabletheoMaHieu(mahieu);
        }
        public static List<DTO_SanPham> LayDatatableTheoMaSP(string masp)
        {
            return DAL_SanPham.LayDatatabletheoMaSP(masp);
        }
        public static string SinhMaSP()
        {
            return DAL_SanPham.SinhMaSP();
        }
        DAL_SanPham dal_sp = new DAL_SanPham();
        public DataTable laydl()
        {
            return dal_sp.Get();
        }
        public DataTable laydltk()
        {
            return dal_sp.GetTK();
        }
        public DataTable laydl(string ma)
        {
            return dal_sp.Get(ma);
        }

        public DataTable hienthiLoai()
        {
            return dal_sp.LoadCmbLSP();
        }
        public DataTable hienthiHieu()
        {
            return dal_sp.LoadCmbHieu();
        }
        public bool themdl(DTO_SanPham sp)
        {
            try
            {
                if (sp.Tensp != "" && sp.Maloai != null && sp.Mota != null && sp.Dongia.ToString()!="" && sp.Hinh != null && sp.Mahieu != null && sp.Ngaycapnhat != null && sp.Loinhuan.ToString()!="")
                {
                    dal_sp.Insert(sp);
                    return true;
                }
                else return false;
            }
            catch
            { return false; }
        }
        public bool suadl(DTO_SanPham sp)
        {
            try
            {
                if (sp.Tensp != "" && sp.Maloai != null && sp.Mota != null && sp.Dongia.ToString() != "" && sp.Hinh != null && sp.Ngaycapnhat != null && sp.Mahieu != null && sp.Masp != "" && sp.Loinhuan.ToString() != "")
                {
                    dal_sp.Update(sp);
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
                    dal_sp.Delete(ma);
                    return true;
                }
                else return false;
            }
            catch
            { return false; }
        }
        public object tongSLnhap(string ma)
        {
            return dal_sp.sumNhap(ma);
        }

        public object tongSLban(string ma)
        {
            return dal_sp.sumBan(ma);
        }
        public static bool UpdateDonGia(DTO_SanPham sp)
        {
            try
            {
                DAL_SanPham.UpdateGia(sp);
                return true;
            }
            catch
            { return false; }
        }
    }
}
