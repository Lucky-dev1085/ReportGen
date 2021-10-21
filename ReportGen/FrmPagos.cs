using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportGen
{
    public partial class FrmPagos : Form
    {
        private string txtvar;
        private string a;
        private static DataTable dtTicket = new DataTable();
        private static string printername = "";

        public FrmPagos(string txtvar, string a)
        {
            InitializeComponent();
            this.txtvar = txtvar;
            this.a = a;
        }

        Christian_FranciscoEntities db = new Christian_FranciscoEntities();

        //int myVar;
        private void FrmPagos_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'chFraDataSet.admClientes' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'chFraDataSet.admClientes' table. You can move, or remove it, as needed.
            try
            {
                if(this.a != "SUPERUSER") this.fechaNDateTimePicker.Enabled = false;

                this.paymentTableAdapter.FillClient(this.chFraDataSet.Payment, txtvar);
                this.vREPGENTableAdapter.FillClient(this.chFraDataSet.VREPGEN, txtvar);
                this.admClientesTableAdapter.Fill(this.chFraDataSet.admClientes);
                clientesNTextBox.Text = a;
            }
            catch (Exception)
            {

            }
            //try
            //{

            //    var intData = (from p in db.VREPGENs
            //                   where p.Clientes == "saldo is 0"
            //                   select p.Folio).Distinct().ToList();
            //    comboBox1.DataSource = intData;
            //    comboBox1.DisplayMember = intData.ToString();
            //    comboBox1.ValueMember = intData.ToString();

            //}
            //catch (Exception)
            //{

            //}
            NewMethod();

            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                cmbPrinter.Items.Add(printer);
            }
            cmbPrinter.Text = GetDefaultPrinter();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int nFolioPago = 0;

                var query = (from ord in db.Payments
                             .AsEnumerable()
                             orderby ord.FolioPago descending
                             select ord).First();

                nFolioPago = (query.FolioPago == null ? 0 : (int)query.FolioPago);

                nFolioPago++;

                Payment payadd = new Payment();
                folioNComboBox.Text = comboBox1.Text;
                payadd.ClientesN = txtvar;
                payadd.FechaN = fechaNDateTimePicker.Value;
                payadd.FechaTime = fechaNDateTimePicker.Value.ToShortTimeString();
                payadd.FolioN = Convert.ToDecimal(folioNComboBox.Text);
                payadd.Payment1 = Convert.ToDecimal(paymentTextBox.Text);
                payadd.Observations = observationsTextBox.Text;
                payadd.FolioPago = nFolioPago;
                payadd.Authorize = 1;
                payadd.Recibio = a;
                db.Payments.Add(payadd);
                db.SaveChanges();
                this.paymentTableAdapter.FillClient(this.chFraDataSet.Payment, txtvar);
                gridControl1.Refresh();
                NewMethod();
            }
            catch (Exception ex)
            {

            } 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.a == "SUPERUSER")
            {
                string txtid = "";
                int ad;
                try
                {
                    GridView gridView = gridControl2.FocusedView as GridView;
                    object row = gridView.GetRow(gridView.FocusedRowHandle);
                    if (gridView != null)
                        txtid = gridView.GetFocusedRowCellDisplayText("ID");
                    ad = int.Parse(txtid.ToString());
                    var query = (from ord in db.Payments
                                 where ord.ID == ad
                                 select ord).First();

                    db.Payments.Remove(query);
                    db.SaveChanges();
                    this.paymentTableAdapter.FillClient(this.chFraDataSet.Payment, txtvar);
                    NewMethod();
                }
                catch (Exception ex)
                {
                }
            } else
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewMethod();

        }

        private void NewMethod()
        {
            // gridControl1.Refresh();
            gridControl2.Refresh();
            decimal sumNetPriceTotal = 0;
            decimal sumNetPriceAbonos = 0;
            try
            {
                /*for (int i = 0; i < gridView.DataRowCount; ++i)
                {
                    DataRow row = gridView.GetDataRow(i);
                    sumNetPrice += decimal.Parse(row["Total"].ToString());
                }*/
                List<VREPGEN> a = db.VREPGENs.SqlQuery("Select * from VREPGEN where Clientes = @a",
                        new SqlParameter("@a", txtvar)).ToList<VREPGEN>();
                for (int i = 0; i < a.Count; i++)
                {
                    sumNetPriceTotal += decimal.Parse(a[i].Total.ToString());
                }
                    label8.Text = (sumNetPriceTotal.ToString("N", CultureInfo.InvariantCulture));
            }
            catch (Exception ex)
            {

            }
            try
            {
                for (int i = 0; i < gridView2.DataRowCount; ++i)
                {
                    DataRow row = gridView2.GetDataRow(i);
                    sumNetPriceAbonos += decimal.Parse(row["Payment"].ToString());
                }
                label7.Text = (sumNetPriceAbonos.ToString("N", CultureInfo.InvariantCulture));
            }
            catch (Exception)
            {

            }
            decimal bal;
            //bal = (decimal.Parse(label8.Text)) - (decimal.Parse(label7.Text));
            bal = sumNetPriceTotal - sumNetPriceAbonos;
            label6.Text = bal.ToString("N", CultureInfo.InvariantCulture);
            paymentTextBox.Text = "";

            if(bal == 0)
            {
                try
                {

                    var intData = (from p in db.VREPGENs
                                   where p.Clientes == "saldo is 0"
                                   select p.Folio).Distinct().ToList();
                    comboBox1.DataSource = intData;
                    comboBox1.DisplayMember = intData.ToString();
                    comboBox1.ValueMember = intData.ToString();

                }
                catch (Exception)
                {

                }
            } else
            {
                try
                {

                    var intData = (from p in db.VREPGENs
                                   where p.Clientes == txtvar
                                   select p.Folio).Distinct().ToList();
                    comboBox1.DataSource = intData;
                    comboBox1.DisplayMember = intData.ToString();
                    comboBox1.ValueMember = intData.ToString();

                }
                catch (Exception)
                {

                }
            }
            
        }
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.paymentBindingSource.EndEdit();
                this.paymentTableAdapter.Update(this.chFraDataSet);
                NewMethod();
            }
            catch (Exception)
            {

            }
        }

        private void paymentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
            if (Regex.IsMatch(paymentTextBox.Text, @"\.\d\d"))
            {
                e.Handled = true;
            }
        }

        private void cRAZONSOCIALComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string txtcl = cRAZONSOCIALComboBox.SelectedValue.ToString();
                txtvar = txtcl;

                this.paymentTableAdapter.FillClient(this.chFraDataSet.Payment, txtcl);
                this.vREPGENTableAdapter.FillClient(this.chFraDataSet.VREPGEN, txtcl);
                //clientesNTextBox.Text = txtcl;
                NewMethod();
                paymentTextBox.Text = "";
                //try
                //{

                //    var intData = (from p in db.VREPGENs
                //                   where p.Clientes == txtcl
                //                   select p.Folio).Distinct().ToList();
                //    comboBox1.DataSource = intData;
                //    comboBox1.DisplayMember = intData.ToString();
                //    comboBox1.ValueMember = intData.ToString();
                    

                //}
                //catch (Exception)
                //{

                //}
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string dd = clientesNTextBox.Text;
                dd = txtvar;
                RepPago reppago = new RepPago(a,dd);
                reppago.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void FrmPagos_Shown(object sender, EventArgs e)
        {
            NewMethod();
        }


        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            string txtvar = "";
            try
            {
                GridControl grid = sender as GridControl;
                Point p = new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                GridView gridView = grid.GetViewAt(p) as GridView;
                if (gridView != null)
                {
                    txtvar = gridView.GetFocusedRowCellDisplayText("Clientes");
                }
                MessageBox.Show(txtvar);
                //FrmPagos cdd = new FrmPagos(txtvar, a);
                //  cdd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridControl grid = sender as GridControl;
                Point p = new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                GridView gridView = grid.GetViewAt(p) as GridView;

                if (gridView != null)
                {
                    int[] SelectedRowHandles = gridView.GetSelectedRows();

                    string strFecha = gridView.GetRowCellDisplayText(SelectedRowHandles[0], gridView.Columns[5]).ToString() + " " + gridView.GetRowCellDisplayText(SelectedRowHandles[0], gridView.Columns[14]).ToString();

                    string strFolioPago = gridView.GetRowCellDisplayText(SelectedRowHandles[0], gridView.Columns[1]).ToString();
                    string strFolio = gridView.GetRowCellDisplayText(SelectedRowHandles[0], gridView.Columns[3]).ToString();
                    string strClient = gridView.GetRowCellValue(SelectedRowHandles[0], gridView.Columns[4]).ToString();

                    string strProducto = "";
                    string strDetalles = "";
                    string strObservaciones = gridView.GetRowCellDisplayText(SelectedRowHandles[0], gridView.Columns[8]).ToString();

                    decimal sumNetPriceTotal = 0;
                    decimal sumNetPriceAbonos = 0;

                    string strPriceAbonos = gridView.GetRowCellValue(SelectedRowHandles[0], gridView.Columns[6]).ToString();

                    sumNetPriceAbonos = decimal.Parse(strPriceAbonos);

                    List<VREPGEN> a = db.VREPGENs.SqlQuery("Select * from VREPGEN where Clientes = @a",
                        new SqlParameter("@a", strClient)).ToList<VREPGEN>();
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i].Folio.ToString() == strFolio)
                        {
                            strProducto = a[i].Producto;
                            strDetalles = a[i].Detalles1 + " " + a[i].Detalles2;
                            sumNetPriceTotal += decimal.Parse(a[i].Total.ToString());
                        }
                    }

                    string strTotal = sumNetPriceTotal.ToString("N", CultureInfo.InvariantCulture);
                    string strAbonos = sumNetPriceAbonos.ToString("N", CultureInfo.InvariantCulture);
                    string strSaldo = (sumNetPriceTotal - sumNetPriceAbonos).ToString("N", CultureInfo.InvariantCulture);

                    string strSaldoTotal = label6.Text;

                    //frmPaymentTicket frm = new frmPaymentTicket(cmbPrinter.Text, strFecha, strFolioPago, strFolio, strClient, strTotal, strAbonos, strSaldo);
                    //frm.ShowDialog();

                    printername = cmbPrinter.Text;
                    bool hasdata = false;
                    dtTicket.Columns.Clear();
                    dtTicket.Columns.AddRange(new DataColumn[] {
                                        new DataColumn("Fecha"),
                                        new DataColumn("Folio"),
                                        new DataColumn("FolioPago"),
                                        new DataColumn("Clientes"),
                                        new DataColumn("Producto"),
                                        new DataColumn("Detalles"),
                                        new DataColumn("Total"),
                                        new DataColumn("Abonos"),
                                        new DataColumn("Saldo"),
                                        new DataColumn("SaldoTotal"),
                                        new DataColumn("Observaciones"),
                                        new DataColumn("Elaboro")});

                    dtTicket.Rows.Clear();
                    dtTicket.Rows.Add(strFecha, strFolio, strFolioPago, strClient, strProducto, strDetalles, strTotal, strAbonos, strSaldo, strSaldoTotal, strObservaciones, this.a);
                    PrintOrder();
                    
                    //if (!hasdata)
                    //    MessageBox.Show("No ha seleccionado casillas a imprimir", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmPagos_Closing(object sender, FormClosingEventArgs e)
        {
            if(this.a == "ABONOS")
                Application.Exit();
        }

        public static PCPrint printer;
        public class PCPrint : PrintDocument
        {
            int left = 5, width = 280, wrapwidth = 120;
            public string fontName = "Verdana";
            public float fontSize = 7;

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

                    float y = 5;
                    foreach (DataRow row in dtTicket.Rows)
                    {
                        text = "HORTEL CORTINAS Y PERSIANAS";
                        printArea = new RectangleF(left, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);

                        text = "Ignacio Ramirez 724";
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);

                        text = "Col. Jorge Almada";
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);

                        text = "Culiacán, Sinaloa, México";
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);

                        text = "C.P. 80120";
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);

                        text = "R.F.C. SALC-840327-PC1";
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);

                        text = "-----------------------------------------------------";
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);

                        y = printArea.Bottom + 5;

                        text = "Cliente";
                        printArea = new RectangleF(left, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Total";
                        printArea = new RectangleF(left + 115, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Abonos";
                        printArea = new RectangleF(left + 175, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Saldo";
                        printArea = new RectangleF(left, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatFar);

                        text = "-----------------------------------------------------";
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);

                        y = printArea.Bottom + 5;

                        text = row["Clientes"].ToString().Trim();
                        completedWord = new StringBuilder();
                        WrapText(text, 20, e);
                        printArea = new RectangleF(left, y, width, e.Graphics.MeasureString(completedWord.ToString(), new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(completedWord.ToString(), new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = row["Total"].ToString();
                        printArea = new RectangleF(left + 115, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = row["Abonos"].ToString();
                        printArea = new RectangleF(left + 175, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = row["Saldo"].ToString();
                        printArea = new RectangleF(left, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatFar);


                        text = "Fecha del Pago : " + row["Fecha"].ToString();
                        printArea = new RectangleF(left, printArea.Bottom + 20, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Folio : " + row["Folio"].ToString();
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Producto : " + row["Producto"].ToString();
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Detalles : " + row["Detalles"].ToString();
                        completedWord = new StringBuilder();
                        WrapText(text, 40, e);
                        wrapwidth = 275;
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(completedWord.ToString(), new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(completedWord.ToString(), new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Folio del Pago : " + row["FolioPago"].ToString();
                        printArea = new RectangleF(left, printArea.Bottom + 3, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Saldo Total : " + row["SaldoTotal"].ToString();
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Observaciones : " + row["Observaciones"].ToString();
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Elaboro : " + row["Elaboro"].ToString();
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "-----------------------------------------------------";
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);

                        text = "Gracias por su preferencia";
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);

                        text = "Estamos para servirle";
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);

                        text = "-----------------------------------------------------";
                        printArea = new RectangleF(left, printArea.Bottom + 5, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatCenter);


                        //completedWord = new StringBuilder();
                        //text = row["Producto"].ToString() + " " + row["Detalles1"].ToString() + " " + row["Detalles2"].ToString();
                        //WrapText(text, 40, e);
                        //printArea = new RectangleF(left, printArea.Bottom + 8, width, e.Graphics.MeasureString(completedWord.ToString(), new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        //e.Graphics.DrawString(completedWord.ToString(), new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

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

        private void gridcontrol2_cellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView View = sender as GridView;

            if (e.Column.Caption == "Observaciones")
            {
                if (e.RowHandle >= 0)
                {
                    string folioPago = View.GetRowCellDisplayText(e.RowHandle, "FolioPago");
                    decimal dFolioPago = decimal.Parse(folioPago);

                    try
                    {
                        var result = db.Payments.Single(b => b.FolioPago == dFolioPago);
                        if (result != null)
                        {
                            result.Observations = e.Value.ToString();

                            db.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        String strEx = ex.ToString();
                        MessageBox.Show(strEx);
                    }
                }

            }
        }
    }
}
