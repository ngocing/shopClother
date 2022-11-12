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
    public partial class BaoCaoLoiNhuan : UserControl
    {
        public BaoCaoLoiNhuan()
        {
            InitializeComponent();
        }
        BUS_XemLoiNhuan bul_dt = new BUS_XemLoiNhuan();
        int kt = 0;

        private void BaoCaoLoiNhuan_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbChonThang.Items.Add(i);
            }
            btnxemloinhuan.Enabled = false;
        }

        private void btnxemloinhuan_Click_1(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (dateChonNgay.Text != "")
                {
                    dataGridView1.DataSource = bul_dt.layngay(DateTime.Parse(dateChonNgay.EditValue.ToString()));
                    int ngay = DateTime.Parse(dateChonNgay.EditValue.ToString()).Day;
                    int thang = DateTime.Parse(dateChonNgay.EditValue.ToString()).Month;
                    int nam = DateTime.Parse(dateChonNgay.EditValue.ToString()).Year;
                    //this.DoanhThuNgayTableAdapter.Fill(this.QLyShopDataSet.DoanhThuNgay, ngay, thang, nam);
                }
                else MessageBox.Show("Bạn chưa nhập ngày");
            }
            else
                if (kt == 2)
                {
                    if (cmbChonThang.Text != "" && txtNhapNam.Text != "")
                    {
                        dataGridView1.DataSource = bul_dt.laythang(cmbChonThang.Text, txtNhapNam.Text);
                        //this.DoanhThuTableAdapter.Fill(this.QLyShopDataSet.DoanhThu, int.Parse(cmbChonThang.Text), int.Parse(txtNhapNam.Text));
                    }
                    else MessageBox.Show("Bạn chưa nhập đủ tháng và năm");
                }
                else if (kt == 3)
                {
                    if (txtNhapNam.Text != "")
                    {
                        dataGridView1.DataSource = bul_dt.laynam(txtNhapNam.Text);
                        //this.DoanhThuNamTableAdapter.Fill(this.QLyShopDataSet.DoanhThuNam, int.Parse(txtNhapNam.Text));
                    }
                    else MessageBox.Show("Bạn chưa nhập năm");
                }

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
            btnxemloinhuan.Enabled = true;
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
            btnxemloinhuan.Enabled = true;
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
            btnxemloinhuan.Enabled = true;
        }

        private void txtNhapNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
