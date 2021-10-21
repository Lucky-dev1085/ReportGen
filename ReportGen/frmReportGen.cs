using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace ReportGen
{
    public partial class frmReportGen : Form
    {
        const string ProgName = "Reporte de Notas de Venta";
        DataTable dtData = new DataTable();
        private static DataTable dtSticker = new DataTable();    
        private static string printername="";

        public frmReportGen()
        {
            InitializeComponent();
        }

        private static string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }

        public static PCPrint printer;
        public class PCPrint : PrintDocument
        {
            int left = 2, width = 300, wrapwidth = 295;
            public string fontName { get; set; }
            public float fontSize { get; set; }

            public PCPrint()
                : base()
            {
            }

            StringBuilder completedWord = null;
            private void WrapText(string statement, int Length, PrintPageEventArgs e)
            {
                float f = 0;
                string temp = "";
                f = e.Graphics.MeasureString(statement, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Width;
                if (statement.Length > Length)
                    temp = statement.Substring(0, Length).Substring(0, statement.Substring(0, Length).LastIndexOf(' '));
                else if (f > wrapwidth)
                    temp = statement.Substring(0, statement.Length).Substring(0, statement.Substring(0, statement.Length).LastIndexOf(' '));
                else
                    temp = statement;

                completedWord.AppendLine(temp);//cut the specifed legth from long string
                if (statement.Length > Length || f > wrapwidth)
                    WrapText(statement.Substring(temp.Length), Length, e);
            }


            protected override void OnBeginPrint(PrintEventArgs e)
            {
                try
                {
                    // Run base code
                    base.OnBeginPrint(e);
                    fontName = "Arial";
                    fontSize = 9;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            protected override void OnPrintPage(PrintPageEventArgs e)
            {
                try
                {
                    // Run base code
                    base.OnPrintPage(e);

                    RectangleF printArea;
                    Pen pRect = new Pen(Brushes.Black);
                    string text = "";

                    StringFormat strFormatFar = new StringFormat();
                    StringFormat strFormatCenter = new StringFormat();
                    StringFormat strFormatNear = new StringFormat();
                    strFormatFar.Alignment = StringAlignment.Far;
                    strFormatCenter.Alignment = StringAlignment.Center;
                    strFormatNear.Alignment = StringAlignment.Near;

                    float y = 0;
                    foreach (DataRow row in dtSticker.Rows)
                    {
                        text = "HORTEL CORTINAS Y PERSIANAS";
                        printArea = new RectangleF(left, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Bold), Brushes.Black, printArea, strFormatNear);

                        text = row["Fecha"].ToString();
                        printArea = new RectangleF(left, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea,strFormatFar);

                        text = row["Cliente"].ToString();
                        printArea = new RectangleF(left, printArea.Bottom+8, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Folio: " + row["Folio"].ToString();                        
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatFar);

                        completedWord = new StringBuilder();
                        text = row["Producto"].ToString() + " " + row["Detalles1"].ToString() + " " + row["Detalles2"].ToString();
                        WrapText(text, 40, e);
                        printArea = new RectangleF(left, printArea.Bottom+8, width, e.Graphics.MeasureString(completedWord.ToString(), new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(completedWord.ToString(), new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        y = printArea.Bottom + 20;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public static void PrintOrder()
        {
            try
            {
                printer = new PCPrint();
                printer.PrinterSettings.PrinterName = printername;
                printer.PrinterSettings.Copies = 1;
                printer.Print();
            }
            catch (Exception ex) { throw ex; }
        }


        private void frmReportGen_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("c:\\EFAXUPT.dll"))
                    Application.Exit();
                //if (!string.IsNullOrEmpty(Properties.Settings.Default.server) || !string.IsNullOrEmpty(Properties.Settings.Default.dbname) || !string.IsNullOrEmpty(Properties.Settings.Default.server) || !string.IsNullOrEmpty(Properties.Settings.Default.password))

                    if (!string.IsNullOrEmpty(Properties.Settings.Default.server) || !string.IsNullOrEmpty(Properties.Settings.Default.dbname) || !string.IsNullOrEmpty(Properties.Settings.Default.server))
                {                    
                    if (!utlReportGen.checkConnection())
                    {
                        MessageBox.Show("Error! Not able to connect to database.", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                    MessageBox.Show("Please setup DB details to connect.", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Information);


                chkTotals.Checked = Properties.Settings.Default.chktotals;
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    cmbPrinter.Items.Add(printer);
                }
                cmbPrinter.Text = GetDefaultPrinter();

                dgvData.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dtpFromDate.Value = DateTime.Today.AddDays(-7);
                dtData.Columns.AddRange(new DataColumn[] {
                                        new DataColumn(" ",System.Type.GetType("System.Boolean")),
                                        new DataColumn("Fecha", System.Type.GetType("System.DateTime")),
                                        new DataColumn("Folio"),
                                        new DataColumn("Cliente"),
                                        new DataColumn("Unidades"),
                                        new DataColumn("Producto"),
                                        new DataColumn("Detalles1"),
                                        new DataColumn("Detalles2"),
                                        new DataColumn("Total", System.Type.GetType("System.Double"))});

                dgvData.DataSource = dtData;

               // DataGridViewCheckBoxColumn chkForSticker = new DataGridViewCheckBoxColumn();
                //dgvData.Columns.Insert(0, chkForSticker);
                dgvData.Columns[0].Frozen = true;
                dgvData.Columns[0].Width = 25;
                dgvData.Columns[1].Width = 90;
                dgvData.Columns[2].Width = 50;
                dgvData.Columns[4].Width = 70;
                dgvData.Columns[5].Width = 100;
                dgvData.Columns[8].Width = 70;
                dgvData.Columns["Fecha"].DefaultCellStyle.Format = "dd-MMM-yyyy";
                dgvData.Columns["Total"].DefaultCellStyle.Format = "#,##0.00";
                dgvData.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                if (Properties.Settings.Default.connStr.Length > 0)
                {
                    dtData.Rows.Clear();
                    utlReportGen.GetRecords(dtpFromDate.Value, dtpToDate.Value, dtData);
                    dgvData.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFetchData_Click(object sender, EventArgs e)
        {
            try
            {
                if (!utlReportGen.checkConnection())
                {
                    MessageBox.Show("Error! Not able to connect to database.", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dtData.Rows.Clear();
                utlReportGen.GetRecords(dtpFromDate.Value, dtpToDate.Value, dtData);
                dgvData.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFromDate.Value>dtpToDate.Value)
            {
                MessageBox.Show("From Date should be less than To Date", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFromDate.Value = DateTime.Today.AddDays(-7);
            }
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFromDate.Value > dtpToDate.Value)
            {
                MessageBox.Show("To Date should be greater than From Date", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpToDate.Value = DateTime.Today;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if(dgvData.Rows.Count==0)
            //    {
            //        MessageBox.Show("No data present to generate report.", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //    Properties.Settings.Default.chktotals = chkTotals.Checked;
            //    Properties.Settings.Default.Save();
            //    frmReport objForm = new frmReport(dtpFromDate.Value, dtpToDate.Value, Properties.Settings.Default.header1, Properties.Settings.Default.header2, Properties.Settings.Default.chktotals);
            //    objForm.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void btnSticker_Click(object sender, EventArgs e)
        {
            try
            {
                printername = cmbPrinter.Text;
                bool hasdata = false;
                dtSticker.Columns.Clear();
                dtSticker.Columns.AddRange(new DataColumn[] {
                                        new DataColumn("Fecha"),
                                        new DataColumn("Folio"),
                                        new DataColumn("Cliente"),
                                        new DataColumn("Producto"),
                                        new DataColumn("Detalles1"),
                                        new DataColumn("Detalles2")});
                foreach(DataGridViewRow row in dgvData.Rows)
                {
                    DataGridViewCheckBoxCell chkCell = row.Cells[0] as DataGridViewCheckBoxCell;
                    if(chkCell.Value.ToString().Equals("True"))
                    {
                        hasdata = true;
                        dtSticker.Rows.Clear();
                        dtSticker.Rows.Add(Convert.ToDateTime(row.Cells[1].Value).ToString("MM/dd/yyyy"), row.Cells[2].Value, row.Cells[3].Value, row.Cells[5].Value, row.Cells[6].Value, row.Cells[7].Value);
                        PrintOrder();
                    }
                }
                if(!hasdata)
                    MessageBox.Show("No ha seleccionado casillas a imprimir", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ppDialog_Load(object sender, EventArgs e)
        {
            try
            {
                PaperSize pSize = new PaperSize("Sticker", 900, 300);
                printer.DefaultPageSettings.PaperSize = pSize;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lnkSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSettings objForm = new frmSettings();
            objForm.ShowDialog();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUser ma = new FrmUser();
            ma.Show();
            this.Hide();
        }
    }
}
