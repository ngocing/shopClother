namespace QL_ShopThoiTrang
{
    partial class KhachHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dien_thoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtdc = new System.Windows.Forms.RichTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblma = new DevExpress.XtraEditors.LabelControl();
            this.txtemail = new DevExpress.XtraEditors.TextEdit();
            this.txtdt = new DevExpress.XtraEditors.TextEdit();
            this.datens = new DevExpress.XtraEditors.DateEdit();
            this.txtgt = new DevExpress.XtraEditors.TextEdit();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.txttim = new DevExpress.XtraEditors.TextEdit();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnre = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datens.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datens.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_kh,
            this.ten_kh,
            this.gioi_tinh,
            this.ngay_sinh,
            this.dia_chi,
            this.dien_thoai,
            this.email});
            this.dataGridView1.Location = new System.Drawing.Point(17, 266);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(895, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // ma_kh
            // 
            this.ma_kh.DataPropertyName = "ma_kh";
            this.ma_kh.HeaderText = "Mã KH";
            this.ma_kh.Name = "ma_kh";
            this.ma_kh.ReadOnly = true;
            // 
            // ten_kh
            // 
            this.ten_kh.DataPropertyName = "ten_kh";
            this.ten_kh.HeaderText = "Họ tên";
            this.ten_kh.Name = "ten_kh";
            this.ten_kh.ReadOnly = true;
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.DataPropertyName = "gioi_tinh";
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.ReadOnly = true;
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.DataPropertyName = "ngay_sinh";
            this.ngay_sinh.HeaderText = "Ngày sinh";
            this.ngay_sinh.Name = "ngay_sinh";
            this.ngay_sinh.ReadOnly = true;
            // 
            // dia_chi
            // 
            this.dia_chi.DataPropertyName = "dia_chi";
            this.dia_chi.HeaderText = "Địa chỉ";
            this.dia_chi.Name = "dia_chi";
            this.dia_chi.ReadOnly = true;
            // 
            // dien_thoai
            // 
            this.dien_thoai.DataPropertyName = "dien_thoai";
            this.dien_thoai.HeaderText = "Điện thoại";
            this.dien_thoai.Name = "dien_thoai";
            this.dien_thoai.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.txtdc);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.lblma);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtdt);
            this.groupBox1.Controls.Add(this.datens);
            this.groupBox1.Controls.Add(this.txtgt);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Location = new System.Drawing.Point(17, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(895, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(736, 27);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 20);
            this.labelControl9.TabIndex = 67;
            this.labelControl9.Text = "( * )";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(324, 63);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 20);
            this.labelControl8.TabIndex = 66;
            this.labelControl8.Text = "( * )";
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(463, 23);
            this.txtdc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(264, 59);
            this.txtdc.TabIndex = 14;
            this.txtdc.Text = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(377, 151);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 20);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Email";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(377, 107);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 20);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Điện thoại";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(377, 23);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 20);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Địa chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 156);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 20);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Ngày sinh";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 112);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 20);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Giới tính";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 68);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 20);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Họ tên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 23);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 20);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Mã";
            // 
            // lblma
            // 
            this.lblma.Location = new System.Drawing.Point(109, 23);
            this.lblma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(90, 20);
            this.lblma.TabIndex = 6;
            this.lblma.Text = "labelControl1";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(463, 148);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(265, 26);
            this.txtemail.TabIndex = 5;
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(463, 103);
            this.txtdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(265, 26);
            this.txtdt.TabIndex = 4;
            this.txtdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdt_KeyPress);
            // 
            // datens
            // 
            this.datens.EditValue = null;
            this.datens.Location = new System.Drawing.Point(109, 148);
            this.datens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datens.Name = "datens";
            this.datens.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datens.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datens.Size = new System.Drawing.Size(207, 26);
            this.datens.TabIndex = 2;
            // 
            // txtgt
            // 
            this.txtgt.Location = new System.Drawing.Point(109, 103);
            this.txtgt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(207, 26);
            this.txtgt.TabIndex = 1;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(109, 59);
            this.txtten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(207, 26);
            this.txtten.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(342, 218);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(234, 218);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 61;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(126, 218);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(100, 28);
            this.btnGhi.TabIndex = 60;
            this.btnGhi.Text = "GHI";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(17, 218);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(100, 28);
            this.btnCapnhat.TabIndex = 59;
            this.btnCapnhat.Text = "CẬP NHẬT";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(1062, 22);
            this.txttim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(167, 26);
            this.txttim.TabIndex = 63;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(993, 59);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 64;
            this.btnTim.Text = "TÌM THEO MÃ";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.Location = new System.Drawing.Point(920, 136);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(372, 494);
            this.dataGridView2.TabIndex = 65;
            // 
            // btnre
            // 
            this.btnre.Location = new System.Drawing.Point(1129, 58);
            this.btnre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnre.Name = "btnre";
            this.btnre.Size = new System.Drawing.Size(100, 28);
            this.btnre.TabIndex = 66;
            this.btnre.Text = "QUAY LẠI";
            this.btnre.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(917, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "HÓA ĐƠN CỦA KHÁCH HÀNG";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(993, 27);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(61, 20);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "Tìm kiếm";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnre);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KhachHang";
            this.Size = new System.Drawing.Size(1296, 634);
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datens.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datens.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl lblma;
        private DevExpress.XtraEditors.TextEdit txtemail;
        private DevExpress.XtraEditors.TextEdit txtdt;
        private DevExpress.XtraEditors.DateEdit datens;
        private DevExpress.XtraEditors.TextEdit txtgt;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox txtdc;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private DevExpress.XtraEditors.SimpleButton btnCapnhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dien_thoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private DevExpress.XtraEditors.TextEdit txttim;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DevExpress.XtraEditors.SimpleButton btnre;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}
