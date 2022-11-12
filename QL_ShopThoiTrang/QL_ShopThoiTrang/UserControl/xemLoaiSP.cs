using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using DevExpress.XtraCharts;

namespace QL_ShopThoiTrang
{
    public partial class xemLoaiSP : UserControl
    {
        public xemLoaiSP()
        {
            InitializeComponent();
        }

        private void xemLoaiSP_Load(object sender, EventArgs e)
        {
            List<DTO_LoaiCha> listLoaiCha = BUS_LoaiCha.LayLoaiCha();
            vGridControl1.DataSource = listLoaiCha;

            BUS_LoaiSanPham bus_lsp = new BUS_LoaiSanPham();
                DataTable dt = bus_lsp.laydl();
                gridControl1.DataSource = dt;
                //List<DTO_SanPham> tbl1 = BUL_SanPham.LayListSP();
                //gridControl1.DataSource = tbl1;
            // Create a chart.
            ChartControl chart = new ChartControl();
            // Generate a data table and bind the chart to it.
            chart.DataSource = CreateChartData();
            // Specify data members to bind the chart's series template.
            chart.SeriesDataMember = "ID";
            chart.SeriesTemplate.ArgumentDataMember = "Section";
            chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });
            // Specify the template's series view.
            chart.SeriesTemplate.View = new StackedBarSeriesView();
            // Specify the template's name prefix.
            chart.SeriesNameTemplate.BeginText = "";
            // Dock the chart into its parent, and add it to the current form.
            chart.Dock = DockStyle.Fill;
            groupControl1.Controls.Add(chart);
        }
        BUS_BieuDo bieudo = new BUS_BieuDo();
        private DataTable CreateChartData()
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");
            // Add three columns to the table.
            table.Columns.Add("ID", typeof(String));
            table.Columns.Add("Section", typeof(String));
            table.Columns.Add("Value", typeof(Int32));
            DataTable source = bieudo.BieudoLoaiSanPham();
            foreach (DataRow item in source.Rows)
            {
                table.Rows.Add(new object[] { item[0].ToString(), item[0].ToString(), item[2].ToString() });
            }
            return table;
        }
    }
}
