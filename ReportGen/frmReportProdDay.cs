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
using Microsoft.Reporting.WinForms;

namespace ReportGen
{
    public partial class frmReportProdDay : Form
    {
        private DateTime dtf;
        private DateTime dtt;
        private string a;
        private string amardor;
        private int rptType;

        public frmReportProdDay(DateTime dtf, DateTime dtt, string a)
        {
            InitializeComponent();
            this.dtf = dtf;
            this.dtt = dtt;
            this.a = a;
            this.rptType = 1;
        }

        public frmReportProdDay(DateTime dtf, DateTime dtt, string a, string amardor)
        {
            InitializeComponent();
            this.dtf = dtf;
            this.dtt = dtt;
            this.a = a;
            this.amardor = amardor;
            this.rptType = 2;
        }

        private void frmReportProdDay_Load(object sender, EventArgs e)
        {
            try
            {
                ReportParameterCollection aw = new ReportParameterCollection();
                DateTime ad = Convert.ToDateTime(dtf.ToShortDateString());
                DateTime ad2 = Convert.ToDateTime(dtt.ToShortDateString());
                var myDataTable = new ChFraDataSet.VREPGENDataTable();
                var myTableAdapter = new ChFraDataSetTableAdapters.VREPGENTableAdapter();
                if(rptType == 1) myTableAdapter.FillProdByDay(myDataTable, ad, ad2);
                else if(rptType == 2) myTableAdapter.FillProdByArmardo(myDataTable, ad, ad2, amardor);

                //myDataTable1.Clear();
                var rds = new ReportDataSource("DataSet1", myDataTable as DataTable);
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(rds);
                aw.Add(new ReportParameter("Parameter1", Convert.ToDateTime(ad).ToString("dd-MM-yyyy")));
                aw.Add(new ReportParameter("Parameter2", Convert.ToDateTime(ad2).ToString("dd-MM-yyyy")));
                aw.Add(new ReportParameter("UserID", a.ToString()));
                this.reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                this.reportViewer2.LocalReport.SetParameters(aw);
                DesMethod();
                this.reportViewer2.RefreshReport();
            }
            catch (Exception ex)
            {
                String strTmp = ex.ToString();
                MessageBox.Show(strTmp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            reportViewer2.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer2.ZoomMode = ZoomMode.Percent;
            reportViewer2.ZoomPercent = 75;
            reportViewer2.SetPageSettings(pg);
            reportViewer2.RefreshReport();
        }

    }
}
