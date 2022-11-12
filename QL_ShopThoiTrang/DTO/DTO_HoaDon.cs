using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_HoaDon
    {
        private string mahd;

        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private decimal tri_gia;

        public decimal Tri_gia
        {
            get { return tri_gia; }
            set { tri_gia = value; }
        }
        private DateTime ngaylap;

        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
    }
}
