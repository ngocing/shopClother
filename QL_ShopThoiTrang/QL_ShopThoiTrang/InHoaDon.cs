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
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLyShopDataSet.DataTableHD' table. You can move, or remove it, as needed.
            this.DataTableHDTableAdapter.Fill(this.QLyShopDataSet.DataTableHD);
            // TODO: This line of code loads data into the 'QLyShopDataSet.InHoaDon' table. You can move, or remove it, as needed.
            this.InHoaDonTableAdapter.Fill(this.QLyShopDataSet.InHoaDon);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
