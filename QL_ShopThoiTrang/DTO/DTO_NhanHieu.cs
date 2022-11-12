using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_NhanHieu
    {
        private string manhanhieu;

        public string Manhanhieu
        {
            get { return manhanhieu; }
            set { manhanhieu = value; }
        }
        private string tennhanhieu;

        public string Tennhanhieu
        {
            get { return tennhanhieu; }
            set { tennhanhieu = value; }
        }

        public DTO_NhanHieu()
        {
        }
        public DTO_NhanHieu(string _manhanhieu, string _tennhanhieu)
        {
            this.manhanhieu = _manhanhieu;
            this.tennhanhieu = _tennhanhieu;
        }
    }
}
