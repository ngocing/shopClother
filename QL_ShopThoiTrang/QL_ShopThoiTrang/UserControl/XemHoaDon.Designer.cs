namespace QL_ShopThoiTrang
{
    partial class XemHoaDon
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhacc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tri_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(4, 330);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(987, 331);
            this.dataGridView2.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma_hd";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ma_sp";
            this.Column6.HeaderText = "Mã sản phẩm";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten_sp";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "so_luong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "don_gia";
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "thanh_tien";
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_hd,
            this.ngay_nhap,
            this.nhacc,
            this.Column7,
            this.Manv,
            this.tri_gia});
            this.dataGridView1.Location = new System.Drawing.Point(4, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(987, 207);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // ma_hd
            // 
            this.ma_hd.DataPropertyName = "ma_hd";
            this.ma_hd.HeaderText = "Mã hóa đơn";
            this.ma_hd.Name = "ma_hd";
            this.ma_hd.ReadOnly = true;
            // 
            // ngay_nhap
            // 
            this.ngay_nhap.DataPropertyName = "ngay_lap";
            this.ngay_nhap.HeaderText = "Ngày nhập";
            this.ngay_nhap.Name = "ngay_nhap";
            this.ngay_nhap.ReadOnly = true;
            // 
            // nhacc
            // 
            this.nhacc.DataPropertyName = "ma_kh";
            this.nhacc.HeaderText = "Mã khách hàng";
            this.nhacc.Name = "nhacc";
            this.nhacc.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ten_kh";
            this.Column7.HeaderText = "Tên KH";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Manv
            // 
            this.Manv.DataPropertyName = "ma_nv";
            this.Manv.HeaderText = "Mã nhân viên";
            this.Manv.Name = "Manv";
            this.Manv.ReadOnly = true;
            // 
            // tri_gia
            // 
            this.tri_gia.DataPropertyName = "tri_gia";
            this.tri_gia.HeaderText = "Trị giá";
            this.tri_gia.Name = "tri_gia";
            this.tri_gia.ReadOnly = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(344, 16);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(100, 28);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "QUAY LẠI";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(236, 17);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 28);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "TÌM KIẾM";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(95, 18);
            this.txtma.Margin = new System.Windows.Forms.Padding(4);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(133, 26);
            this.txtma.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã hóa đơn";
            // 
            // XemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XemHoaDon";
            this.Size = new System.Drawing.Size(995, 673);
            this.Load += new System.EventHandler(this.XemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhacc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tri_gia;
    }
}
