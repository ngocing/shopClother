using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public class DTO_PhanQuyen
    {
        private string maquyen;

        public string Maquyen
        {
            get { return maquyen; }
            set { maquyen = value; }
        }
        private string tenquyen;

        public string Tenquyen
        {
            get { return tenquyen; }
            set { tenquyen = value; }
        }
    }
}
