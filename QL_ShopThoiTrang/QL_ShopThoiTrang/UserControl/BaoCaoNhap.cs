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
    public partial class BaoCaoNhap : UserControl
    {
        public BaoCaoNhap()
        {
            InitializeComponent();
        }

        BUS_PhieuNhap bul_hdn = new BUS_PhieuNhap();
        private void BaoCaoNhap_Load(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i);
            }
            simpleButton1.Enabled = false;
        }
        int kt = 0;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (dateNgay.Text != "")
                {
                    dataGridView1.DataSource = bul_hdn.layngay(DateTime.Parse(dateNgay.EditValue.ToString()));
                    string tong = bul_hdn.tongngay(DateTime.Parse(dateNgay.EditValue.ToString())).ToString();
                    label1.Text = tong;
                    int ngay = DateTime.Parse(dateNgay.EditValue.ToString()).Day;
                    int thang = DateTime.Parse(dateNgay.EditValue.ToString()).Month;
                    int nam = DateTime.Parse(dateNgay.EditValue.ToString()).Year;
                    this.baoCaoNhapNgayTableAdapter.Fill(this.QLyShopDataSet.BaoCaoNhapNgay, ngay, thang, nam);
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
                    if (txtNam.Text != "" && cmbThang.Text != "")
                    {
                        dataGridView1.DataSource = bul_hdn.laythang(cmbThang.Text, txtNam.Text);
                        string tong = bul_hdn.tongthang(cmbThang.Text, txtNam.Text).ToString();
                        label1.Text = tong;
                        this.BaoCaoNhapTableAdapter.Fill(this.QLyShopDataSet.BaoCaoNhap, int.Parse(cmbThang.Text), int.Parse(txtNam.Text));
                        this.reportViewer1.RefreshReport();
                        this.reportViewer1.Show();
                        this.reportViewer2.Hide();
                        this.reportViewer3.Hide();
                        an();
                    }
                    else MessageBox.Show("Bạn chưa nhập đủ tháng và năm");
                }

                else if
                    (kt == 3)
                {
                    if (txtNam.Text != "")
                    {
                        dataGridView1.DataSource = bul_hdn.laynam(txtNam.Text);
                        string tong = bul_hdn.tongnam(txtNam.Text).ToString();
                        label1.Text = tong;
                        this.BaoCaoNamNhapTableAdapter.Fill(this.QLyShopDataSet.BaoCaoNamNhap, int.Parse(txtNam.Text));
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
            dateNgay.Enabled = false;
            cmbThang.Enabled = false;
            txtNam.Enabled = false;
            simpleButton1.Enabled = false;
        }
        private void radNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {
                kt = 1;
                dateNgay.Enabled = true;
                cmbThang.Enabled = false;
                txtNam.Enabled = false;
            }
            else
                if (radThang.Checked == true)
                {
                    kt = 2;
                    cmbThang.Enabled = true;
                    txtNam.Enabled = true;
                    dateNgay.Enabled = false;
                }
                else
                {
                    kt = 3;
                    txtNam.Enabled = true;
                    dateNgay.Enabled = false;
                    cmbThang.Enabled = false;
                }
            simpleButton1.Enabled = true;
        }

        private void radThang_CheckedChanged(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {
                kt = 1;
                dateNgay.Enabled = true;
                cmbThang.Enabled = false;
                txtNam.Enabled = false;
            }
            else
                if (radThang.Checked == true)
                {
                    kt = 2;
                    cmbThang.Enabled = true;
                    txtNam.Enabled = true;
                    dateNgay.Enabled = false;
                }
                else
                {
                    kt = 3;
                    txtNam.Enabled = true;
                    dateNgay.Enabled = false;
                    cmbThang.Enabled = false;
                }
            simpleButton1.Enabled = true;
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {
                kt = 1;
                dateNgay.Enabled = true;
                cmbThang.Enabled = false;
                txtNam.Enabled = false;
            }
            else
                if (radThang.Checked == true)
                {
                    kt = 2;
                    cmbThang.Enabled = true;
                    txtNam.Enabled = true;
                    dateNgay.Enabled = false;
                }
                else
                {
                    kt = 3;
                    txtNam.Enabled = true;
                    dateNgay.Enabled = false;
                    cmbThang.Enabled = false;
                }
            simpleButton1.Enabled = true;
        }
        BUS_ChiTietPhieuNhap bul_cthd = new BUS_ChiTietPhieuNhap();
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string ma = dr.Cells["ma_hdn"].Value.ToString();
            dataGridView2.DataSource = bul_cthd.lay(ma);
            //this.BaoCaoNhapTableAdapter.Fill(this.QLyShopDataSet.BaoCaoNhap, ma);
            //this.reportViewer1.RefreshReport();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            //simpleButton1.Enabled = false;
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
 
    }
}
