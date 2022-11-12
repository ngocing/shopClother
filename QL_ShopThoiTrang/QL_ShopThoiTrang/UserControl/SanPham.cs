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
    public partial class SanPham : UserControl
    {
        public SanPham(string s)
        {
            InitializeComponent();
            kiemtra = s;
        }
        string kiemtra = "";
        BUS_SanPham bul_sp = new BUS_SanPham();
        public void hienthi()
        {
            
            DataTable dt = bul_sp.laydl();
            dataGridView1.DataSource = dt;

        }
        public void hiencmb()
        {
            DataTable dt = bul_sp.hienthiLoai();
            cmbloai.DataSource = dt;
            cmbloai.DisplayMember = "ten_loai".Trim();
            cmbloai.ValueMember = "ma_loai".Trim(); // hàm chọn hiện ra tên
            DataTable dt2 = bul_sp.hienthiHieu();
            cmbhieu.DataSource = dt2;
            cmbhieu.DisplayMember = "ten_hieu".Trim();
            cmbhieu.ValueMember = "ma_hieu".Trim(); // hàm chọn hiện ra tên
        }
        string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
        private void SanPham_Load(object sender, EventArgs e)
        {
           
            hienthi();
            hiencmb();
            btnupload.Enabled = false;
            txtUrl.Text = "";
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            dateNCN.Text = DateTime.Now.Date.ToString();
            simpleButton2.Enabled = false;
            resethuy();
            btnThem.Enabled = false;
            if (kiemtra != "")
            {
                btnThem.Enabled = true;
                btnCapnhat.Enabled = false;
            }
            else
            {
                btnThem.Enabled = false;
                btnCapnhat.Enabled = true;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                lblma.Text = dr.Cells["ma_sp"].Value.ToString();
                rtbten.Text = dr.Cells["ten_sp"].Value.ToString();
                cmbloai.Text = dr.Cells["loaisp"].Value.ToString();
                cmbhieu.Text = dr.Cells["nhanhieu"].Value.ToString();
                txtdongia.Text = dr.Cells["don_gia"].Value.ToString();
                dateNCN.Text = dr.Cells["ngay_cap_nhat"].Value.ToString();
                rtbmota.Text = dr.Cells["mo_ta"].Value.ToString();
                txtloinhuan.Text = dr.Cells["loinhuan"].Value.ToString();
                txtUrl.Text = dr.Cells["hinh"].Value.ToString();
                string tam1 = bul_sp.tongSLnhap(lblma.Text).ToString();
                string tam2 = bul_sp.tongSLban(lblma.Text).ToString();
                long soluongton = 0;
                long nhap, xuat;
                if (tam1 == null || tam1 == "")
                {
                    nhap = 0;
                }
                else
                {
                    nhap = long.Parse(tam1);
                }
                if (tam2 == null || tam2 == "")
                {
                    xuat = 0;
                }
                else
                {
                    xuat = long.Parse(tam2);
                }
                soluongton = nhap - xuat;
                lblsl.Text = "Tồn kho: " + soluongton.ToString();
                if (txtUrl.Text != " " && txtUrl.Text != "" && txtUrl.Text != null)
                {
                    string url = paths + "\\HinhSanPham\\" + txtUrl.Text;
                    rtbtenanh.Text = txtUrl.Text;
                    // picHinh.Image = Image.FromFile(url);
                    FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read);
                    picHinh.Image = System.Drawing.Image.FromStream(fs);
                    fs.Close();
                }
                else picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
            }
            catch (Exception)
            {
            }         
        }
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
        public void clear()
        {
            lblma.Text = "";
            rtbmota.Text = "";
            rtbten.Text = "";
            lblma.Text = "";
            dateNCN.Text = "";
            txtdongia.Text = "";
            rtbtenanh.Text = "";
            txtloinhuan.Text = "";
        }
        int kt = 0;
        
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (rowindex >= 0)
            {
                kt = 2;
                reset();
                txtdongia.Enabled = true;
            }
            else
                MessageBox.Show("Hãy chọn sản phẩm cần cập nhập", "Thông báo");
        }
        public void resethuy()
        {
            lblma.Visible = true;
            btnThem.Enabled = true;
            btnCapnhat.Enabled = true;
            btnHuy.Enabled = false;
            btnGhi.Enabled = false;
            btnXoa.Enabled = true;
            groupBox1.Enabled = false;
            btnupload.Enabled = false;
        }
        DTO_SanPham sp = new DTO_SanPham();
        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                sp.Masp = lblma.Text;
                sp.Tensp = rtbten.Text;
                sp.Maloai = cmbloai.SelectedValue.ToString();
                sp.Mahieu = cmbhieu.SelectedValue.ToString();
                if (dateNCN.Text == "" || dateNCN.Text == null)
                    sp.Ngaycapnhat = DateTime.Now.Date;
                else
                    sp.Ngaycapnhat = DateTime.Parse(dateNCN.Text);
                sp.Hinh = rtbtenanh.Text;
                sp.Mota = rtbmota.Text;
                if (txtdongia.Text == "" || txtdongia.Text == " " || txtdongia.Text == null)
                    sp.Dongia = 0;
                else
                    sp.Dongia = decimal.Parse(txtdongia.Text);
                if (txtloinhuan.Text == "" || txtloinhuan.Text == " " || txtloinhuan.Text == null)
                    sp.Loinhuan = 0;
                else
                    sp.Loinhuan = decimal.Parse(txtloinhuan.Text);
                if (kt == 1)
                {
                    if (bul_sp.themdl(sp) == true)
                    {
                        MessageBox.Show("Đã thêm thành công");
                        hienthi();
                        picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
                    }
                    else
                    {
                        MessageBox.Show("Nhập thông tin không đầy đủ hoặc mã đã tồn tại", "Vui lòng kiểm tra lại");
                        xoaanh();
                        picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
                    }
                }
                else
                {

                    if (bul_sp.suadl(sp) == true)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        DataGridViewRow dr = dataGridView1.SelectedRows[0];
                        txtUrl.Text = dr.Cells["hinh"].Value.ToString();
                        string luu = paths + "\\HinhSanPham\\" + txtUrl.Text;
                        if (txtUrl.Text != rtbtenanh.Text && txtUrl.Text != null && txtUrl.Text != "")
                        {
                            FileInfo file = new FileInfo(luu);
                            file.Delete();
                        }
                        hienthi();
                        picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
                    }
                    else
                    {
                        MessageBox.Show("Nhập thông tin không đầy đủ", "Vui lòng kiểm tra");
                        xoaanh();
                        picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
                    }
                }
                resethuy();
            }
            catch (Exception)
            {
            }
            
           // clear();
        }

        public void xoaanh()
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                txtUrl.Text = dr.Cells["hinh"].Value.ToString();
                if (txtUrl.Text != "" && txtUrl.Text != " " && txtUrl.Text != null)
                {
                    if (rtbtenanh.Text != "" && rtbtenanh.Text != " " && rtbtenanh.Text != txtUrl.Text)
                    {
                        string luu = paths + "\\HinhSanPham\\" + rtbtenanh.Text;
                        FileInfo file = new FileInfo(luu);
                        file.Delete();
                        rtbtenanh.Text = "";
                    }
                }
            }
            catch (Exception)
            {
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
                string ma = lblma.Text;
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (bul_sp.xoadl(ma) == true)
                    {
                        MessageBox.Show("Xóa thành công");
                        hienthi();
                        clear();
                        xoaanh();
                        picHinh.Image = Image.FromFile(paths + "\\Resources\\noimage.jpg");
                    }
                    else MessageBox.Show("Bạn chưa chọn dữ liệu để xóa hoặc dữ liệu không được phép xóa", "Chú ý");
                }
                groupBox1.Enabled = false;
            }
            catch (Exception)
            {
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
                    MessageBox.Show("Hình ảnh đã tồn tại hoặc trùng tên, vui lòng kiểm tra lại");
                }
            }
        }
        int rowindex = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rowindex >= 0)
                rowindex = e.RowIndex;
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (bul_sp.laydl(txtma.Text) != null)
                dataGridView1.DataSource = bul_sp.laydl(txtma.Text);
            else MessageBox.Show("Sản phẩm không tồn tại");
            simpleButton2.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bul_sp.laydl();
            simpleButton2.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            clear();
            reset();
            //lblma.Visible = false;
            lblma.Text = BUS_SanPham.SinhMaSP();
        }
    }
}
