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
    public partial class frmReportProdDayDeliverd : Form
    {
        private DateTime dtf;
        private DateTime dtt;
        private string a;

        public frmReportProdDayDeliverd(DateTime dtf, DateTime dtt, string a)
        {
            InitializeComponent();
            this.dtf = dtf;
            this.dtt = dtt;
            this.a = a;
        }
        
        private void frmReportProdDayDeliverd_Load(object sender, EventArgs e)
        {
            try
            {
                ReportParameterCollection aw = new ReportParameterCollection();
                //DateTime ad = Convert.ToDateTime(dtf.ToShortDateString());
                //DateTime ad2 = Convert.ToDateTime(dtt.ToShortDateString());
                String ad = dtf.ToString("yyyy-MM-dd") + " 00:00:00";
                String ad2 = dtt.ToString("yyyy-MM-dd") + " 23:59:59";
                var myDataTable = new ChFraDataSet.VREPGENDataTable();
                var myTableAdapter = new ChFraDataSetTableAdapters.VREPGENTableAdapter();
                myTableAdapter.FillProdByDayDeliverd(myDataTable, ad, ad2);

                //myDataTable1.Clear();
                var rds = new ReportDataSource("DataSet1", myDataTable as DataTable);
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(rds);
                aw.Add(new ReportParameter("Parameter1", dtf.ToString("dd-MM-yyyy")));
                aw.Add(new ReportParameter("Parameter2", dtt.ToString("dd-MM-yyyy")));
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

        private void frmReportProdDayDeliverd_Load_1(object sender, EventArgs e)
        {

        }
    }
}
