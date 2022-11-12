using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using System.IO;
using DTO;
namespace QL_ShopThoiTrang
{
    public partial class LoaiSanPham : UserControl
    {
        BUS_LoaiSanPham bus_lsp = new BUS_LoaiSanPham();
        BUS_LoaiCha bul_lc = new BUS_LoaiCha();
        public void hienthi()
        {
            DataTable dt = bus_lsp.laydl();
            dataGridView1.DataSource = dt;
        }
        public void hienthicha()
        {
            DataTable dt = bul_lc.laydl();
            dataGridView2.DataSource = dt;
        }
        public LoaiSanPham()
        {
            InitializeComponent();
        }
        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            hienthi();
            hienthicha();
            groupBox1.Enabled = false;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            groupBox2.Enabled = false;
            hiencmb();
            btnupload.Enabled = false;
            btnhuycha.Enabled = false;
            btnghicha.Enabled = false;
        }
        public void hiencmb()
        {
            List<DTO_LoaiCha> listLoaiCha = BUS_LoaiCha.LayLoaiCha();
            comboBox1.DataSource = listLoaiCha;
            comboBox1.DisplayMember = "Tenloaicha";
            comboBox1.ValueMember = "Maloaicha";

        }
        string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            lblID.Text = dr.Cells["ma_loai"].Value.ToString();
            txtten.Text = dr.Cells["ten_loai"].Value.ToString();
            comboBox1.SelectedValue = dr.Cells["ma_loai_cha"].Value.ToString();
            txtmota.Text = dr.Cells["mo_ta"].Value.ToString();
            txturl.Text = dr.Cells["hinh"].Value.ToString();

