namespace QL_ShopThoiTrang
{
    partial class InHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLyShopDataSet = new QL_ShopThoiTrang.QlyShopDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InHoaDonTableAdapter = new QL_ShopThoiTrang.QlyShopDSTableAdapters.InHoaDonTableAdapter();
            this.DataTableHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableHDTableAdapter = new QL_ShopThoiTrang.QlyShopDSTableAdapters.DataTableHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLyShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InHoaDonBindingSource
            // 
            this.InHoaDonBindingSource.DataMember = "InHoaDon";
            this.InHoaDonBindingSource.DataSource = this.QLyShopDataSet;
            // 
            // QLyShopDataSet
            // 
            this.QLyShopDataSet.DataSetName = "QLyShopDataSet";
            this.QLyShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_ShopThoiTrang.HoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(710, 532);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.InHoaDonBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QL_ShopThoiTrang.HoaDon.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(710, 532);
            this.reportViewer2.TabIndex = 1;
            // 
            // InHoaDonTableAdapter
            // 
            this.InHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // DataTableHDBindingSource
            // 
            this.DataTableHDBindingSource.DataMember = "DataTableHD";
            this.DataTableHDBindingSource.DataSource = this.QLyShopDataSet;
            // 
            // DataTableHDTableAdapter
            // 
            this.DataTableHDTableAdapter.ClearBeforeFill = true;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 532);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLyShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource InHoaDonBindingSource;
        private QlyShopDS QLyShopDataSet;
        private QlyShopDSTableAdapters.InHoaDonTableAdapter InHoaDonTableAdapter;
        private System.Windows.Forms.BindingSource DataTableHDBindingSource;
        private QlyShopDSTableAdapters.DataTableHDTableAdapter DataTableHDTableAdapter;
    }
}