using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
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

namespace ReportGen
{
    public partial class FrmMain : Form
    {
        const string ProgName = "Reporte de Notas de Venta";
        DataTable dtData = new DataTable();
        private static DataTable dtSticker = new DataTable();
        private static string printername = "";
        private int[] selectedRows;
        private bool showOnlySelected = false;
        private List<int> _selectedDataSourceRowIndeces;

        private string a;
        private string strRole;
        private int nNewUser;

        public FrmMain(string a, string strRole)
        {
            InitializeComponent();
            this.a = a;
            this.strRole = strRole;
            this.nNewUser = getIfNewUser(a);
        }

        Christian_FranciscoEntities db = new Christian_FranciscoEntities();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //this.vREPGENTableAdapter.Fill(this.chFraDataSet.VREPGEN);
                DateTime frm = Convert.ToDateTime(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime to = Convert.ToDateTime(dtpToDate.Value.ToString("yyyy-MM-dd"));
                this.vREPGENTableAdapter.FillDate(chFraDataSet.VREPGEN, frm, to);
                gridView1.RefreshData();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString(), ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            chkTotals.Checked = Properties.Settings.Default.chktotals;
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

            if (chkTotals.Checked == true)
            {
                gridView1.Columns["Total"].Visible = false;
                InsertImage();
            }
            else
            {
                gridView1.Columns["Total"].Visible = true;
                InsertImage();
            }
            checkEdit1.Checked = false;
            showOnlySelected = false;
            gridView1.ClearSelection();
            this.vREPGENTableAdapter.Fill(this.chFraDataSet.VREPGEN);
            gridControl1.BringToFront();
            gridView1.Columns["Total"].Visible = true;
            gridView1.RefreshData();
            gridControl1.Refresh();
        }


        void InsertImage()
        {
            DateTime df = Convert.ToDateTime(dtpFromDate.Value.ToShortDateString());
            DateTime dt = Convert.ToDateTime(dtpToDate.Value.ToShortDateString());


            gridView1.OptionsPrint.AutoWidth = true;

            // Create a printing system. 
            PrintingSystem printingSystem1 = new PrintingSystem();
            //Create a link to print the Grid control. 
            PrintableComponentLink printableComponentLink1 = new PrintableComponentLink();
            // Specify the link's printable component. 
            printableComponentLink1.Landscape = true;
            printableComponentLink1.Component = gridControl1;
            // Assign the printing system to this link. 
            printableComponentLink1.PrintingSystem = printingSystem1;
            PageHeaderArea pgHArea = new PageHeaderArea();
            PageArea pgare = new PageArea();
            pgHArea.Font = new Font("Arial", 10, FontStyle.Bold | FontStyle.Italic);
            //pgHArea.Font.co
            // Add the image and the report creation time  
            // to the third (rightmost) section of the page header.
            //pgHArea.Font.Height{pgHArea.Font.Height,5};
            pgHArea.Content.AddRange(new string[] { "Reporte Generado por:\r\n" + a, "Hortel Cortinas y Persianas\r\n" + "Reporte de Notas de Ventas\r\n"+"Del: "+df.ToString("dd/MM/yyyy")+" "+"Al: "+dt.ToString("dd/MM/yyyy"), "Pagina" + "[Page # of Pages #]\r\n" + "Fecha de Reporte:\r\n" + "[Date Printed]" });


            // Create a PageHeaderFooter object for this link. 
            printableComponentLink1.PageHeaderFooter = new PageHeaderFooter(pgHArea, null);
            // Preview the report. 
            printableComponentLink1.ShowPreviewDialog();
        }
        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (simpleButton2.Text == "Filtrar Seleccionados")
            {
                showOnlySelected = true;
                simpleButton2.Text = "Cancelando";
                gridControl1.BringToFront();

            }
            else
            {
                showOnlySelected = false;
                checkEdit1.Checked = false;
                simpleButton2.Text = "Filtrar Seleccionados";
                //gridView1.ClearSelection();
                this.vREPGENTableAdapter.Fill(this.chFraDataSet.VREPGEN);
                gridControl1.BringToFront();

            }
            gridView1.RefreshData();
            //gridControl1.Refresh();
        }

