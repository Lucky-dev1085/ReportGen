using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ReportGen
{
    public partial class frmPaymentTicket : Form
    {
        private string strFecha, strFolioPago, strFolio, strClient, strTotal, strAbonos, strSaldo;
        private string printerName;
        DataSet dsMyDataSet = new DataSet();

        public frmPaymentTicket(string printerName, string strFecha, string strFolioPago, string strFolio, string strClient, string strTotal, string strAbonos, string strSaldo)
        {
            InitializeComponent();

            this.printerName = printerName;
            this.strFecha = strFecha;
            this.strFolioPago = strFolioPago;
            this.strFolio = strFolio;
            this.strClient = strClient;
            this.strTotal = strTotal;
            this.strAbonos = strAbonos;
            this.strSaldo = strSaldo;
        }

        private void SetupDataSet()
        {
            //create 1st DataTable to hold some report data  
            System.Data.DataTable myTable0 = new DataTable("myTable0");
            System.Data.DataColumn column;
            System.Data.DataRow row;
            //create 3 columns  
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Fecha";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.  
            myTable0.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Folio";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.  
            myTable0.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FolioPago";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.  
            myTable0.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Clientes";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.  
            myTable0.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Total";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.  
            myTable0.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Abonos";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.  
            myTable0.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Saldo";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.  
            myTable0.Columns.Add(column);
            //add a row of data  
            row = myTable0.NewRow();
            row["Fecha"] = this.strFecha;
            row["Folio"] = this.strFolio;
            row["FolioPago"] = this.strFolioPago;
            row["Clientes"] = this.strClient;
            row["Total"] = this.strTotal;
            row["Abonos"] = this.strAbonos;
            row["Saldo"] = this.strSaldo;
            //add the row of data to the table  
            myTable0.Rows.Add(row);
            //add myTable0 to global dataset  
            this.dsMyDataSet.Tables.Add(myTable0);//dsMyDataSet.Tables[0] object;  
        }

        private Microsoft.Reporting.WinForms.ReportDataSource GetMyDataTable(int i)
        {
            //form the datasource name - you need a naming convention for this to work  
            string sDataSourceName = "DataSet" + i.ToString().Trim();
            //the line above will generate datasource names of "Reportdata_Table0" and  
            //"Reportdata_Table1" for our 2 tabled dataset - we just need to ensure our .rdlc  
            //report has been designed to receive 2 datasources with these same names, and that  
            //the columns match up pecisely one-to-one for each table.  
            //return the relevant dataset table  
            return new Microsoft.Reporting.WinForms.ReportDataSource(sDataSourceName,
            this.dsMyDataSet.Tables[i]);
        }

        private void frmPaymentTicket_Load(object sender, EventArgs e)
        {
            try
            {
                ReportParameterCollection aw = new ReportParameterCollection();

                this.SetupDataSet();

                for (int i = 0; i < this.dsMyDataSet.Tables.Count; i++)
                {
                    this.reportViewer2.LocalReport.DataSources.Add(this.GetMyDataTable(i));
                }

                this.reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                //this.reportViewer2.LocalReport.SetParameters(aw);
                //MessageBox.Show(printerName, "", MessageBoxButtons.OK);
                DesMethod();
                this.reportViewer2.RefreshReport();

                this.Close();
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
            System.Drawing.Printing.PaperSize size = new PaperSize("Custom", 500, 500);
            size = reportViewer2.LocalReport.GetDefaultPageSettings().PaperSize;
            double s, d;
            s = 0;
            d = 0;
            pg.Landscape = false;
            
            //size.RawKind = (int)PaperKind.Letter;
            pg.PaperSize = size;
            pg.Margins.Top = 1;
            pg.Margins.Bottom = 5;
            pg.Margins.Left = Convert.ToInt32(s);
            pg.Margins.Right = Convert.ToInt32(d);

            pg.PrinterSettings.PrinterName = printerName;

            reportViewer2.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer2.ZoomMode = ZoomMode.Percent;
            reportViewer2.ZoomPercent = 100;
            reportViewer2.SetPageSettings(pg);
            reportViewer2.RefreshReport();

            Print(reportViewer2.LocalReport, pg);

        }
  

        public void Print(LocalReport report, PageSettings pageSettings)
        {
            string deviceInfo =
                $@"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>{pageSettings.PaperSize.Width * 100}in</PageWidth>
                <PageHeight>{pageSettings.PaperSize.Height * 100}in</PageHeight>
                <MarginTop>{pageSettings.Margins.Top * 100}in</MarginTop>
                <MarginLeft>{pageSettings.Margins.Left * 100}in</MarginLeft>
                <MarginRight>{pageSettings.Margins.Right * 100}in</MarginRight>
                <MarginBottom>{pageSettings.Margins.Bottom * 100}in</MarginBottom>
            </DeviceInfo>";

            Warning[] warnings;
            var streams = new List<Stream>();
            var currentPageIndex = 0;

            report.Render("Image", deviceInfo,
                (name, fileNameExtension, encoding, mimeType, willSeek) =>
                {
                    var stream = new MemoryStream();
                    streams.Add(stream);
                    return stream;
                }, out warnings);

            foreach (Stream stream in streams)
                stream.Position = 0;

            if (streams == null || streams.Count == 0)
                throw new Exception("Error: no stream to print.");

            var printDocument = new PrintDocument();
            printDocument.DefaultPageSettings = pageSettings;
            if (!printDocument.PrinterSettings.IsValid)
                throw new Exception("Error: cannot find the default printer.");
            else
            {
                printDocument.PrintPage += (sender, e) =>
                {
                    Metafile pageImage = new Metafile(streams[currentPageIndex]);
                    Rectangle adjustedRect = new Rectangle(
                        e.PageBounds.Left - (int)e.PageSettings.HardMarginX,
                        e.PageBounds.Top - (int)e.PageSettings.HardMarginY,
                        e.PageBounds.Width,
                        e.PageBounds.Height);
                    e.Graphics.FillRectangle(Brushes.White, adjustedRect);
                    e.Graphics.DrawImage(pageImage, adjustedRect);
                    currentPageIndex++;
                    e.HasMorePages = (currentPageIndex < streams.Count);
                    e.Graphics.DrawRectangle(Pens.Red, adjustedRect);
                };
                printDocument.EndPrint += (Sender, e) =>
                {
                    if (streams != null)
                    {
                        foreach (Stream stream in streams)
                            stream.Close();
                        streams = null;
                    }
                };
                printDocument.Print();
            }
        }

    }
}
