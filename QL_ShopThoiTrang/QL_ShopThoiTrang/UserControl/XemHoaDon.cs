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
    public partial class XemHoaDon : UserControl
    {
        public XemHoaDon()
        {
            InitializeComponent();
        }
        BUS_HoaDon hd = new BUS_HoaDon();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (hd.laydl(txtma.Text) != null)
                dataGridView1.DataSource = hd.laydl(txtma.Text);
            else MessageBox.Show("Hóa đơn không tồn tại");
            simpleButton2.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hd.laydl();
            simpleButton2.Enabled = false;
        }

        private void XemHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hd.laydl();
            simpleButton2.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            dataGridView2.DataSource = hd.layct(dr.Cells["ma_hd"].Value.ToString());
            
        }
    }
}
