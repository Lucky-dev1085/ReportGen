using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportGen
{
    public partial class FrmRepotStiker : Form
    {
        private string a;
        public FrmRepotStiker(string a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void FrmRepotStiker_Load(object sender, EventArgs e)
        {
            ReportParameterCollection aw = new ReportParameterCollection();

            var myDataTable = new ChFraDataSet.VREPGENDataTable();
            var myTableAdapter = new ChFraDataSetTableAdapters.VREPGENTableAdapter();
            myTableAdapter.Fill(myDataTable);

            //myDataTable1.Clear();
            var rds = new ReportDataSource("DataSet1", myDataTable as DataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            aw.Add(new ReportParameter("UserID", a.ToString()));
            this.reportViewer1.LocalReport.SetParameters(aw);
            this.reportViewer1.RefreshReport();
        }
    }
}
