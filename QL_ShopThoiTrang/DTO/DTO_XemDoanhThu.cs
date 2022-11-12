using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_XemDoanhThu
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
        private string _trigia;

        public string Trigia
        {
            get { return _trigia; }
            set { _trigia = value; }
        }
        public DTO_XemDoanhThu()
        { }
        public DTO_XemDoanhThu(string pma, string pten, string pngay, string ptrigia)
        {
            this._masp = pma;
            this._tensp = pten;
            this._ngaylap = Ngaylap;
            this._trigia = ptrigia;
        }
    }
}
