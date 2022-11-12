using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_BieuDo
    {
        static SqlConnection connect;
        public DataTable BieudoNhanVien()
        {
            string lenh = @"SELECT Nhan_vien.ma_nv, Nhan_vien.ten_nv, Count([Hoa_Don].[ma_hd]) AS Expr1
                            FROM Nhan_vien INNER JOIN Hoa_Don ON Nhan_vien.ma_nv = Hoa_Don.ma_nv
                            group by Nhan_vien.ma_nv, Nhan_vien.ten_nv";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable BieudoSanPham()
        {
            string lenh = @"SELECT San_Pham.ma_sp, San_Pham.ten_sp, (Ct_Hoa_Don_Nhap.so_luong-Ct_Hoa_Don.so_luong) as conlai
FROM (San_Pham INNER JOIN Ct_Hoa_Don ON San_Pham.ma_sp = Ct_Hoa_Don.ma_sp) INNER JOIN Ct_Hoa_Don_Nhap ON San_Pham.ma_sp = Ct_Hoa_Don_Nhap.ma_sp;";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable BieudoLoaiSanPham()
        {
            string lenh = @"SELECT Loai_San_Pham.ma_loai, Loai_San_Pham.ten_loai, count(San_Pham.ma_sp)
FROM Loai_San_Pham INNER JOIN San_Pham ON Loai_San_Pham.ma_loai = San_Pham.ma_loai
group by Loai_San_Pham.ma_loai, Loai_San_Pham.ten_loai;";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable BieudoNhanHieu()
        {
            string lenh = @"SELECT Nhan_Hieu.ma_hieu, Nhan_Hieu.ten_hieu, Count(San_Pham.ma_sp) AS CountOfma_sp
FROM Nhan_Hieu INNER JOIN San_Pham ON Nhan_Hieu.ma_hieu = San_Pham.ma_hieu
GROUP BY Nhan_Hieu.ma_hieu, Nhan_Hieu.ten_hieu;";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable BieudoNCC()
        {
            string lenh = @"SELECT Nha_Cung_Cap.ma_ncc, Nha_Cung_Cap.ten_ncc, count(Hoa_Don_Nhap.ma_hdn), sum(Ct_Hoa_Don_Nhap.so_luong)
FROM (Nha_Cung_Cap INNER JOIN Hoa_Don_Nhap ON Nha_Cung_Cap.ma_ncc = Hoa_Don_Nhap.ma_ncc) INNER JOIN Ct_Hoa_Don_Nhap ON Hoa_Don_Nhap.ma_hdn = Ct_Hoa_Don_Nhap.ma_hdn
group by Nha_Cung_Cap.ma_ncc, Nha_Cung_Cap.ten_ncc;";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
    }
}
