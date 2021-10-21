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
    public partial class FormDEUDORES : Form
    {
        private DateTime dtf;
        private DateTime dtt;
        private decimal df;
        private decimal dt;
        private string a;
        private int nBtnNum;

        public FormDEUDORES(DateTime dtf, DateTime dtt, String a, int nNum)
        {
            InitializeComponent();
            this.dtf = dtf;
            this.dtt = dtt;
            this.a = a;
            this.nBtnNum = nNum;
        }

        public FormDEUDORES(decimal df, decimal dt, String a, int nNum)
        {
            InitializeComponent();
            this.df = df;
            this.dt = dt;
            this.a = a;
            this.nBtnNum = nNum;
        }

        private void FormDEUDORES_Load(object sender, EventArgs e)
        {
            ReportParameterCollection aw = new ReportParameterCollection();
            DateTime ad = Convert.ToDateTime(dtf.ToShortDateString());
            DateTime ad2 = Convert.ToDateTime(dtt.ToShortDateString());
            var myDataTable = new ChFraDataSet.DEUDORESDataTable();
            var myTableAdapter = new ChFraDataSetTableAdapters.DEUDORESTableAdapter();

            /*
            if(this.nBtnNum == 1)
                myTableAdapter.FillDateOb(myDataTable, ad, ad2);
            else if(this.nBtnNum == 2)
                myTableAdapter.FillByRangeOb(myDataTable, this.df, this.dt);
            else if (this.nBtnNum == 3)
                myTableAdapter.FillAbonosByRangeOb(myDataTable, ad, ad2);
            */
            if (this.nBtnNum == 1)
                myTableAdapter.FillDate(myDataTable, ad, ad2);
            else if (this.nBtnNum == 2)
                myTableAdapter.FillByRange(myDataTable, this.df, this.dt);
            else if (this.nBtnNum == 3)
                myTableAdapter.FillAbonosByRange(myDataTable, ad, ad2);

            /*
            String strClient = "";
            for (int i = 0; i < myDataTable.Count; i++)
            {
                if (strClient == myDataTable[i].Cliente)
                {
                    strClient = myDataTable[i].Cliente;
                    myDataTable[i].Cliente = "";
                    myDataTable[i].Total = 0;
                    myDataTable[i].Abonos = 0;
                    myDataTable[i].Saldo = 0;
                }
                else
                    strClient = myDataTable[i].Cliente;
            }
            */

            var rds = new ReportDataSource("DataSet1", myDataTable as DataTable);
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rds);
            if(this.nBtnNum != 2)
            {
                aw.Add(new ReportParameter("Parameter1", Convert.ToDateTime(ad).ToString("dd-MM-yyyy")));
                aw.Add(new ReportParameter("Parameter2", Convert.ToDateTime(ad2).ToString("dd-MM-yyyy")));
            }
            else
            {
                aw.Add(new ReportParameter("Parameter1", Convert.ToString(this.df)));
                aw.Add(new ReportParameter("Parameter2", Convert.ToString(this.dt)));
            }
            
            //aw.Add(new ReportParameter("Parameter3", r.ToString()));
            aw.Add(new ReportParameter("UserID", a.ToString()));
            this.reportViewer2.LocalReport.SetParameters(aw);
            DesMethod();
            this.reportViewer2.RefreshReport();
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
