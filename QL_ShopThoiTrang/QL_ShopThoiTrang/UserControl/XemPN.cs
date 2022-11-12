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
    public partial class XemPN : UserControl
    {
        public XemPN()
        {
            InitializeComponent();
        }
        BUS_PhieuNhap pn = new BUS_PhieuNhap();
        BUS_ChiTietPhieuNhap ctpn = new BUS_ChiTietPhieuNhap();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (pn.laydl(txtma.Text) != null)
                dataGridView1.DataSource = pn.laydl(txtma.Text);
            else MessageBox.Show("Hóa đơn không tồn tại");
            simpleButton2.Enabled = true;
        }

        private void txtma_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pn.laydl();
            simpleButton2.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            dataGridView2.DataSource = ctpn.lay(dr.Cells["ma_hdn"].Value.ToString());
        }

        private void XemPN_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pn.laydl();
            simpleButton2.Enabled = false;
        }
    }
}
