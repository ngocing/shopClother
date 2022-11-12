using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using BUS;

namespace QL_ShopThoiTrang
{
    public partial class QL_Shop : XtraForm
    {
        public QL_Shop()
        {
            InitializeComponent();
        }
        private void QL_Shop_Load(object sender, EventArgs e)
        {
            barStaticItem4.Caption =DateTime.Now.Date.ToString();
            barStaticItem3.Caption =BUS_NhanVien.LayThongTinDangNhap() +"  |";
            string s = "";
            BUS_NhanVien xl = new BUS_NhanVien();
            s = BUS_NhanVien.LayThongTinDangNhap();
            DataTable login = xl.Getlogin(s);

            for (int i = 0; i < login.Rows.Count; i++)
            {
                lblten.Text = "Người dùng: " + login.Rows[i]["ten_nv"].ToString().Trim();
                if (login.Rows[i]["ma_quyen"].ToString().Trim() == "1")
                {
                   //MessageBox.Show("Bạn đăng nhập thành công với quền ADMIN");
                    XL_user();
                }
                else if (login.Rows[i]["ma_quyen"].ToString().Trim() == "2")
                {
                   //MessageBox.Show("Bạn đăng nhập thành công với quền Nhân viên bán hàng");
                    XL_NVBH();
                }
                else if (login.Rows[i]["ma_quyen"].ToString().Trim() == "3")
                {
                    //MessageBox.Show("Bạn đăng nhập thành công với quền Nhân viên nhập hàng");
                    XL_NVNH();
                }
            }
        }
         
        void XL_NVBH()
        {
            UCBanHang.Enabled = true;
            UCSanPham.Enabled = true;
            UCLoaiSanPham.Enabled = true;
            UCNhanHieu.Enabled = true;
            UCNhapKho.Enabled = false;
            UCNhaCungCap.Enabled = false;
            UCTKDoanhthu.Enabled = false;
            UCTKNhapHang.Enabled = false;
            btnXemSP.Enabled = true;
            btnXemLSP.Enabled = true;
            btnXemNhanHieu.Enabled = true;
            btnBanHang.Enabled = true;
            btnXemNhapKho.Enabled = false;
            btnXemNCC.Enabled = false;
            btnNhapKho.Enabled = false;
            btnXemDTNgay.Enabled = false;
            btnXemDoanhThuThang.Enabled = false;
            barButtonItem1.Enabled = true;
            barButtonItem3.Enabled = false;
            barButtonItem2.Enabled = true;
            UCNhanvien.Enabled = false;
            barButtonItem12.Enabled = false;

            barButtonItem11.Enabled = false;
            barButtonItem10.Enabled = false;
            barButtonItem9.Enabled = false;
            barButtonItem8.Enabled = false;
            navBarItem1.Enabled = false;
            navBarItem2.Enabled = false;
        }
        void XL_NVNH()
        {
            UCBanHang.Enabled = false;
            UCSanPham.Enabled = true;
            UCLoaiSanPham.Enabled = true;
            UCNhanHieu.Enabled = true;
            UCNhapKho.Enabled = true;
            UCNhaCungCap.Enabled = true;
            UCTKDoanhthu.Enabled = false;
            UCTKNhapHang.Enabled = true;
            btnXemSP.Enabled = true;
            btnXemLSP.Enabled = true;
            btnXemNhanHieu.Enabled = true;
            btnBanHang.Enabled = false;
            btnXemNhapKho.Enabled = true;
            btnXemNCC.Enabled = true;
            btnNhapKho.Enabled = true;
            btnXemDTNgay.Enabled = false;
            btnXemDoanhThuThang.Enabled = false;
            barButtonItem1.Enabled = false;
            barButtonItem3.Enabled = true;
            barButtonItem2.Enabled = false;
            UCNhanvien.Enabled = false;

            barButtonItem12.Enabled = false;
            navBarItem3.Enabled = false;
            barButtonItem11.Enabled = false;
            barButtonItem10.Enabled = false;
            barButtonItem9.Enabled = false;
            barButtonItem8.Enabled = false;
            navBarItem1.Enabled = false;
            navBarItem2.Enabled = false;
        }
        void XL_user()
        {
            UCBanHang.Enabled = true;
            UCSanPham.Enabled =true;
            UCLoaiSanPham.Enabled =true;
            UCNhanHieu.Enabled = true;
            UCNhapKho.Enabled=true;
            UCNhaCungCap.Enabled=true;
            UCTKDoanhthu.Enabled=true;
            UCTKNhapHang.Enabled = true;
            btnXemSP.Enabled =true;
            btnXemLSP.Enabled =true;
            btnXemNhanHieu.Enabled =true;
            btnBanHang.Enabled =true;
            btnXemNhapKho.Enabled =true;
            btnXemNCC.Enabled =true;
            btnNhapKho.Enabled =true;
            btnXemDTNgay.Enabled =true;
            btnXemDoanhThuThang.Enabled =true;
            barButtonItem1.Enabled =true;
            barButtonItem3.Enabled =true;
            barButtonItem2.Enabled =true;
            UCNhanvien.Enabled = true;
            barButtonItem12.Enabled=true;
            navBarItem3.Enabled = true;
            barButtonItem11.Enabled=true;
            barButtonItem10.Enabled=true;
            barButtonItem9.Enabled=true;
            barButtonItem8.Enabled=true;
            navBarItem1.Enabled=true;
            navBarItem2.Enabled=true;
        }

