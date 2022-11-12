using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_BieuDo
    {
        private string obj;

        public string Obj
        {
            get { return obj; }
            set { obj = value; }
        }
        private string section;

        public string Section
        {
            get { return section; }
            set { section = value; }
        }
        private string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}
