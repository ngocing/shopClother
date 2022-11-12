using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_XemLoiNhuan
    {
        private string _masp;

        public string Masp
        {
            get { return _masp; }
            set { _masp = value; }
        }
        private string _tensp;

        public string Tensp
        {
            get { return _tensp; }
            set { _tensp = value; }
        }
        private string _ngaylap;

        public string Ngaylap
        {
            get { return _ngaylap; }
            set { _ngaylap = value; }
        }
        private string _loinhuan;

        public string Loinhuan
        {
            get { return _loinhuan; }
            set { _loinhuan = value; }
        }
        public DTO_XemLoiNhuan()
        { }
        public DTO_XemLoiNhuan(string pma, string pten, string pngay, string ptrigia)
        {
            this._masp = pma;
            this._tensp = pten;
            this._ngaylap = pngay;
            this._loinhuan = ptrigia;
        }
    }
}
