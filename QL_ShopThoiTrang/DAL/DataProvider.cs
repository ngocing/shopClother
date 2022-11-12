using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DTO
{
    public class DataProvider
    {
        //Hàm kết nối
        public static SqlConnection KetNoi()
        {
            string chuoiKN = "Data Source=MSI\\HUFN;Initial Catalog=QlyShopQA;Integrated Security=True";
            string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

            //string chuoiKN = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='"+paths+"\\QLyShop.mdb'";
            SqlConnection connect = new SqlConnection(chuoiKN);
            connect.Open();
            return connect;
        }
        //Hàm đóng kết nối
        public static void DongKetNoi(SqlConnection connect)
        {
            connect.Close();
        }
        //Hàm lấy datatable
        public static DataTable LayDatatable(string cauLanhTruyVan, SqlConnection connect)
        {
            SqlDataAdapter adap = new SqlDataAdapter(cauLanhTruyVan, connect);
            DataTable data = new DataTable();
            adap.Fill(data);
            return data;
        }

        // Thực thi câu lệnh nonQuery
        public static void CauLenhNonQuery(string cauLanhTruyVan, SqlConnection connect)
        {
            SqlCommand command = new SqlCommand(cauLanhTruyVan, connect);
            command.ExecuteNonQuery();
        }
        //Lấy mã cuối cùng và sinh mã kế tiếp.
        public static string LayMaCuoi(string Bang, string Cot)
        {
            SqlConnection con = KetNoi();
            try
            {
                string sql = "Select Top 1 " + Cot + " from " + Bang + " Order By " + Cot + " DESC";
                DataTable datatable = LayDatatable(sql, con);
                DongKetNoi(con);
                return datatable.Rows[0][Cot].ToString();
            }
            catch (Exception)
            {
                return Bang.ToString();
            }
        }
        public static string MaKeTiep(string macuoi, string tiento)
        {
            try
            {
                int maketiep = int.Parse(macuoi.Remove(0, tiento.Length)) + 1;
                int lengthNumerID = macuoi.Length - tiento.Length;
                string zeroNumber = "";
                for (int i = 1; i < lengthNumerID; i++)
                {
                    if (maketiep < Math.Pow(10, i))
                    {
                        //for (int j = 1; j <= lengthNumerID - i - 3; i++)
                        //{
                        zeroNumber += "0";
                        //}
                        //return tiento + zeroNumber + maketiep.ToString();
                    }
                }
                return tiento + zeroNumber + maketiep.ToString();
            }
            catch (Exception)
            {
                return tiento + "001";
            }
        }
        // sinh mã
        public string SinhMa(string _table, string _colMa, string _tiento)
        {
            return MaKeTiep(LayMaCuoi(_table, _colMa), _tiento);
        }
        public static object LayGiaTri(string cauLanhTruyVan, SqlConnection connect)
        {
            object kq = null;
            //tạo kết nối 
            SqlCommand cmd = new SqlCommand(cauLanhTruyVan, connect);

            //thực hiện lệnh 
            kq = cmd.ExecuteScalar();
            connect.Close();
            return kq;
        }
    }
}
