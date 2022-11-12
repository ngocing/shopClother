using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_LoaiSanPham
    {
        private string maloai;

        public string Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        }
        private string tenloai;

        public string Tenloai
        {
            get { return tenloai; }
            set { tenloai = value; }
        }
        private string mota;

        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }
        private string hinh;

        public string Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }
        private string maloaicha;

        public string Maloaicha
        {
            get { return maloaicha; }
            set { maloaicha = value; }
        }
        public DTO_LoaiSanPham()
        {
        }
        public DTO_LoaiSanPham(string _maloai, string _tenloai, string _mota, string _hinh, string _maloaicha)
        {
            this.maloai = _maloai;
            this.tenloai = _tenloai;
            this.mota = _mota;
            this.hinh = _hinh;
            this.maloaicha = _maloaicha;
        }
    }
}
