using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_SanPham
    {
        private string masp;

        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        private string tensp;

        public string Tensp
        {
            get { return tensp; }
            set { tensp = value; }
        }
        private string maloai;

        public string Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        }
        private string mota;

        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }
        private decimal dongia;

        public decimal Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        private decimal loinhuan;

        public decimal Loinhuan
        {
            get { return loinhuan; }
            set { loinhuan = value; }
        }

        private string hinh;

        public string Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }
        private DateTime ngaycapnhat;

        public DateTime Ngaycapnhat
        {
            get { return ngaycapnhat; }
            set { ngaycapnhat = value; }
        }
        private string mahieu;

        public string Mahieu
        {
            get { return mahieu; }
            set { mahieu = value; }
        }
        public DTO_SanPham()
        {
        }
        public DTO_SanPham(string _masp,decimal _Dongia)
        {
            this.Masp = _masp;
            this.Dongia = _Dongia;
        }
    }
}