        private void GridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedRowHandles = gridView1.GetSelectedRows();
            _selectedDataSourceRowIndeces = selectedRowHandles.Select(x => gridView1.GetDataSourceRowIndex(x)).ToList();
        }

        private void GridView1_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            if (checkEdit1.Checked && _selectedDataSourceRowIndeces != null)
            {
                e.Visible = _selectedDataSourceRowIndeces.Contains(e.ListSourceRow);
                e.Handled = true;
            }
            //else if (_selectedDataSourceRowIndeces != null)
            //{
            //    e.Visible = _selectedDataSourceRowIndeces.Contains(e.ListSourceRow);
            //    e.Handled = true;
            //}

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void BtnFetchData_Click(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

            try
            {
                try
                {
                    DateTime frm = Convert.ToDateTime(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                    DateTime to = Convert.ToDateTime(dtpToDate.Value.ToString("yyyy-MM-dd"));
                    db.Database.CommandTimeout = 300;
                    this.vREPGENTableAdapter.Adapter.SelectCommand.CommandTimeout = 180;
                    this.vREPGENTableAdapter.FillDate(chFraDataSet.VREPGEN, frm, to);
                    gridView1.RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString(), ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            string r;
            if (chkTotals.Checked==true)
            {
                r = "1";
            }
            else
            {
                r = "0";
            }
            DateTime dtf = dtpFromDate.Value;
            DateTime dtt = dtpToDate.Value;
            frmReport aa = new frmReport(dtf, dtt, a,r);
            aa.ShowDialog();
        }

        private void LinkLabel1_Click(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            } else if (this.strRole == "MANAGER")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            } else if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            FrmUser aa = new FrmUser();
            aa.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

            this.vREPGENTableAdapter.Fill(this.chFraDataSet.VREPGEN);

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            simpleButton2.Text = "Filter Selected";
            string txtvar = "";
            int ad;
            try
            {


                GridControl grid = sender as GridControl;
                Point p = new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                GridView gridView = gridControl1.FocusedView as GridView;
                object row = gridView.GetRow(gridView.FocusedRowHandle);
                if (gridView != null)
                    txtvar = gridView.GetFocusedRowCellDisplayText("CIDMOVIMIENTO");
                ad = int.Parse(txtvar.ToString());
                var query = (from ord in db.admMovimientos
                             where ord.CIDMOVIMIENTO == ad
                             select ord).First();

                query.CFECHA = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                db.SaveChanges();
                this.vREPGENTableAdapter.Fill(this.chFraDataSet.VREPGEN);
                gridControl1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                gridControl1.BringToFront();
                //gridControl2.SendToBack();
                simpleButton2.Enabled = true;
                btnSticker.Enabled = true;
            }
            else
            {
                gridControl1.BringToFront();
                //gridControl2.BringToFront();
                simpleButton2.Enabled = false;
                btnSticker.Enabled = false;

            }
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            string txtvar = "";
            try
            {
                GridControl grid = sender as GridControl;
                Point p = new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                GridView gridView = grid.GetViewAt(p) as GridView;
                if (gridView != null)
                    txtvar = gridView.GetFocusedRowCellDisplayText("Clientes");
                FrmPayment cdd = new FrmPayment(txtvar,a, this.strRole);
                cdd.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            } else if (this.strRole == "MANAGER")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            string txtvar = "";
            try
            {
                GridControl grid = sender as GridControl;
                Point p = new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                GridView gridView = grid.GetViewAt(p) as GridView;
                if (gridView != null)
                    txtvar = gridView.GetFocusedRowCellDisplayText("Clientes");
                FrmPayment cdd = new FrmPayment(txtvar,a, this.strRole);
                cdd.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void chkTotals_CheckedChanged(object sender, EventArgs e)
        {

        }
        public static PCPrint printer;
        public class PCPrint : PrintDocument
        {
            int left = 2, width = 300, wrapwidth = 295;
            public string fontName = "Arial";
            public float fontSize = 9;

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

                    int nIDLen = 0;

                    float y = 0;
                    foreach (DataRow row in dtSticker.Rows)
                    {
                        text = "HORTEL CORTINAS Y PERSIANAS";
                        printArea = new RectangleF(left, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Bold), Brushes.Black, printArea, strFormatNear);

                        text = row["Fecha"].ToString();
                        printArea = new RectangleF(left, y, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatFar);

                        text = row["Clientes"].ToString();
                        printArea = new RectangleF(left, printArea.Bottom + 8, width, e.Graphics.MeasureString(text, new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        text = "Folio/ID : " + row["Folio"].ToString() + "/" + row["ID"].ToString();
                        e.Graphics.DrawString(text, new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatFar);

                        completedWord = new StringBuilder();
                        text = row["Producto"].ToString() + " " + row["Detalles1"].ToString() + " " + row["Detalles2"].ToString();
                        WrapText(text, 40, e);
                        printArea = new RectangleF(left, printArea.Bottom + 8, width, e.Graphics.MeasureString(completedWord.ToString(), new Font(fontName, fontSize, FontStyle.Regular), width, StringFormat.GenericTypographic).Height);
                        e.Graphics.DrawString(completedWord.ToString(), new Font(fontName, fontSize, FontStyle.Regular), Brushes.Black, printArea, strFormatNear);

                        nIDLen = row["ID"].ToString().Length;
                        String strTmp = "";
                        if(nIDLen < 12)
                        {
                            for (int i = nIDLen; i < 12; i++) strTmp += "0";
                        }

                        strTmp += row["ID"].ToString();

                        Ean13 ean13 = new Ean13();
                        ean13.CountryCode = strTmp.Substring(0, 2);
                        ean13.ManufacturerCode = strTmp.Substring(2, 5);
                        ean13.ProductCode = strTmp.Substring(7, 5);

                        string sTemp = ean13.CountryCode + ean13.ManufacturerCode + ean13.ProductCode;
                        int iSum = 0;
                        int iDigit = 0;

                        // Calculate the checksum digit here.
                        for (int i = sTemp.Length; i >= 1; i--)
                        {
                            iDigit = Convert.ToInt32(sTemp.Substring(i - 1, 1));
                            if (i % 2 == 0)
                            {   // odd
                                iSum += iDigit * 3;
                            }
                            else
                            {   // even
                                iSum += iDigit * 1;
                            }
                        }

                        int iCheckSum = (10 - (iSum % 10)) % 10;




                        //ean13.Scale = 1;
                        //ean13.DrawEan13Barcode(e.Graphics, new System.Drawing.Point(30, 20));

                        Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                  

                        // Create coordinates for upper-left corner of image.


                        // Create rectangle for source image.
                        //RectangleF srcRect = new RectangleF(50.0F, 50.0F, 120.0F, 80.0F);
                        //GraphicsUnit units = GraphicsUnit.Pixel;

                        e.Graphics.DrawImage(qrcode.Draw(strTmp.Substring(1)+ iCheckSum, 50,3), 80, 80);
                     








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
        private void btnSticker_Click(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

            showOnlySelected = true;
            gridView1.RefreshData();

            try
            {
                printername = cmbPrinter.Text;
                bool hasdata = false;
                dtSticker.Columns.Clear();
                dtSticker.Columns.AddRange(new DataColumn[] {
                                        new DataColumn("Fecha"),
                                        new DataColumn("Folio"),
                                        new DataColumn("ID"),
                                        new DataColumn("Clientes"),
                                        new DataColumn("Producto"),
                                        new DataColumn("Detalles1"),
                                        new DataColumn("Detalles2")});
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    DataRow row = gridView1.GetDataRow(i);
                    hasdata = true;
                    dtSticker.Rows.Clear();
                    dtSticker.Rows.Add(Convert.ToDateTime(row["Fecha"]).ToString("MM/dd/yyyy"), Convert.ToInt32(row["Folio"]).ToString(), Convert.ToInt32(row["CIDMOVIMIENTO"]).ToString(), row["Clientes"].ToString(), row["Producto"].ToString(), row["Detalles1"].ToString(), row["Detalles2"].ToString());
                    PrintOrder();
                }
                //foreach (DataGridViewRow row in dgvData.Rows)
                //{
                //    DataGridViewCheckBoxCell chkCell = row.Cells[0] as DataGridViewCheckBoxCell;
                //    if (chkCell.Value.ToString().Equals("True"))
                //    {
                //        hasdata = true;
                //        dtSticker.Rows.Clear();
                //        dtSticker.Rows.Add(Convert.ToDateTime(row.Cells[1].Value).ToString("MM/dd/yyyy"), row.Cells[2].Value, row.Cells[3].Value, row.Cells[5].Value, row.Cells[6].Value, row.Cells[7].Value);
                //        PrintOrder();
                //    }
                //}
                if (!hasdata)
                    MessageBox.Show("No ha seleccionado casillas a imprimir", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSticker_MouseHover(object sender, EventArgs e)
        {
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            this.vREPGENTableAdapter.Fill(this.chFraDataSet.VREPGEN);
            dgvData.Visible = true;
            btnSticker.Enabled = true;

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            NewForm frm = new NewForm(a);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.strRole == "MANAGER")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

            DateTime frm_date = Convert.ToDateTime(dtpFromDate.Value.ToString("yyyy-MM-dd"));
            DateTime to_date = Convert.ToDateTime(dtpToDate.Value.ToString("yyyy-MM-dd"));

            productionform frm = new productionform(frm_date, to_date, this.a, this.strRole);
            frm.Show();
            //userform frm = new userform();
            //frm.Show();
        }

        private void GridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = (View.GetRowCellDisplayText(e.RowHandle, "Hide") == null) ? "0" : View.GetRowCellDisplayText(e.RowHandle, "Hide");
                if (category == "1")
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.HighPriority = true;
                }
                else if (category == "2")
                {
                    e.Appearance.BackColor = Color.PaleVioletRed;
                    e.HighPriority = true;
                }
            }
        }

        public int getIfNewUser(string userName)
        {
            int nNew = 0;
            try
            {
                var query = (from p in db.Logins
                            where p.UserName == a
                            && p.Is_Active == null
                            && p.Role == strRole
                            select p);

                if (query.Any())
                {
                    nNew = 1;
                }
                else
                {
                    nNew = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return nNew;
        }

        private void btnAbonos_Click(object sender, EventArgs e)
        {
            //if(this.a == "MANAGER" || this.a == "MANAGER1" || this.a == "MANAGER2" || this.a == "MANAGER3" || this.a == "MANAGER4" || this.a == "MANAGER5" || this.a == "MANAGER6" || this.a == "MANAGER7")
            //{
            //    MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
            //    return;
            //}
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            NewAbonosForm frm = new NewAbonosForm(a);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.strRole == "MANAGER")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            if (this.strRole == "ENTREGAS")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

            string txtvar = "";
            FrmPagos frm = new FrmPagos(txtvar, a);
            frm.Show();
        }
    }
}
