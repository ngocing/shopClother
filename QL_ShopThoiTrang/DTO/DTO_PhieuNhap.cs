using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_PhieuNhap
    {
        private string mahdn;

        public string Mahdn
        {
            get { return mahdn; }
            set { mahdn = value; }
        }
        private string mancc;

        public string Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private DateTime ngaynhap;

        public DateTime Ngaynhap
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }
        private decimal giatri;

        public decimal Giatri
        {
            get { return giatri; }
            set { giatri = value; }
        }
    }
}
