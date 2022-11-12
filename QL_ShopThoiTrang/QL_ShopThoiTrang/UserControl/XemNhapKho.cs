using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QL_ShopThoiTrang
{
    public partial class XemNhapKho : UserControl
    {
        public XemNhapKho()
        {
            InitializeComponent();
        }

        private void XemNhapKho_Load(object sender, EventArgs e)
        {
            BUS_PhieuNhap bul_hdn = new BUS_PhieuNhap();
            DataTable dt= bul_hdn.laydl();
            gridSplitContainer1Grid.DataSource = dt;
        }
    }
}
