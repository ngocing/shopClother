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
    public partial class BaocaoNVBH : UserControl
    {
        public BaocaoNVBH()
        {
            InitializeComponent();
        }
        public void an()
        {
            dateChonNgay.Enabled = false;
            cmbChonThang.Enabled = false;
            txtNhapNam.Enabled = false;
            button1.Enabled = true;
        }
        int kt = 0;
        BUS_XemNhanVien bul_tk = new BUS_XemNhanVien();
        private void button1_Click(object sender, EventArgs e)
        {
            if (gt == 1) ///nhân viên hán hàng
            {
                dataGridView2.Visible = false;
                if (kt == 1)
                {
                    if (dateChonNgay.Text != "")
                    {
                        dataGridView1.DataSource = bul_tk.layngay(DateTime.Parse(dateChonNgay.EditValue.ToString()));
                        int ngay = DateTime.Parse(dateChonNgay.EditValue.ToString()).Day;
                        int thang = DateTime.Parse(dateChonNgay.EditValue.ToString()).Month;
                        int nam = DateTime.Parse(dateChonNgay.EditValue.ToString()).Year;
                        an();
                    }
                    else MessageBox.Show("Bạn chưa nhập ngày");
                }
                else
                    if (kt == 2)
                    {
                        if (cmbChonThang.Text != "" && txtNhapNam.Text != "")
                        {
                            dataGridView1.DataSource = bul_tk.laythang(cmbChonThang.Text, txtNhapNam.Text);
                            an();
                        }
                        else MessageBox.Show("Bạn chưa nhập đủ tháng và năm");
                    }
                    else if (kt == 3)
                    {
                        if (txtNhapNam.Text != "")
                        {
                            dataGridView1.DataSource = bul_tk.laynam(txtNhapNam.Text);
                            an();
                        }
                        else MessageBox.Show("Bạn chưa nhập năm");
                    }
            }
            else if (gt == 2) //nhân vien bán dc nhieu hang nhất
            {
                dataGridView2.Visible = false;
                if (kt == 1)
                {
                    if (dateChonNgay.Text != "")
                    {
                        dataGridView1.DataSource = bul_tk.layngay_NN(DateTime.Parse(dateChonNgay.EditValue.ToString()));
                        int ngay = DateTime.Parse(dateChonNgay.EditValue.ToString()).Day;
                        int thang = DateTime.Parse(dateChonNgay.EditValue.ToString()).Month;
                        int nam = DateTime.Parse(dateChonNgay.EditValue.ToString()).Year;
                        an();
                    }
                    else MessageBox.Show("Bạn chưa nhập ngày");
                }
                else
                    if (kt == 2)
                    {
                        if (cmbChonThang.Text != "" && txtNhapNam.Text != "")
                        {
                            dataGridView1.DataSource = bul_tk.laythang_NN(cmbChonThang.Text, txtNhapNam.Text);
                            an();
                        }
                        else MessageBox.Show("Bạn chưa nhập đủ tháng và năm");
                    }
                    else if (kt == 3)
                    {
                        if (txtNhapNam.Text != "")
                        {
                            dataGridView1.DataSource = bul_tk.laynam_NN(txtNhapNam.Text);
                            an();
                        }
                        else MessageBox.Show("Bạn chưa nhập năm");
                    }
            }
            else if (gt == 3)
            {
                dataGridView1.Visible = false;
                if (kt == 1)
                {
                    if (dateChonNgay.Text != "")
                    {
                        dataGridView2.DataSource = bul_tk.layngay_KBD(DateTime.Parse(dateChonNgay.EditValue.ToString()));
                        int ngay = DateTime.Parse(dateChonNgay.EditValue.ToString()).Day;
                        int thang = DateTime.Parse(dateChonNgay.EditValue.ToString()).Month;
                        int nam = DateTime.Parse(dateChonNgay.EditValue.ToString()).Year;
                        an();
                    }
                    else MessageBox.Show("Bạn chưa nhập ngày");
                }
                else
                    if (kt == 2)
                    {
                        if (cmbChonThang.Text != "" && txtNhapNam.Text != "")
                        {
                            dataGridView2.DataSource = bul_tk.laythang_KBD(cmbChonThang.Text, txtNhapNam.Text);
                            an();
                        }
                        else MessageBox.Show("Bạn chưa nhập đủ tháng và năm");
                    }
                    else if (kt == 3)
                    {
                        if (txtNhapNam.Text != "")
                        {
                            dataGridView2.DataSource = bul_tk.laynam_KBD(txtNhapNam.Text);
                            an();
                        }
                        else MessageBox.Show("Bạn chưa nhập năm");
                    }
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

        private void txtNhapNam_EditValueChanged(object sender, EventArgs e)
        {

        }
        int gt = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gt = 1;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }

        private void txtNhapNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gt = 2;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gt = 3;
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
        }

        private void BaocaoNVBH_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbChonThang.Items.Add(i);
            }
            button1.Enabled = false;

            dataGridView2.Visible = false;
        }
    }
}
