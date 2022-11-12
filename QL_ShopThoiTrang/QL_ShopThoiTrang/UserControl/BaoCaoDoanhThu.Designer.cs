namespace QL_ShopThoiTrang
{
    partial class BaoCaoDoanhThu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DoanhThuNamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLyShopDataSet = new QL_ShopThoiTrang.QlyShopDS();
            this.DoanhThuNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChonThang = new System.Windows.Forms.ComboBox();
            this.dateChonNgay = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapNam = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTheoNgay = new System.Windows.Forms.RadioButton();
            this.radTheoNam = new System.Windows.Forms.RadioButton();
            this.radTheoThang = new System.Windows.Forms.RadioButton();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_lap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tri_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThuTableAdapter = new QL_ShopThoiTrang.QlyShopDSTableAdapters.DoanhThuTableAdapter();
            this.DoanhThuNgayTableAdapter = new QL_ShopThoiTrang.QlyShopDSTableAdapters.DoanhThuNgayTableAdapter();
            this.DoanhThuNamTableAdapter = new QL_ShopThoiTrang.QlyShopDSTableAdapters.DoanhThuNamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuNamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLyShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateChonNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateChonNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapNam.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DoanhThuNamBindingSource
            // 
            this.DoanhThuNamBindingSource.DataMember = "DoanhThuNam";
            this.DoanhThuNamBindingSource.DataSource = this.QLyShopDataSet;
            // 
            // QLyShopDataSet
            // 
            this.QLyShopDataSet.DataSetName = "QLyShopDataSet";
            this.QLyShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DoanhThuNgayBindingSource
            // 
            this.DoanhThuNgayBindingSource.DataMember = "DoanhThuNgay";
            this.DoanhThuNgayBindingSource.DataSource = this.QLyShopDataSet;
            // 
            // DoanhThuBindingSource
            // 
            this.DoanhThuBindingSource.DataMember = "DoanhThu";
            this.DoanhThuBindingSource.DataSource = this.QLyShopDataSet;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Doanh thu";
            this.splitContainerControl1.Size = new System.Drawing.Size(1249, 705);
            this.splitContainerControl1.SplitterPosition = 267;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.cmbChonThang);
            this.groupControl1.Controls.Add(this.dateChonNgay);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtNhapNam);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(267, 705);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Doanh thu";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 43;
            this.button1.Text = "XEM DOANH THU";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 355);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Chọn tháng:";
            // 
            // cmbChonThang
            // 
            this.cmbChonThang.Enabled = false;
            this.cmbChonThang.FormattingEnabled = true;
            this.cmbChonThang.Location = new System.Drawing.Point(106, 352);
            this.cmbChonThang.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChonThang.Name = "cmbChonThang";
            this.cmbChonThang.Size = new System.Drawing.Size(141, 28);
            this.cmbChonThang.TabIndex = 40;
            // 
            // dateChonNgay
            // 
            this.dateChonNgay.EditValue = null;
            this.dateChonNgay.Enabled = false;
            this.dateChonNgay.Location = new System.Drawing.Point(106, 283);
            this.dateChonNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dateChonNgay.Name = "dateChonNgay";
            this.dateChonNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateChonNgay.Properties.Appearance.Options.UseFont = true;
            this.dateChonNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateChonNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateChonNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateChonNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateChonNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateChonNgay.Size = new System.Drawing.Size(141, 28);
            this.dateChonNgay.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Chọn ngày:";
            // 
            // txtNhapNam
            // 
            this.txtNhapNam.Enabled = false;
            this.txtNhapNam.Location = new System.Drawing.Point(106, 419);
            this.txtNhapNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapNam.Name = "txtNhapNam";
            this.txtNhapNam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNhapNam.Properties.Appearance.Options.UseFont = true;
            this.txtNhapNam.Size = new System.Drawing.Size(141, 28);
            this.txtNhapNam.TabIndex = 37;
            this.txtNhapNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapNam_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nhập năm: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radTheoNgay);
            this.groupBox1.Controls.Add(this.radTheoNam);
            this.groupBox1.Controls.Add(this.radTheoThang);
            this.groupBox1.Location = new System.Drawing.Point(7, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(240, 208);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu thống kê theo:";
            // 
            // radTheoNgay
            // 
            this.radTheoNgay.AutoSize = true;
            this.radTheoNgay.Location = new System.Drawing.Point(8, 43);
            this.radTheoNgay.Margin = new System.Windows.Forms.Padding(4);
            this.radTheoNgay.Name = "radTheoNgay";
            this.radTheoNgay.Size = new System.Drawing.Size(186, 24);
            this.radTheoNgay.TabIndex = 31;
            this.radTheoNgay.TabStop = true;
            this.radTheoNgay.Text = "THỐNG KÊ THEO NGÀY";
            this.radTheoNgay.UseVisualStyleBackColor = true;
            this.radTheoNgay.CheckedChanged += new System.EventHandler(this.radTheoNgay_CheckedChanged);
            // 
            // radTheoNam
            // 
            this.radTheoNam.AutoSize = true;
            this.radTheoNam.Location = new System.Drawing.Point(8, 158);
            this.radTheoNam.Margin = new System.Windows.Forms.Padding(4);
            this.radTheoNam.Name = "radTheoNam";
            this.radTheoNam.Size = new System.Drawing.Size(182, 24);
            this.radTheoNam.TabIndex = 33;
            this.radTheoNam.TabStop = true;
            this.radTheoNam.Text = "THỐNG KÊ THEO NĂM";
            this.radTheoNam.UseVisualStyleBackColor = true;
            this.radTheoNam.CheckedChanged += new System.EventHandler(this.radTheoNam_CheckedChanged);
            // 
            // radTheoThang
            // 
            this.radTheoThang.AutoSize = true;
            this.radTheoThang.Location = new System.Drawing.Point(8, 101);
            this.radTheoThang.Margin = new System.Windows.Forms.Padding(4);
            this.radTheoThang.Name = "radTheoThang";
            this.radTheoThang.Size = new System.Drawing.Size(198, 24);
            this.radTheoThang.TabIndex = 32;
            this.radTheoThang.TabStop = true;
            this.radTheoThang.Text = "THỐNG KÊ THEO THÁNG";
            this.radTheoThang.UseVisualStyleBackColor = true;
            this.radTheoThang.CheckedChanged += new System.EventHandler(this.radTheoThang_CheckedChanged);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.reportViewer3);
            this.splitContainerControl2.Panel1.Controls.Add(this.reportViewer2);
            this.splitContainerControl2.Panel1.Controls.Add(this.reportViewer1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(977, 705);
            this.splitContainerControl2.SplitterPosition = 446;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDoanhThuNam";
            reportDataSource1.Value = this.DoanhThuNamBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "QL_ShopThoiTrang.DoanhThuNam.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(977, 446);
            this.reportViewer3.TabIndex = 2;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetDoanhThuNgay";
            reportDataSource2.Value = this.DoanhThuNgayBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QL_ShopThoiTrang.DoanhThuNgay.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(977, 446);
            this.reportViewer2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DoanhThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_ShopThoiTrang.DoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(977, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_hd,
            this.ten_sp,
            this.ngay_lap,
            this.Column1,
            this.Column2,
            this.tri_gia});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(977, 254);
            this.dataGridView1.TabIndex = 20;
            // 
            // ma_hd
            // 
            this.ma_hd.DataPropertyName = "ma_hd";
            this.ma_hd.HeaderText = "Mã HĐ";
            this.ma_hd.Name = "ma_hd";
            this.ma_hd.ReadOnly = true;
            // 
            // ten_sp
            // 
            this.ten_sp.DataPropertyName = "ten_sp";
            this.ten_sp.HeaderText = "Tên sản phẩm";
            this.ten_sp.Name = "ten_sp";
            this.ten_sp.ReadOnly = true;
            // 
            // ngay_lap
            // 
            this.ngay_lap.DataPropertyName = "ngay_lap";
            this.ngay_lap.HeaderText = "Ngày lập";
            this.ngay_lap.Name = "ngay_lap";
            this.ngay_lap.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "so_luong";
            this.Column1.HeaderText = "Số lượng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "don_gia";
            this.Column2.HeaderText = "Đơn giá";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // tri_gia
            // 
            this.tri_gia.DataPropertyName = "tri_gia";
            this.tri_gia.HeaderText = "Trị giá";
            this.tri_gia.Name = "tri_gia";
            this.tri_gia.ReadOnly = true;
            // 
            // DoanhThuTableAdapter
            // 
            this.DoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // DoanhThuNgayTableAdapter
            // 
            this.DoanhThuNgayTableAdapter.ClearBeforeFill = true;
            // 
            // DoanhThuNamTableAdapter
            // 
            this.DoanhThuNamTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaoCaoDoanhThu";
            this.Size = new System.Drawing.Size(1249, 705);
            this.Load += new System.EventHandler(this.BaoCaoDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuNamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLyShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateChonNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateChonNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapNam.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChonThang;
        private DevExpress.XtraEditors.DateEdit dateChonNgay;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtNhapNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTheoNgay;
        private System.Windows.Forms.RadioButton radTheoNam;
        private System.Windows.Forms.RadioButton radTheoThang;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_lap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tri_gia;
        private System.Windows.Forms.BindingSource DoanhThuBindingSource;
        private QlyShopDS QLyShopDataSet;
        private QlyShopDSTableAdapters.DoanhThuTableAdapter DoanhThuTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource DoanhThuNgayBindingSource;
        private QlyShopDSTableAdapters.DoanhThuNgayTableAdapter DoanhThuNgayTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource DoanhThuNamBindingSource;
        private QlyShopDSTableAdapters.DoanhThuNamTableAdapter DoanhThuNamTableAdapter;
        private DevExpress.XtraEditors.SimpleButton button1;
    }
}
