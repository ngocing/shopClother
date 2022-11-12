using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_ChiTietHoaDon
    {
        private string mahd;

        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        private string masp;

        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private decimal dongia;

        public decimal Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }

    }
}