        private void addNewTab(string strTabName, UserControl ucContent)
        {
            DevExpress.XtraTab.XtraTabPage newTabPage = new DevExpress.XtraTab.XtraTabPage();
            newTabPage.Name = "xtraTabName" + strTabName;
            //kiem tra ton tai
            foreach (DevExpress.XtraTab.XtraTabPage tabpage in xtraTabControl1.TabPages)
            {
                if (tabpage.Name == newTabPage.Name)
                {
                    xtraTabControl1.SelectedTabPage = tabpage;
                    return;
                }
            }
            //them tab moi
            xtraTabControl1.TabPages.Add(newTabPage);
            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
            //tao thuoc tinh cho tab moi
            newTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.Cyan;
            newTabPage.Appearance.PageClient.Options.UseBackColor = true;
            //tao thuoc tinh cho UCcontent
            ucContent.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(ucContent);
            newTabPage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            newTabPage.Size = new System.Drawing.Size(929, 458);
            newTabPage.Text = strTabName;
        }
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {

            if (xtraTabControl1.SelectedTabPageIndex != 0)
            {
                int index = xtraTabControl1.SelectedTabPageIndex;
                xtraTabControl1.TabPages.RemoveAt(index);
                xtraTabControl1.SelectedTabPageIndex = index - 1;
            }
        }

        private void LayoutView()
        {
            GridControl grid = new GridControl();
            LayoutView lView = new LayoutView(grid);
            grid.MainView = lView;
            lView.OptionsBehavior.AutoPopulateColumns = false;
            //grid.DataSource = nwindDataSet.Employees;
            this.Controls.Add(grid);
            grid.Dock = DockStyle.Fill;
            // Create columns.
            LayoutViewColumn colFirstName = lView.Columns.AddField("FirstName");
            LayoutViewColumn colLastName = lView.Columns.AddField("LastName");
            LayoutViewColumn colAddress = lView.Columns.AddField("Address");
            LayoutViewColumn colCity = lView.Columns.AddField("City");
            LayoutViewColumn colCountry = lView.Columns.AddField("Country");
            LayoutViewColumn colPhoto = lView.Columns.AddField("Photo");
            // Access corresponding card fields.
            LayoutViewField fieldFirstName = colFirstName.LayoutViewField;
            LayoutViewField fieldLastName = colLastName.LayoutViewField;
            LayoutViewField fieldAddress = colAddress.LayoutViewField;
            LayoutViewField fieldCity = colCity.LayoutViewField;
            LayoutViewField fieldCountry = colCountry.LayoutViewField;
            LayoutViewField fieldPhoto = colPhoto.LayoutViewField;
            // Make the Photo field visible.
            colPhoto.Visible = true;
            // Position the FirstName field to the right of the Photo field.
            fieldFirstName.Move(new LayoutItemDragController(fieldFirstName, fieldPhoto, InsertLocation.After, LayoutType.Horizontal));
            // Position the LastName field below the FirstName field.
            fieldLastName.Move(new LayoutItemDragController(fieldLastName, fieldFirstName, InsertLocation.After, LayoutType.Vertical));
            // Create an Address Info group.
            LayoutControlGroup groupAddress = lView.TemplateCard.AddGroup("Address Info", fieldLastName, InsertType.Bottom);
            // Add the Address, City and Country fields to this group.
            groupAddress.Add(colAddress.LayoutViewField);
            groupAddress.Add(colCity.LayoutViewField);
            groupAddress.Add(colCountry.LayoutViewField);
            // Assign editors to card fields.
            RepositoryItemPictureEdit riPictureEdit = grid.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            riPictureEdit.SizeMode = PictureSizeMode.Squeeze;
            colPhoto.ColumnEdit = riPictureEdit;
            // Customize card field options.
            colFirstName.Caption = "First Name";
            colLastName.Caption = "Last Name";
            // Set the card's minimum size.
            lView.CardMinSize = new Size(350, 200);
        }

        private void UCBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BanHang ucbanhang = new BanHang();
            addNewTab("Bán Hàng", ucbanhang);
        }

