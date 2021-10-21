using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportGen
{
    public partial class NewForm : Form
    {
        ReportDataSource rs = new ReportDataSource();

        private string a;
        private int nBtnNum;

        Christian_FranciscoEntities db = new Christian_FranciscoEntities();

        public NewForm(String a)
        {
            InitializeComponent();

            this.a = a;
            this.nBtnNum = 1;
            try
            {
                DateTime frm = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                DateTime to = Convert.ToDateTime(dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                this.dEUDORESTableAdapter.FillDate(chFraDataSet.DEUDORES, frm, to);
                gridView1.RefreshData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnFetchData_Click(object sender, EventArgs e)
        {
            try
            {

                //      dataGridView1.DataSource = a;
                /*
                var reuslt = (from m in db.Payments
                              where m.FechaN>=dateTimePicker1.Value.Date && m.FechaN<=dateTimePicker2.Value.Date
                              group m by m.ClientesN into g
                              let Total = g.Sum(m => m.Payment1)
                              orderby Total descending
                              select new { User = g.Key, Total }).ToList();

                var reuslt1 = (from m in db.VREPGENs
                               where m.Fecha >= dateTimePicker1.Value.Date && m.Fecha <= dateTimePicker2.Value.Date
                               group m by m.Clientes into g
                               let Total = g.Sum(m => m.Total)
                               orderby Total descending
                               select new { User = g.Key, Total }).ToList();

                var combined = from c in reuslt
                               join b in reuslt1 on c.User equals b.User
                               select new
                               {
                                   Cliente = c.User,
                                   Total = Math.Round(b.Total, 2),
                                   Abonos = c.Total,

                                   Saldo = decimal.Parse(b.Total.ToString()) - c.Total
                               };
                */
                //dataGridView1.Rows.Clear();
                //dataGridView1.Refresh();
                //dataGridView1.DataSource = null;
                //dataGridView1.DataSource = combined.ToList();
                //double total = combined.AsEnumerable().Sum(o => o.Total);
                //double albonos = double.Parse(combined.AsEnumerable().Sum(o => o.Abonos).ToString());
                //double saldo = double.Parse(combined.AsEnumerable().Sum(o => o.Saldo).ToString());
                //label2.Text = total.ToString("N", CultureInfo.InvariantCulture);
                //label3.Text = albonos.ToString("N", CultureInfo.InvariantCulture);
                //label4.Text = saldo.ToString("N", CultureInfo.InvariantCulture);

                this.nBtnNum = 1;
                DateTime frm = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                DateTime to = Convert.ToDateTime(dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                this.dEUDORESTableAdapter.FillDate(chFraDataSet.DEUDORES, frm, to);
                gridView1.RefreshData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.nBtnNum = 2;
            try
            {
                decimal val1 = Convert.ToDecimal(textBox1.Text == "" ? "0" : textBox1.Text);
                decimal val2 = Convert.ToDecimal(textBox2.Text == "" ? "0" : textBox2.Text);

                //DateTime frm = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                //DateTime to = Convert.ToDateTime(dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                //if((val1 == 0) && (val2 == 0))
                //    this.dEUDORESTableAdapter.FillDate(chFraDataSet.DEUDORES, frm, to);
                //else
                    this.dEUDORESTableAdapter.FillByRange(chFraDataSet.DEUDORES, val1, val2);

                gridView1.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {

                //      dataGridView1.DataSource = a;
                var reuslt = (from m in db.Payments
                              where
                              (m.FechaN >= dateTimePicker1.Value.Date && m.FechaN <= dateTimePicker2.Value.Date)
                              group m by m.ClientesN into g
                              let Total = g.Sum(m => m.Payment1)
                              orderby Total descending
                              select new { User = g.Key, Total }).ToList();

                var reuslt1 = (from m in db.VREPGENs
                               where
                             (m.Fecha >= dateTimePicker1.Value.Date && m.Fecha <= dateTimePicker2.Value.Date)
                               group m by m.Clientes into g
                               let Total = g.Sum(m => m.Total)
                               orderby Total descending
                               select new { User = g.Key, Total }).ToList();

                var combined = from c in reuslt
                               join b in reuslt1 on c.User equals b.User
                               orderby b.Total descending
                               select new
                               {
                                   Cliente = c.User,
                                   Total = Math.Round(b.Total, 2),
                                   Abonos = c.Total,

                                   Saldo = decimal.Parse(b.Total.ToString()) - c.Total
                               }
                               
                               ;
                //dataGridView1.Rows.Clear();
                //dataGridView1.Refresh();
                //dataGridView1.DataSource = null;
                //dataGridView1.DataSource = combined.ToList();
                double total = combined.AsEnumerable().Sum(o => o.Total);
                double albonos = double.Parse(combined.AsEnumerable().Sum(o => o.Abonos).ToString());
                double saldo = double.Parse(combined.AsEnumerable().Sum(o => o.Saldo).ToString());
                //label2.Text = total.ToString("N", CultureInfo.InvariantCulture);
                //label3.Text = albonos.ToString("N", CultureInfo.InvariantCulture);
                //label4.Text = saldo.ToString("N", CultureInfo.InvariantCulture);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {

                //      dataGridView1.DataSource = a;
                var reuslt = (from m in db.Payments
                              where
                             (m.FechaN >= dateTimePicker1.Value.Date && m.FechaN <= dateTimePicker2.Value.Date)
                              group m by m.ClientesN into g
                              let Total = g.Sum(m => m.Payment1)
                              orderby Total descending
                              select new { User = g.Key, Total }).ToList();

                var reuslt1 = (from m in db.VREPGENs
                               where
                             (m.Fecha >= dateTimePicker1.Value.Date && m.Fecha <= dateTimePicker2.Value.Date)
                               group m by m.Clientes into g
                               let Total = g.Sum(m => m.Total)
                               orderby Total descending
                               select new { User = g.Key, Total }).ToList();

                var combined = from c in reuslt
                               join b in reuslt1 on c.User equals b.User
                               orderby c.Total descending
                               select new
                               {
                                   Cliente = c.User,
                                   Total = Math.Round(b.Total, 2),
                                   Abonos = c.Total,

                                   Saldo = decimal.Parse(b.Total.ToString()) - c.Total
                               }

                               ;
                //dataGridView1.Rows.Clear();
                //dataGridView1.Refresh();
                //dataGridView1.DataSource = null;
                //dataGridView1.DataSource = combined.ToList();
                double total = combined.AsEnumerable().Sum(o => o.Total);
                double albonos = double.Parse(combined.AsEnumerable().Sum(o => o.Abonos).ToString());
                double saldo = double.Parse(combined.AsEnumerable().Sum(o => o.Saldo).ToString());
                //label2.Text = total.ToString("N", CultureInfo.InvariantCulture);
                //label3.Text = albonos.ToString("N", CultureInfo.InvariantCulture);
                //label4.Text = saldo.ToString("N", CultureInfo.InvariantCulture);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {

                //      dataGridView1.DataSource = a;
                var reuslt = (from m in db.Payments
                              where
                             (m.FechaN >= dateTimePicker1.Value.Date && m.FechaN <= dateTimePicker2.Value.Date)
                              group m by m.ClientesN into g
                              let Total = g.Sum(m => m.Payment1)
                              orderby Total descending
                              select new { User = g.Key, Total }).ToList();

                var reuslt1 = (from m in db.VREPGENs
                               where
                             (m.Fecha >= dateTimePicker1.Value.Date && m.Fecha <= dateTimePicker2.Value.Date)
                               group m by m.Clientes into g
                               let Total = g.Sum(m => m.Total)
                               orderby Total descending
                               select new { User = g.Key, Total }).ToList();

                var combined = from c in reuslt
                               join b in reuslt1 on c.User equals b.User
                               orderby decimal.Parse(b.Total.ToString()) - c.Total descending
                               select new
                               {
                                   Cliente = c.User,
                                   Total = Math.Round(b.Total, 2),
                                   Abonos = c.Total,

                                   Saldo = decimal.Parse(b.Total.ToString()) - c.Total
                               }

                               ;
                //dataGridView1.Rows.Clear();
                //dataGridView1.Refresh();
                //dataGridView1.DataSource = null;
                //dataGridView1.DataSource = combined.ToList();
                double total = combined.AsEnumerable().Sum(o => o.Total);
                double albonos = double.Parse(combined.AsEnumerable().Sum(o => o.Abonos).ToString());
                double saldo = double.Parse(combined.AsEnumerable().Sum(o => o.Saldo).ToString());
                //label2.Text = total.ToString("N", CultureInfo.InvariantCulture);
                //label3.Text = albonos.ToString("N", CultureInfo.InvariantCulture);
                //label4.Text = saldo.ToString("N", CultureInfo.InvariantCulture);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DateTime dtf = dateTimePicker1.Value;
            DateTime dtt = dateTimePicker2.Value;
            decimal val1 = Convert.ToDecimal(textBox1.Text == "" ? "0" : textBox1.Text);
            decimal val2 = Convert.ToDecimal(textBox2.Text == "" ? "0" : textBox2.Text);

            if (this.nBtnNum != 2)
            {
                FormDEUDORES frm = new FormDEUDORES(dtf, dtt, a, this.nBtnNum);
                frm.ShowDialog();
            }
            else
            {
                FormDEUDORES frm = new FormDEUDORES(val1, val2, a, this.nBtnNum);
                frm.ShowDialog();
            }


        }

        private void btnAbonos_Click(object sender, EventArgs e)
        {
            this.nBtnNum = 3;
            try
            {
                DateTime frm = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                DateTime to = Convert.ToDateTime(dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                this.dEUDORESTableAdapter.FillAbonosByRange(chFraDataSet.DEUDORES, frm, to);
                gridView1.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                        
        }

        private void textBox1_keypress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
//             if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
//             {
//                 e.Handled = true;
//                 return;
//             }
//             // checks to make sure only 1 decimal is allowed
//             if (e.KeyChar == 46)
//             {
//                 if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
//                     e.Handled = true;
//             }
//             if (Regex.IsMatch(textBox1.Text, @"\.\d\d"))
//             {
//                 e.Handled = true;
//             }
        }

        private void textBox2_keypress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
//             if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
//             {
//                 e.Handled = true;
//                 return;
//             }
//             // checks to make sure only 1 decimal is allowed
//             if (e.KeyChar == 46)
//             {
//                 if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
//                     e.Handled = true;
//             }
//             if (Regex.IsMatch(textBox2.Text, @"\.\d\d"))
//             {
//                 e.Handled = true;
//             }
        }
    }
}
