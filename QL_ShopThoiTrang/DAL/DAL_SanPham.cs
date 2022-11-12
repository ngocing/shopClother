using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_SanPham
    {
        static SqlConnection connect;
        public static List<DTO_SanPham> LayListSP()
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM San_Pham ";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            if (data.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_SanPham> lstsanpham = new List<DTO_SanPham>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DTO_SanPham sanpham = new DTO_SanPham();
                sanpham.Masp = data.Rows[i]["ma_sp"].ToString();
                sanpham.Tensp = data.Rows[i]["ten_sp"].ToString();
                sanpham.Maloai = data.Rows[0]["ma_loai"].ToString();
                sanpham.Mota = data.Rows[0]["mo_ta"].ToString();
                sanpham.Dongia = decimal.Parse(data.Rows[0]["don_gia"].ToString());
                sanpham.Hinh = data.Rows[0]["hinh"].ToString();
                sanpham.Ngaycapnhat =DateTime.Parse(data.Rows[0]["ngay_cap_nhat"].ToString());
                sanpham.Mahieu = data.Rows[0]["ma_hieu"].ToString();
                lstsanpham.Add(sanpham);
            }
            DataProvider.DongKetNoi(connect);
            return lstsanpham;

        }
        public static List<DTO_SanPham> LayDatatable()
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM San_Pham ";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            List<DTO_SanPham> lstsanpham = new List<DTO_SanPham>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DTO_SanPham sanpham = new DTO_SanPham();
                sanpham.Masp = data.Rows[i]["ma_sp"].ToString();
                sanpham.Tensp = data.Rows[i]["ten_sp"].ToString();
                sanpham.Mota = data.Rows[i]["mo_ta"].ToString();
                sanpham.Dongia = decimal.Parse(data.Rows[i]["don_gia"].ToString());
                sanpham.Loinhuan = decimal.Parse(data.Rows[i]["loi_nhuan"].ToString());
                lstsanpham.Add(sanpham);
            }
            DataProvider.DongKetNoi(connect);
            return lstsanpham;
        }
        public static List<DTO_SanPham> LayDatatabletheoMaLoai(string maloai)
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM San_Pham where ma_loai = '" + maloai +"'";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            List<DTO_SanPham> lstsanpham = new List<DTO_SanPham>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DTO_SanPham sanpham = new DTO_SanPham();
                sanpham.Masp = data.Rows[i]["ma_sp"].ToString();
                sanpham.Tensp = data.Rows[i]["ten_sp"].ToString();
                sanpham.Mota = data.Rows[i]["mo_ta"].ToString();
                sanpham.Dongia = decimal.Parse(data.Rows[i]["don_gia"].ToString());
                sanpham.Loinhuan = decimal.Parse(data.Rows[i]["loi_nhuan"].ToString());
                lstsanpham.Add(sanpham);
            }
            DataProvider.DongKetNoi(connect);
            return lstsanpham;
        }
        public static List<DTO_SanPham> LayDatatabletheoMaCha(string macha)
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT San_Pham.*
                                    FROM (Loai_cha INNER JOIN Loai_San_Pham ON Loai_cha.ma_loai_cha = Loai_San_Pham.ma_loai_cha) INNER JOIN San_Pham ON Loai_San_Pham.ma_loai = San_Pham.ma_loai
                                    where Loai_cha.ma_loai_cha = '" + macha + "'";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            List<DTO_SanPham> lstsanpham = new List<DTO_SanPham>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DTO_SanPham sanpham = new DTO_SanPham();
                sanpham.Masp = data.Rows[i]["ma_sp"].ToString();
                sanpham.Tensp = data.Rows[i]["ten_sp"].ToString();
                sanpham.Mota = data.Rows[i]["mo_ta"].ToString();
                sanpham.Dongia = decimal.Parse(data.Rows[i]["don_gia"].ToString());
                sanpham.Loinhuan = decimal.Parse(data.Rows[i]["loi_nhuan"].ToString());
                lstsanpham.Add(sanpham);
            }
            DataProvider.DongKetNoi(connect);
            return lstsanpham;
        }
        public static List<DTO_SanPham> LayDatatabletheoMaHieu(string mahieu)
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM San_Pham where ma_hieu ='" + mahieu+"'";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            List<DTO_SanPham> lstsanpham = new List<DTO_SanPham>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DTO_SanPham sanpham = new DTO_SanPham();
                sanpham.Masp = data.Rows[i]["ma_sp"].ToString();
                sanpham.Tensp = data.Rows[i]["ten_sp"].ToString();
                sanpham.Mota = data.Rows[i]["mo_ta"].ToString();
                sanpham.Dongia = decimal.Parse(data.Rows[i]["don_gia"].ToString());
                sanpham.Loinhuan = decimal.Parse(data.Rows[i]["loi_nhuan"].ToString());
                lstsanpham.Add(sanpham);
            }
            DataProvider.DongKetNoi(connect);
            return lstsanpham;
        }
        public static List<DTO_SanPham> LayDatatabletheoMaSP(string masp)
        {
            // Khai báo lệnh truy vấn SQL
            string caulenhtruyvan = @"SELECT * FROM San_Pham where ma_sp = '" + masp +"'";
            // Mở kết nối
            connect = DataProvider.KetNoi();
            // Thực thi câu truy vấn
            DataTable data = DataProvider.LayDatatable(caulenhtruyvan, connect);
            List<DTO_SanPham> lstsanpham = new List<DTO_SanPham>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DTO_SanPham sanpham = new DTO_SanPham();
                sanpham.Masp = data.Rows[i]["ma_sp"].ToString();
                sanpham.Tensp = data.Rows[i]["ten_sp"].ToString();
                sanpham.Mota = data.Rows[0]["mo_ta"].ToString();
                sanpham.Dongia = decimal.Parse(data.Rows[0]["don_gia"].ToString());
                sanpham.Loinhuan = decimal.Parse(data.Rows[0]["loi_nhuan"].ToString());
                lstsanpham.Add(sanpham);
            }
            DataProvider.DongKetNoi(connect);
            return lstsanpham;
        }
        public static string SinhMaSP()
        {
            return DataProvider.MaKeTiep(DataProvider.LayMaCuoi("San_Pham", "ma_sp"), "SP");
        }
        public DataTable Get()
        {
            string lenh = @"SELECT Loai_San_Pham.ten_loai, Nhan_Hieu.ten_hieu,  San_Pham.ma_sp, San_Pham.ngay_cap_nhat, 
                          San_Pham.don_gia,San_Pham.loi_nhuan, San_Pham.mo_ta, San_Pham.ten_sp,San_Pham.hinh FROM            
                          ((Loai_San_Pham INNER JOIN
                         San_Pham ON Loai_San_Pham.ma_loai = San_Pham.ma_loai) INNER JOIN
                         Nhan_Hieu ON San_Pham.ma_hieu = Nhan_Hieu.ma_hieu)";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable GetTK()
        {
            string lenh = @"SELECT San_Pham.ma_sp,San_Pham.ten_sp, Loai_San_Pham.ten_loai, Nhan_Hieu.ten_hieu,
                          San_Pham.don_gia FROM            
                          ((Loai_San_Pham INNER JOIN
                         San_Pham ON Loai_San_Pham.ma_loai = San_Pham.ma_loai) INNER JOIN
                         Nhan_Hieu ON San_Pham.ma_hieu = Nhan_Hieu.ma_hieu)";
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            DataColumn nhap = new DataColumn("nhap");
            DataColumn ban = new DataColumn("ban", typeof(decimal));
            DataColumn ton = new DataColumn("ton");
            dt.Columns.Add(ban);
            dt.Columns.Add(nhap);
            dt.Columns.Add(ton);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string tam1 = sumNhap(dt.Rows[i]["ma_sp"].ToString()).ToString();
                string tam2 = sumBan(dt.Rows[i]["ma_sp"].ToString()).ToString();
                long soluongton = 0;
                long slnhap, xuat;
                if (tam1 == null || tam1 == "")
                {
                    slnhap = 0;
                }
                else
                {
                    slnhap = long.Parse(tam1);
                }
                if (tam2 == null || tam2 == "")
                {
                    xuat = 0;
                }
                else
                {
                    xuat = long.Parse(tam2);
                }
                soluongton = slnhap - xuat;
                dt.Rows[i]["nhap"] = slnhap;
                dt.Rows[i]["ban"] = xuat;
                dt.Rows[i]["ton"] = soluongton;
            }
            return dt;
        }
        public DataTable Get(string ma)
        {
            string lenh = string.Format(@"SELECT Loai_San_Pham.ten_loai, Nhan_Hieu.ten_hieu,  San_Pham.ma_sp, San_Pham.ngay_cap_nhat, 
                          San_Pham.don_gia, San_Pham.mo_ta, San_Pham.ten_sp,San_Pham.hinh FROM            
                          ((Loai_San_Pham INNER JOIN
                         San_Pham ON Loai_San_Pham.ma_loai = San_Pham.ma_loai) INNER JOIN
                         Nhan_Hieu ON San_Pham.ma_hieu = Nhan_Hieu.ma_hieu) where San_Pham.ma_sp='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public void Insert(DTO_SanPham sp)
        {
            string lenh = string.Format(@"insert into San_Pham (ma_sp, ten_sp, ma_loai, mo_ta, don_gia,hinh,ngay_cap_nhat,ma_hieu,loi_nhuan) 
                                        values(N'{0}',N'{1}',N'{2}',N'{3}',{4},N'{5}',N'{6}',N'{7}',{8})", 
                                        sp.Masp, sp.Tensp, sp.Maloai, sp.Mota, sp.Dongia, sp.Hinh, sp.Ngaycapnhat, sp.Mahieu,sp.Loinhuan);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        public void Update(DTO_SanPham sp)
        {
            string lenh = string.Format(@"update San_Pham set ten_sp=N'{0}', ma_loai=N'{1}', mo_ta=N'{2}', don_gia={3},hinh=N'{4}',ngay_cap_nhat=N'{5}',ma_hieu=N'{6}',loi_nhuan={7} where ma_sp=N'{8}'",
                                    sp.Tensp, sp.Maloai, sp.Mota, sp.Dongia, sp.Hinh, sp.Ngaycapnhat, sp.Mahieu,sp.Loinhuan, sp.Masp);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        public void Delete(string ma)
        {

            string lenh = string.Format("delete from San_Pham where ma_sp='{0}'", ma);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
        public DataTable LoadCmbLSP()
        {
            connect = DataProvider.KetNoi();
            string lenh = "select *  from Loai_San_Pham";
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public DataTable LoadCmbHieu()
        {
            connect = DataProvider.KetNoi();
            string lenh = "select *  from Nhan_Hieu";
            DataTable dt = DataProvider.LayDatatable(lenh, connect);
            return dt;
        }
        public object sumNhap(string ma)
        {
            string lenh = string.Format("select SUM(so_luong) from Ct_Hoa_Don_Nhap where ma_sp='{0}'", ma);
            connect = DataProvider.KetNoi();
            return DataProvider.LayGiaTri(lenh, connect);
            // connect.Close();
        }
        public object sumBan(string ma)
        {
            string lenh = string.Format("select SUM(so_luong) from Ct_Hoa_Don where ma_sp='{0}'", ma);
            connect = DataProvider.KetNoi();
            return DataProvider.LayGiaTri(lenh, connect);
            // connect.Close();
        }
        public static void UpdateGia(DTO_SanPham sp)
        {
            string lenh = string.Format(@"update San_Pham set don_gia={0} where ma_sp=N'{1}'",sp.Dongia, sp.Masp);
            connect = DataProvider.KetNoi();
            DataProvider.CauLenhNonQuery(lenh, connect);
            connect.Close();
        }
    }
}
