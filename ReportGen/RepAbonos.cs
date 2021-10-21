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
    public partial class RepAbonos : Form
    {
        private string dd;
        private DateTime dtf;
        private DateTime dtt;
        private decimal df;
        private decimal dt;
        private string a;
        private int nBtnNum;

        public RepAbonos(DateTime dtf, DateTime dtt, String a, int nNum)
        {
            InitializeComponent();
            this.dtf = dtf;
            this.dtt = dtt;
            this.a = a;
            this.nBtnNum = nNum;
        }

        public RepAbonos(decimal df, decimal dt, String a, int nNum)
        {
            InitializeComponent();
            this.df = df;
            this.dt = dt;
            this.a = a;
            this.nBtnNum = nNum;
        }

        Christian_FranciscoEntities db = new Christian_FranciscoEntities();
        private void RepAbonos_Load(object sender, EventArgs e)
        {
            ReportParameterCollection aw = new ReportParameterCollection();
            DateTime ad = Convert.ToDateTime(dtf.ToShortDateString());
            DateTime ad2 = Convert.ToDateTime(dtt.ToShortDateString());
            var myDataTable = new ChFraDataSet.VREPGENDataTable();
            var myTableAdapter = new ChFraDataSetTableAdapters.VREPGENTableAdapter();
            

            var myDataTable1 = new ChFraDataSet.PaymentDataTable();
            var myTableAdapter1 = new ChFraDataSetTableAdapters.PaymentTableAdapter();

            try
            {
                if (this.nBtnNum == 1)
                {
                    myTableAdapter1.FillByDate(myDataTable1, ad, ad2);
                    myTableAdapter.FillByDate(myDataTable, ad, ad2);
                }
                else if (this.nBtnNum == 2)
                {
                    myTableAdapter1.FillByPay(myDataTable1, this.df, this.dt);
                    myTableAdapter.FillByPay(myDataTable, this.df, this.dt);
                }
            }
            catch
            {

            }
            

            var rds = new ReportDataSource("DataSet1", myDataTable as DataTable);
            var rds1 = new ReportDataSource("DataSet2", myDataTable1 as DataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rds1);
            //aw.Add(new ReportParameter("Parameter1", dd.ToString()));
            aw.Add(new ReportParameter("UserID", a.ToString()));


            //aw.Add(new ReportParameter("UserID", a.ToString()));
            this.reportViewer1.LocalReport.SetParameters(aw);
            DesMethod();
            this.reportViewer1.RefreshReport();
        }
        private void DesMethod()
        {
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            System.Drawing.Printing.PaperSize size = new PaperSize("A4", 1050, 1050);
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
