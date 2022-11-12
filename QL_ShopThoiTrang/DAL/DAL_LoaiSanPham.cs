using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_LoaiSanPham
    {
        static SqlConnection connect;
        public static DataTable LayDatatable(string macha)
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM Loai_San_Pham where ma_loai_cha ='" + macha+"'";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            DataProvider.DongKetNoi(connect);
            return data;

        }
        public static string SinhMaSP()
        {
            return DataProvider.MaKeTiep(DataProvider.LayMaCuoi("Loai_San_Pham", "ma_loai"), "LSP");
        }
        public DataTable Get()
        {
            string lenh = "select * from Loai_San_Pham";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public void Insert(DTO_LoaiSanPham plsp)
        {
            string lenh = string.Format(@"insert into Loai_San_Pham (ma_loai,ten_loai,mo_ta,hinh,ma_loai_cha) 
                                    values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",plsp.Maloai, plsp.Tenloai, plsp.Mota, plsp.Hinh, plsp.Maloaicha);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        //lệnh update sửa đổi dữ liệu
        public void Update(DTO_LoaiSanPham plsp)
        {
            string lenh = string.Format("update Loai_San_Pham set ten_loai=N'{0}', mo_ta=N'{1}', hinh=N'{2}', ma_loai_cha=N'{3}' where ma_loai=N'{4}'", plsp.Tenloai, plsp.Mota, plsp.Hinh, plsp.Maloaicha, plsp.Maloai);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        //lệnh delete xóa dữ liệu
        public void Delete(string ma)
        {

            string lenh = string.Format("delete from Loai_San_Pham where ma_loai='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        public DataTable LoadComBoBox()
        {
            connect = DataProvider.KetNoi();
            string lenh = "select *  from Loai_Cha";
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;

        }
    }
}
