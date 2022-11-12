namespace QL_ShopThoiTrang
{
    partial class ThongKeSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radall = new System.Windows.Forms.RadioButton();
            this.radtop = new System.Windows.Forms.RadioButton();
            this.radlast = new System.Windows.Forms.RadioButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.qLyShopDataSet = new QL_ShopThoiTrang.QlyShopDS();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.san_PhamTableAdapter = new QL_ShopThoiTrang.QlyShopDSTableAdapters.San_PhamTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.don_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLyShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radall
            // 
            this.radall.AutoSize = true;
            this.radall.Location = new System.Drawing.Point(16, 30);
            this.radall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radall.Name = "radall";
            this.radall.Size = new System.Drawing.Size(70, 24);
            this.radall.TabIndex = 0;
            this.radall.TabStop = true;
            this.radall.Text = "Tất cả";
            this.radall.UseVisualStyleBackColor = true;
            this.radall.CheckedChanged += new System.EventHandler(this.radall_CheckedChanged);
            // 
            // radtop
            // 
            this.radtop.AutoSize = true;
            this.radtop.Location = new System.Drawing.Point(112, 30);
            this.radtop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radtop.Name = "radtop";
            this.radtop.Size = new System.Drawing.Size(89, 24);
            this.radtop.TabIndex = 1;
            this.radtop.TabStop = true;
            this.radtop.Text = "Bán chạy";
            this.radtop.UseVisualStyleBackColor = true;
            this.radtop.CheckedChanged += new System.EventHandler(this.radtop_CheckedChanged);
            // 
            // radlast
            // 
            this.radlast.AutoSize = true;
            this.radlast.Location = new System.Drawing.Point(227, 30);
            this.radlast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radlast.Name = "radlast";
            this.radlast.Size = new System.Drawing.Size(140, 24);
            this.radlast.TabIndex = 2;
            this.radlast.TabStop = true;
            this.radlast.Text = "Không bán được";
            this.radlast.UseVisualStyleBackColor = true;
            this.radlast.CheckedChanged += new System.EventHandler(this.radlast_CheckedChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.radtop);
            this.groupControl2.Controls.Add(this.radlast);
            this.groupControl2.Controls.Add(this.radall);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1049, 60);
            this.groupControl2.TabIndex = 72;
            this.groupControl2.Text = "Danh sách lọc";
            // 
            // qLyShopDataSet
            // 
            this.qLyShopDataSet.DataSetName = "QLyShopDataSet";
            this.qLyShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "San_Pham";
            this.sanPhamBindingSource.DataSource = this.qLyShopDataSet;
            // 
            // san_PhamTableAdapter
            // 
            this.san_PhamTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_sp,
            this.ten_sp,
            this.loaisp,
            this.nhanhieu,
            this.don_gia,
            this.nhap,
            this.ban,
            this.ton});
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 534);
            this.dataGridView1.TabIndex = 71;
            // 
            // ma_sp
            // 
            this.ma_sp.DataPropertyName = "ma_sp";
            this.ma_sp.HeaderText = "Mã sp";
            this.ma_sp.Name = "ma_sp";
            this.ma_sp.ReadOnly = true;
            // 
            // ten_sp
            // 
            this.ten_sp.DataPropertyName = "ten_sp";
            this.ten_sp.HeaderText = "Tên sản phẩm";
            this.ten_sp.Name = "ten_sp";
            this.ten_sp.ReadOnly = true;
            // 
            // loaisp
            // 
            this.loaisp.DataPropertyName = "ten_loai";
            this.loaisp.HeaderText = "Loại sản phẩm";
            this.loaisp.Name = "loaisp";
            this.loaisp.ReadOnly = true;
            // 
            // nhanhieu
            // 
            this.nhanhieu.DataPropertyName = "ten_hieu";
            this.nhanhieu.HeaderText = "Nhãn hiệu";
            this.nhanhieu.Name = "nhanhieu";
            this.nhanhieu.ReadOnly = true;
            // 
            // don_gia
            // 
            this.don_gia.DataPropertyName = "don_gia";
            this.don_gia.HeaderText = "Đơn giá";
            this.don_gia.Name = "don_gia";
            this.don_gia.ReadOnly = true;
            // 
            // nhap
            // 
            this.nhap.DataPropertyName = "nhap";
            this.nhap.HeaderText = "Sl nhập";
            this.nhap.Name = "nhap";
            this.nhap.ReadOnly = true;
            // 
            // ban
            // 
            this.ban.DataPropertyName = "ban";
            this.ban.HeaderText = "SL bán";
            this.ban.Name = "ban";
            this.ban.ReadOnly = true;
            // 
            // ton
            // 
            this.ton.DataPropertyName = "ton";
            this.ton.HeaderText = "Còn lại";
            this.ton.Name = "ton";
            this.ton.ReadOnly = true;
            // 
            // ThongKeSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupControl2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongKeSP";
            this.Size = new System.Drawing.Size(1049, 596);
            this.Load += new System.EventHandler(this.ThongKeSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLyShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radall;
        private System.Windows.Forms.RadioButton radtop;
        private System.Windows.Forms.RadioButton radlast;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private QlyShopDSTableAdapters.San_PhamTableAdapter san_PhamTableAdapter;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private QlyShopDS qLyShopDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn don_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ton;
    }
}
