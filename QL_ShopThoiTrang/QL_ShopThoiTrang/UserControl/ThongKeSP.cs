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
    public partial class ThongKeSP : UserControl
    {
        public ThongKeSP()
        {
            InitializeComponent();
        }
        BUS_SanPham bul_sp = new BUS_SanPham();
        
        private void ThongKeSP_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bul_sp.laydltk();
           this.san_PhamTableAdapter.Fill(this.qLyShopDataSet.San_Pham);
        }

        private void radtop_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = bul_sp.laydltk();
            DataTable data = new DataTable();
            DataView dv = dt.DefaultView;
            dv.Sort = "ban DESC";
            data = dv.ToTable();
            dataGridView1.DataSource = data;
        }

        private void radlast_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = bul_sp.laydltk();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["ban"].ToString() != "0")
                    dt.Rows[i].Delete();
            }
            dataGridView1.DataSource = dt;
        }

        private void radall_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bul_sp.laydltk();
        }

    }
}
