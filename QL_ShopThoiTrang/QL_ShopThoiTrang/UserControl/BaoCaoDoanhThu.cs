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
    public partial class BaoCaoDoanhThu : UserControl
    {
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbChonThang.Items.Add(i);
            }
            button1.Enabled = false;
        }
        BUS_XemDoanhThu bul_dt = new BUS_XemDoanhThu();
        int kt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (dateChonNgay.Text != "")
                {
                    dataGridView1.DataSource = bul_dt.layngay(DateTime.Parse(dateChonNgay.EditValue.ToString()));
                    int ngay = DateTime.Parse(dateChonNgay.EditValue.ToString()).Day;
                    int thang = DateTime.Parse(dateChonNgay.EditValue.ToString()).Month;
                    int nam = DateTime.Parse(dateChonNgay.EditValue.ToString()).Year;
                    this.DoanhThuNgayTableAdapter.Fill(this.QLyShopDataSet.DoanhThuNgay, ngay, thang, nam);
                    this.reportViewer2.RefreshReport();
                    this.reportViewer2.Show();
                    this.reportViewer1.Hide();
                    this.reportViewer3.Hide();
                    an();
                }
                else MessageBox.Show("Bạn chưa nhập ngày");
            }
            else
            if (kt == 2)
            {
                if (cmbChonThang.Text != "" && txtNhapNam.Text != "")
                {
                    dataGridView1.DataSource = bul_dt.laythang(cmbChonThang.Text, txtNhapNam.Text);
                    this.DoanhThuTableAdapter.Fill(this.QLyShopDataSet.DoanhThu, int.Parse(cmbChonThang.Text), int.Parse(txtNhapNam.Text));
                    this.reportViewer1.RefreshReport();
                    this.reportViewer1.Show();
                    this.reportViewer2.Hide();
                    this.reportViewer3.Hide();
                    an();
                }
                else MessageBox.Show("Bạn chưa nhập đủ tháng và năm");
            }
            else if (kt == 3)
            {
                if (txtNhapNam.Text != "")
                {
                    dataGridView1.DataSource = bul_dt.laynam(txtNhapNam.Text);
                    this.DoanhThuNamTableAdapter.Fill(this.QLyShopDataSet.DoanhThuNam, int.Parse(txtNhapNam.Text));
                    this.reportViewer3.RefreshReport();
                    this.reportViewer3.Show();
                    this.reportViewer2.Hide();
                    this.reportViewer1.Hide();
                    an();
                }
                else MessageBox.Show("Bạn chưa nhập năm");
            }
            
        }
        public void an()
        {
            dateChonNgay.Enabled = false;
            cmbChonThang.Enabled = false;
            txtNhapNam.Enabled = false;
            button1.Enabled = false;
        }
        private void radTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (radTheoNgay.Checked == true)
            {
                kt = 1;
                dateChonNgay.Enabled = true;
                cmbChonThang.Enabled = false;
                txtNhapNam.Enabled = false;
            }
            else
                if (radTheoThang.Checked == true)
                {
                    kt = 2;
                    cmbChonThang.Enabled = true;
                    txtNhapNam.Enabled = true;
                    dateChonNgay.Enabled = false;
                }
                else
                {
                    kt = 3;
                    txtNhapNam.Enabled = true;
                    dateChonNgay.Enabled = false;
                    cmbChonThang.Enabled = false;
                }
            button1.Enabled = true;
        }

        private void radTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (radTheoNgay.Checked == true)
            {
                kt = 1;
                dateChonNgay.Enabled = true;
                cmbChonThang.Enabled = false;
                txtNhapNam.Enabled = false;
            }
            else
                if (radTheoThang.Checked == true)
                {
                    kt = 2;
                    cmbChonThang.Enabled = true;
                    txtNhapNam.Enabled = true;
                    dateChonNgay.Enabled = false;
                }
                else
                {
                    kt = 3;
                    txtNhapNam.Enabled = true;
                    dateChonNgay.Enabled = false;
                    cmbChonThang.Enabled = false;
                }
            button1.Enabled = true;
        }

        private void radTheoNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radTheoNgay.Checked == true)
            {
                kt = 1;
                dateChonNgay.Enabled = true;
                cmbChonThang.Enabled = false;
                txtNhapNam.Enabled = false;
            }
            else
                if (radTheoThang.Checked == true)
                {
                    kt = 2;
                    cmbChonThang.Enabled = true;
                    txtNhapNam.Enabled = true;
                    dateChonNgay.Enabled = false;
                }
                else
                {
                    kt = 3;
                    txtNhapNam.Enabled = true;
                    dateChonNgay.Enabled = false;
                    cmbChonThang.Enabled = false;
                }
            button1.Enabled = true;
        }

        private void txtNhapNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
