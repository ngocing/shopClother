namespace QL_ShopThoiTrang
{
    partial class InPhieuNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NhapKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLyShopDataSet = new QL_ShopThoiTrang.QlyShopDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NhapKhoTableAdapter = new QL_ShopThoiTrang.QlyShopDSTableAdapters.NhapKhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NhapKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLyShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // NhapKhoBindingSource
            // 
            this.NhapKhoBindingSource.DataMember = "NhapKho";
            this.NhapKhoBindingSource.DataSource = this.QLyShopDataSet;
            // 
            // QLyShopDataSet
            // 
            this.QLyShopDataSet.DataSetName = "QLyShopDataSet";
            this.QLyShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "NhapKho";
            reportDataSource1.Value = this.NhapKhoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_ShopThoiTrang.PhieuNhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1264, 789);
            this.reportViewer1.TabIndex = 0;
            // 
            // NhapKhoTableAdapter
            // 
            this.NhapKhoTableAdapter.ClearBeforeFill = true;
            // 
            // InPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 789);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InPhieuNhap";
            this.Text = "In phiếu nhập hàng";
            this.Load += new System.EventHandler(this.InPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhapKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLyShopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhapKhoBindingSource;
        private QlyShopDS QLyShopDataSet;
        private QlyShopDSTableAdapters.NhapKhoTableAdapter NhapKhoTableAdapter;
    }
}