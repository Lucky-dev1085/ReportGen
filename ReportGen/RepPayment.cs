using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace ReportGen
{
    public partial class RepPayment : Form
    {
        private string dd;
        private string a;

        public RepPayment(string a, string dd)
        {
            InitializeComponent();
            this.dd = dd;
            this.a = a;

        }
        Christian_FranciscoEntities db = new Christian_FranciscoEntities();
        private void RepPayment_Load(object sender, EventArgs e)
        {


            ReportParameterCollection aw = new ReportParameterCollection();
            var myDataTable = new ChFraDataSet.VREPGENDataTable();
            var myTableAdapter = new ChFraDataSetTableAdapters.VREPGENTableAdapter();
            myTableAdapter.FillClient(myDataTable, dd);

            var myDataTable1 = new ChFraDataSet.PaymentDataTable();
            var myTableAdapter1 = new ChFraDataSetTableAdapters.PaymentTableAdapter();
            myTableAdapter1.FillClient(myDataTable1, dd);

            //myDataTable1.Clear();
            var rds = new ReportDataSource("DataSet1", myDataTable as DataTable);
            var rds1 = new ReportDataSource("DataSet2", myDataTable1 as DataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rds1);
            aw.Add(new ReportParameter("Parameter1", dd.ToString()));
            aw.Add(new ReportParameter("UserID", a.ToString()));


            //aw.Add(new ReportParameter("UserID", a.ToString()));
            this.reportViewer1.LocalReport.SetParameters(aw);
            DesMethod();
            this.reportViewer1.RefreshReport();
        }
        private void DesMethod()
        {
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            System.Drawing.Printing.PaperSize size = new PaperSize("A4", 1000, 1100);
            double s, d;
            s = 60;
            d = 0;
            pg.Landscape = true;
            size.RawKind = (int)PaperKind.Letter;
            pg.PaperSize = size;
            pg.Margins.Top = 25;
            pg.Margins.Bottom = 25;
            pg.Margins.Left = Convert.ToInt32(s);
            pg.Margins.Right = Convert.ToInt32(d);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 75;
            reportViewer1.SetPageSettings(pg);
            reportViewer1.RefreshReport();
        }

    }
}