        private void UCSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SanPham ucsanpham = new SanPham("");
            addNewTab("Sản Phẩm", ucsanpham);
        }

        private void UCLoaiSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoaiSanPham ucloaisp = new LoaiSanPham();
            addNewTab("Loại Sản Phẩm",ucloaisp);
        }

        private void UCNhanHieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhanHieu ucnhanhieu = new NhanHieu();
            addNewTab("Nhãn Hiệu", ucnhanhieu);
        }
 
        private void UCNhapKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhapKho ucnhapkho = new NhapKho();
            addNewTab("Nhập Kho", ucnhapkho);
        }

        private void UCNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhaCungCap ucnhacungcap = new NhaCungCap();
            addNewTab("Nhà Cung Cấp", ucnhacungcap);
        }

        private void UCTKDoanhthu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaoCaoDoanhThu ucsanpham = new BaoCaoDoanhThu();
            addNewTab("Báo Cáo Doanh Thu", ucsanpham);
        }

        private void UCTKNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaoCaoNhap ucsanpham = new BaoCaoNhap();
            addNewTab("Báo Cáo Nhập", ucsanpham);
        }      

        private void FrmDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangePass doimk = new ChangePass();
            doimk.Show();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
               // XL_OUT();
                Login dangnhap = new Login();
                //this.Enabled = false;
                dangnhap.Show();
                this.Hide();             
            }
        }

        private void FrmThayDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TT_Nhanvien ttnv = new TT_Nhanvien();
            addNewTab("Thông tin nhân viên", ttnv);
        }

        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {          
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
            }
        }
        private void QL_Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void btnTroGiup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            About about = new About();
            about.Show();
        }              

        private void btnXemSP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XemSanPham ucsanpham = new XemSanPham();
            addNewTab("Xem Sản Phẩm", ucsanpham);
        }

        private void btnXemLSP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xemLoaiSP ucsanpham = new xemLoaiSP();
            addNewTab("Xem loại sản phẩm", ucsanpham);
        }

        private void btnXemNhanHieu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XemNhanHieu ucsanpham = new XemNhanHieu();
            addNewTab("Xem nhãn hiệu", ucsanpham);
        }

        private void btnBanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BanHang ucbanhang = new BanHang();
            addNewTab("Bán Hàng", ucbanhang);
        }

        private void btnXemNhapKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XemNhapKho ucbanhang = new XemNhapKho();
            addNewTab("Xem nhập kho", ucbanhang);
        }

        private void btnXemNCC_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XemNCC ucbanhang = new XemNCC();
            addNewTab("Xem nhà cung cấp", ucbanhang);
        }

        private void btnNhapKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            NhapKho ucnhapkho = new NhapKho();
            addNewTab("Nhập Kho", ucnhapkho);
        }

        private void btnXemDTNgay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BaoCaoDoanhThu ucsanpham = new BaoCaoDoanhThu();
            addNewTab("Báo Cáo Doanh Thu", ucsanpham);
        }

        private void btnXemDoanhThuThang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BaoCaoNhap ucsanpham = new BaoCaoNhap();
            addNewTab("Báo Cáo Nhập", ucsanpham);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhachHang ucKH = new KhachHang();
            addNewTab("Khách Hàng", ucKH);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XemPN ucpn = new XemPN();
            addNewTab("Xem Hóa Đơn Nhập", ucpn);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XemHoaDon hd = new XemHoaDon();
            addNewTab("Xem Hóa Đơn Bán", hd);
        }

        private void UCNhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhanVien ucnhanvien = new NhanVien();
            addNewTab("Nhân viên", ucnhanvien);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaoCaoDoanhThu ucsanpham = new BaoCaoDoanhThu();
            addNewTab("Báo Cáo Doanh Thu", ucsanpham);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaoCaoNhap ucsanpham = new BaoCaoNhap();
            addNewTab("Báo Cáo Nhập", ucsanpham);
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongKeSP ucsanpham = new ThongKeSP();
            addNewTab("Thống kê sản phẩm", ucsanpham);
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaoCaoLoiNhuan ucsanpham = new BaoCaoLoiNhuan();
            addNewTab("Báo Cáo Lợi Nhuận", ucsanpham);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BaoCaoLoiNhuan ucsanpham = new BaoCaoLoiNhuan();
            addNewTab("Báo Cáo Lợi Nhuận", ucsanpham);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ThongKeSP ucsanpham = new ThongKeSP();
            addNewTab("Thống kê sản phẩm", ucsanpham);
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaocaoNVBH ucnhanvien = new BaocaoNVBH();
            addNewTab("Thống kê nhân viên", ucnhanvien);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BaocaoNVBH ucnhanvien = new BaocaoNVBH();
            addNewTab("Thống kê nhân viên", ucnhanvien);
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BanHangTrongNgay thongke = new BanHangTrongNgay();
            addNewTab("Thống kê bán hàng trong ngày", thongke);
        }
    }
}