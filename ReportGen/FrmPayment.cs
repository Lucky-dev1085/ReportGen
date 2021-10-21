using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportGen
{
    public partial class FrmPayment : Form
    {
        private string txtvar;
        private string a;
        private string strRole;
        public FrmPayment(string txtvar, string a, string strRole)
        {
            InitializeComponent();
            this.txtvar = txtvar;
            this.a = a;
            this.strRole = strRole;
        }

        Christian_FranciscoEntities db = new Christian_FranciscoEntities();

        int myVar;
        private void FrmPayment_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'chFraDataSet.admClientes' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'chFraDataSet.admClientes' table. You can move, or remove it, as needed.


            //GridColumn col = gridView2.Columns.AddField("MyItem");

            //col.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            //gridView2.Columns.Add(col);
            //col.Visible = true;
            //col.Caption = "MyItem";

            try
            {
                
                this.paymentTableAdapter.FillClient(this.chFraDataSet.Payment, txtvar);
                this.vREPGENTableAdapter.FillClient(this.chFraDataSet.VREPGEN, txtvar);
                this.admClientesTableAdapter.Fill(this.chFraDataSet.admClientes);
                clientesNTextBox.Text = txtvar;
            }
            catch (Exception ex)
            {

            }
            try
            {

                var intData = (from p in db.VREPGENs
                               where p.Clientes == txtvar
                               select p.Folio).Distinct().ToList();
                comboBox1.DataSource = intData;
                comboBox1.DisplayMember = intData.ToString();
                comboBox1.ValueMember = intData.ToString();

            }
            catch (Exception ex)
            {

            }
            NewMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

            if (gridView.RowCount>0)
            {
                try
                {
                    if (clientesNTextBox.Text == txtvar)
                    {
                        Payment payadd = new Payment();
                        folioNComboBox.Text = comboBox1.Text;
                        payadd.ClientesN = clientesNTextBox.Text;
                        payadd.FechaN = fechaNDateTimePicker.Value;
                        payadd.FolioN = Convert.ToDecimal(folioNComboBox.Text);
                        payadd.Payment1 = Convert.ToDecimal(paymentTextBox.Text);
                        payadd.Observations = observationsTextBox.Text;
                        db.Payments.Add(payadd);
                        db.SaveChanges();
                        this.paymentTableAdapter.FillClient(this.chFraDataSet.Payment, txtvar);
                        NewMethod();
                    }
                    else
                    {
                        //this.paymentTableAdapter.Fill(this.chFraDataSet.Payment);
                        Payment payadd = new Payment();
                        folioNComboBox.Text = comboBox1.Text;
                        payadd.ClientesN = clientesNTextBox.Text;
                        payadd.FechaN = fechaNDateTimePicker.Value;
                        payadd.FolioN = Convert.ToDecimal(folioNComboBox.Text);
                        payadd.Payment1 = Convert.ToDecimal(paymentTextBox.Text);
                        payadd.Observations = observationsTextBox.Text;
                        db.Payments.Add(payadd);
                        db.SaveChanges();
                        this.paymentTableAdapter.FillClient(this.chFraDataSet.Payment, clientesNTextBox.Text);
                        gridControl1.Refresh();
                        NewMethod();
                    }
                }
                catch (Exception)
                {

                } 
            }
            else
            {
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

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
                this.paymentTableAdapter.FillClient(this.chFraDataSet.Payment, clientesNTextBox.Text);
                NewMethod();
            }
            catch (Exception ex)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewMethod();

        }

        private void NewMethod()
        {
            gridControl1.Refresh();
            gridControl2.Refresh();
            decimal sumNetPriceTotal = 0;
            decimal sumNetPriceAbonos = 0;
            try
            {
                for (int i = 0; i < gridView.DataRowCount; ++i)
                {
                    DataRow row = gridView.GetDataRow(i);
                    sumNetPriceTotal += decimal.Parse(row["Total"].ToString());
                }
                label8.Text = (sumNetPriceTotal.ToString("N", CultureInfo.InvariantCulture));
                //label8.Text = String.Format("{0}", sumNetPriceTotal);
            }
            catch (Exception)
            {

            }
            try
            {
                for (int i = 0; i < gridView2.DataRowCount; ++i)
                {
                    DataRow row = gridView2.GetDataRow(i);

                    if(!(Boolean)row["Authorize"])
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
            
        }
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

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
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

            string txtcl = cRAZONSOCIALComboBox.SelectedValue.ToString();

            try
            {
                this.paymentTableAdapter.FillClient(this.chFraDataSet.Payment, txtcl);
                this.vREPGENTableAdapter.FillClient(this.chFraDataSet.VREPGEN, txtcl);
                clientesNTextBox.Text = txtcl;
                NewMethod();
                paymentTextBox.Text = "";
                try
                {

                    var intData = (from p in db.VREPGENs
                                   where p.Clientes == txtcl
                                   select p.Folio).Distinct().ToList();
                    comboBox1.DataSource = intData;
                    comboBox1.DisplayMember = intData.ToString();
                    comboBox1.ValueMember = intData.ToString();
                    

                }
                catch (Exception)
                {

                }
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

            try
            {
                string dd = clientesNTextBox.Text;
                RepPayment reppay = new RepPayment(a,dd);
                reppay.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void FrmPayment_Shown(object sender, EventArgs e)
        {
            NewMethod();
        }


        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (this.strRole == "CAJA")
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
                {
                    txtvar = gridView.GetFocusedRowCellDisplayText("Clientes");
                }
                MessageBox.Show(txtvar);
                //FrmPayment cdd = new FrmPayment(txtvar, a);
                //  cdd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    GridControl grid = sender as GridControl;
            //    Point p = new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
            //    GridView gridView = grid.GetViewAt(p) as GridView;
               
            //    if (gridView != null)
            //    {
            //        int[] SelectedRowHandles = gridView.GetSelectedRows();
                    
            //        string strFecha = gridView.GetRowCellDisplayText(SelectedRowHandles[0], gridView.Columns[5]).ToString();

            //        string strFolioPago = gridView.GetRowCellDisplayText(SelectedRowHandles[0], gridView.Columns[2]).ToString();
            //        string strFolio = gridView.GetRowCellDisplayText(SelectedRowHandles[0], gridView.Columns[3]).ToString();
            //        string strClient = gridView.GetRowCellValue(SelectedRowHandles[0], gridView.Columns[4]).ToString();

            //        string strTotal = label8.Text;
            //        string strAbonos = label7.Text;
            //        string strSaldo = label6.Text;

            //        frmPaymentTicket frm = new frmPaymentTicket(strFecha, strFolioPago, strFolio, strClient, strTotal, strAbonos, strSaldo);
            //        frm.ShowDialog();
            //    }
               
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void FrmPayment_Closing(object sender, FormClosingEventArgs e)
        {
            //if(this.a == "ABONOS")
            //    Application.Exit();
        }

        private void GridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                object Authorize = (View.GetRowCellValue(e.RowHandle, "Authorize") == null) ? "0" : View.GetRowCellValue(e.RowHandle, "Authorize");
                if ((Boolean)Authorize)
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.HighPriority = true;

                }
            }
        }
        Boolean ccc = false;
        private void cellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (this.strRole == "CAJA")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }
            GridView View = sender as GridView;
            
            if (e.Column.Caption == "Authorize")
            {
                ccc = (Boolean)e.Value;

                if (e.RowHandle >= 0)
                {
                    string folioPago = View.GetRowCellDisplayText(e.RowHandle, "FolioPago");
                    decimal dFolioPago = decimal.Parse(folioPago);

                    try
                    {
                        var result = db.Payments.Single(b => b.FolioPago == dFolioPago);
                        if (result != null)
                        {
                            result.Authorize = ccc == true ? 1 : 0;

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

        private void gridView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.Caption == "Authorize")
            {
                if (e.IsSetData)
                {
                    e.Value = ccc;
                }
                if (e.IsGetData)
                {
                    e.Value = ccc;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string dd = clientesNTextBox.Text;
                DateTime dt = fechaNDateTimePicker.Value;
                RepPagoDay reppago = new RepPagoDay(a, dd, dt);
                reppago.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.strRole != "ADMIN")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

            DateTime dt = fechaNDateTimePicker.Value;
            this.paymentTableAdapter.FillClientByDate(this.chFraDataSet.Payment, dt);

            NewMethod();
        }
    }
}
