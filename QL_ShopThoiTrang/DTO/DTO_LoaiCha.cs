using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_LoaiCha
    {
        private string maloaicha;

        public string Maloaicha
        {
            get { return maloaicha; }
            set { maloaicha = value; }
        }
        private string tenloaicha;

        public string Tenloaicha
        {
            get { return tenloaicha; }
            set { tenloaicha = value; }
        }
        private string mota;

        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }
        public DTO_LoaiCha()
        {
        }
        public DTO_LoaiCha(string _maloaicha, string _tenloaicha, string _mota)
        {
            this.maloaicha = _maloaicha;
            this.tenloaicha = _tenloaicha;
            this.mota = _mota;
        }
    }
}
