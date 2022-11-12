using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_ShopThoiTrang
{
    public partial class HienThi : Form
    {
        public HienThi(string s)
        {
            InitializeComponent();
            tam = s;
        }
        string tam = "";
        private void HienThi_Load(object sender, EventArgs e)
        {
            SanPham sp= new SanPham(tam);
            panelControl1.Controls.Add(sp);
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
