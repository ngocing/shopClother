using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using BUS;

namespace QL_ShopThoiTrang
{
    public partial class BanHangTrongNgay : UserControl
    {
        public BanHangTrongNgay()
        {
            InitializeComponent();
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
            // Add data rows to the table.
            DataTable source = bieudo.BieudoNhanVien();
            foreach (DataRow item in source.Rows)
            {
                table.Rows.Add(new object[] { item[1].ToString(), item[1].ToString(), item[2].ToString() });
            }
            //table.Rows.Add(new object[] { "Jan", "Section1", 10 });
            //table.Rows.Add(new object[] { "Jan", "Section2", 20 });
            //table.Rows.Add(new object[] { "Feb", "Section1", 20 });
            //table.Rows.Add(new object[] { "Feb", "Section2", 30 });
            //table.Rows.Add(new object[] { "March", "Section1", 15 });
            //table.Rows.Add(new object[] { "March", "Section2", 25 });
            return table;
        }
        private void BanHangTrongNgay_Load(object sender, EventArgs e)
        {
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
            chart.SeriesNameTemplate.BeginText = "♥ ";
            // Dock the chart into its parent, and add it to the current form.
            chart.Dock = DockStyle.Fill;
            groupControl1.Controls.Add(chart);
        }
    }
}