            if (txturl.Text != " " && txturl.Text != "" && txturl.Text != null)
            {
                string url = paths + "\\HinhSanPham\\" + txturl.Text;
                rtbtenanh.Text = txturl.Text;
                // picHinh.Image = Image.FromFile(url);
                FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read);
                picHinh.Image = System.Drawing.Image.FromStream(fs);
                fs.Close();
            }
            else picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
        }
        int kt = 0;
        public void reset()
        {
            btnGhi.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnCapnhat.Enabled = false;
            groupBox1.Enabled = true;
            btnHuy.Enabled = true;
            btnupload.Enabled = true;
        }
        DTO_LoaiSanPham lsp = new DTO_LoaiSanPham();
        public void clear()
        {
            txtmota.Text = "";
            txtten.Text = "";
            lblID.Text = "";
            rtbtenanh.Text = "";
        }
        public void xoaanh()
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                txturl.Text = dr.Cells["hinh"].Value.ToString();
                if (txturl.Text != "" && txturl.Text != " " && txturl.Text != null)
                {
                    if (rtbtenanh.Text != "" && rtbtenanh.Text != " " && rtbtenanh.Text != txturl.Text)
                    {
                        string luu = paths + "\\HinhSanPham\\" + rtbtenanh.Text;
                        FileInfo file = new FileInfo(luu);
                        file.Delete();
                        rtbtenanh.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }
        public void resethuy()
        {
            lblID.Visible = true;
            btnThem.Enabled = true;
            btnCapnhat.Enabled = true;
            btnHuy.Enabled = false;
            btnGhi.Enabled = false;
            btnXoa.Enabled = true;
            groupBox1.Enabled = false;
            btnupload.Enabled = false;
        }
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            lblcha.Text = dr.Cells["ma_cha"].Value.ToString();
            txttencha.Text = dr.Cells["ten_loai_cha"].Value.ToString();
            txtmotacha.Text = dr.Cells["mo_ta_cha"].Value.ToString();
        }
        int kt2 = 0;
        public void resetcha()
        {
            btnghicha.Enabled = true;
            btnxoacha.Enabled = false;
            btnthem2.Enabled = false;
            btncapnhatcha.Enabled = false;
            groupBox2.Enabled = true;
            btnhuycha.Enabled = true;
        }
        DTO_LoaiCha lc = new DTO_LoaiCha();
        public void resethuycha()
        {
            btnhuycha.Enabled = false;
            btnthem2.Enabled = true;
            btncapnhatcha.Enabled = true;
            btnghicha.Enabled = false;
            btnxoacha.Enabled = true;
            groupBox2.Enabled = false;
        }
        public void clearcha()
        {
            txttencha.Text = "";
            txtmotacha.Text = "";
            lblcha.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            clear();
            reset();
            //lblID.Visible = false;
            lblID.Text = BUS_LoaiSanPham.SinhMaLSP();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            kt = 2;
            reset();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                lsp.Maloai = lblID.Text;
                lsp.Tenloai = txtten.Text;
                lsp.Mota = txtmota.Text;
                lsp.Maloaicha = comboBox1.SelectedValue.ToString();
                lsp.Hinh = rtbtenanh.Text;
                //lsp.Maloai = int.Parse(lblID.Text);
                if (kt == 1)
                {
                    if (bus_lsp.themdl(lsp) == true)
                    {
                        // bus_lop.themdl(nxb);
                        MessageBox.Show("Đã thêm thành công");
                        hienthi();
                        picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
                    }
                    else
                    {
                        xoaanh();
                        picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
                        MessageBox.Show("Nhập thông tin không đầy đủ hoặc mã đã tồn tại", "Vui lòng kiểm tra lại");
                    }

                }

                else
                {

                    if (bus_lsp.suadl(lsp) == true)
                    {
                        // bus_lop.themdl(nxb);
                        MessageBox.Show("Đã sửa thành công");
                        DataGridViewRow dr = dataGridView1.SelectedRows[0];
                        txturl.Text = dr.Cells["hinh"].Value.ToString();
                        string luu = paths + "\\HinhSanPham\\" + txturl.Text;
                        if (txturl.Text != rtbtenanh.Text && txturl.Text != "" && txturl.Text != null)
                        {
                            FileInfo file = new FileInfo(luu);
                            file.Delete();
                        }
                        hienthi();
                        picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
                    }

                    else
                    {
                        xoaanh();
                        picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
                        MessageBox.Show("Nhập thông tin không đầy đủ");
                    }
                }
                resethuy();
                clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resethuy();
            xoaanh();
            picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = lblID.Text;
                if (MessageBox.Show("Bạn có muốn xóa  không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (bus_lsp.xoadl(ma) == true)
                    {
                        MessageBox.Show("Xóa thành công");
                        hienthi();
                        clear();
                        xoaanh();
                        picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
                    }
                    else MessageBox.Show("bạn chưa chọn dữ liệu để xóa hoặc dữ liệu không được phép xóa");
                }
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void btnthem2_Click(object sender, EventArgs e)
        {
            kt2 = 1;
            resetcha();
            clearcha();
            lblcha.Text = BUS_LoaiCha.SinhMaLC();
        }

        private void btncapnhatcha_Click(object sender, EventArgs e)
        {
            kt2 = 2;
            resetcha();
            lblcha.Visible = true;
        }

        private void btnghicha_Click(object sender, EventArgs e)
        {
            try
            {
                lc.Maloaicha = lblcha.Text;
                lc.Tenloaicha = txttencha.Text;
                lc.Mota = txtmotacha.Text;
                //lc.Maloaicha = int.Parse(lblcha.Text);
                if (kt2 == 1)
                {
                    if (bul_lc.themdl(lc) == true)
                    {
                        // bus_lop.themdl(nxb);
                        MessageBox.Show("Đã thêm thành công");
                        hienthicha();
                        hiencmb();
                    }
                    else MessageBox.Show("Nhập thông tin không đầy đủ hoặc mã đã tồn tại", "Vui lòng kiểm tra lại");

                }

                else
                {

                    if (bul_lc.suadl(lc) == true)
                    {
                        // bus_lop.themdl(nxb);
                        MessageBox.Show("Đã sửa thành công");
                        hienthicha();
                        hiencmb();
                    }
                    else MessageBox.Show("Nhập thông tin không đầy đủ");

                }
                clearcha();
                resethuycha();   
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void btnhuycha_Click(object sender, EventArgs e)
        {
            resethuycha();
            clearcha();
        }

        private void btnxoacha_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = lblcha.Text;
                if (MessageBox.Show("Bạn có muốn xóa  không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (bul_lc.xoadl(ma) == true)
                    {
                        MessageBox.Show("Xóa thành công");
                        hienthicha();
                        hiencmb();
                        clear();
                    }
                    else MessageBox.Show("bạn chưa chọn dữ liệu để xóa hoặc dữ liệu không được phép xóa");
                }
                groupBox2.Enabled = false;
                lblcha.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Image File (*.jpg)|*.jpg|All File (*.*)|*.*";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string name = System.IO.Path.GetFileName(open.FileName);
                string luu = paths + "\\HinhSanPham\\" + name;
                try
                {
                    FileStream fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read);
                    System.IO.File.Copy(open.FileName, luu);
                    MessageBox.Show("Upload file ảnh thành công", "Thông báo");
                    rtbtenanh.Text = name;
                    //picHinh.Image = Image.FromFile(luu);
                    picHinh.Image = System.Drawing.Image.FromStream(fs);
                    //  picHinh.ImageLocation = open.FileName;
                    fs.Close();

                }
                catch
                {
                    MessageBox.Show("Hình ảnh tồn tại hoặc trùng tên, vui lòng kiểm tra lại");
                }
            }
        }
    }
}
