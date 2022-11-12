using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string tenkh;

        public string Tenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private DateTime ngaysinh;

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private string dienthoai;

        public string Dienthoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
