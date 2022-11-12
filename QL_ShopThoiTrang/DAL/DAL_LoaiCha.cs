using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_LoaiCha
    {
        static SqlConnection connect;
        public static List<DTO_LoaiCha> LayLoaiCha()
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM Loai_cha ";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            if (data.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_LoaiCha> lstLoaiCha = new List<DTO_LoaiCha>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DTO_LoaiCha loaicha = new DTO_LoaiCha();
                loaicha.Maloaicha = data.Rows[i]["ma_loai_cha"].ToString();
                loaicha.Tenloaicha = data.Rows[i]["ten_loai_cha"].ToString();
                loaicha.Mota = data.Rows[0]["mo_ta"].ToString();
                lstLoaiCha.Add(loaicha);
            }
            DataProvider.DongKetNoi(connect);
            return lstLoaiCha;

        }
        public static DataTable LayDatatable()
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM Loai_cha ";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            DataProvider.DongKetNoi(connect);
            return data;

        }
        public static string SinhMaLC()
        {
            return DataProvider.MaKeTiep(DataProvider.LayMaCuoi("Loai_cha", "ma_loai_cha"), "LC");
        }
        public DataTable Get()
        {
            string lenh = "select * from Loai_cha";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public void Insert(DTO_LoaiCha lc)
        {
            string lenh = string.Format("insert into Loai_cha (ma_loai_cha,ten_loai_cha,mo_ta) values(N'{0}',N'{1}',N'{2}')",lc.Maloaicha, lc.Tenloaicha, lc.Mota);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        //lệnh update sửa đổi dữ liệu
        public void Update(DTO_LoaiCha lc)
        {
            string lenh = string.Format("update Loai_cha set ten_loai_cha=N'{0}', mo_ta=N'{1}' where ma_loai_cha=N'{2}'", lc.Tenloaicha, lc.Mota, lc.Maloaicha);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        //lệnh delete xóa dữ liệu
        public void Delete(string ma)
        {

            string lenh = string.Format("delete from Loai_cha where ma_loai_cha='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
    }
}
