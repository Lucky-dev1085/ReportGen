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
    public partial class productionentryform : Form
    {
        public productionentryform(DataGridViewRow row)
        {
            InitializeComponent();
            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                var val = db.users.Select(x => x.Name).ToList();
                comboBox1.DataSource = val;
            }
            //DataTable dt = row.d;
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].HeaderText = "ARM";
            dataGridView1.Columns[1].HeaderText = "ENTREG";
            dataGridView1.Columns[2].HeaderText = "ID";
            dataGridView1.Columns[3].HeaderText = "Fecha";
            dataGridView1.Columns[4].HeaderText = "Folio";
            dataGridView1.Columns[5].HeaderText = "Clientes";
            dataGridView1.Columns[6].HeaderText = "Armador";
            dataGridView1.Columns[7].HeaderText = "Obervaciones";
            //dataGridView1.Columns[8].HeaderText = "Unidades";
            dataGridView1.Columns[9].HeaderText = "Total";

            DataGridViewRow row1 = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row1.Cells[0].Value = row.Cells[0].Value;
            row1.Cells[1].Value = row.Cells[1].Value;
            row1.Cells[2].Value = row.Cells[2].Value;
            row1.Cells[3].Value = row.Cells[3].Value;
            row1.Cells[4].Value = row.Cells[4].Value;
            row1.Cells[5].Value = row.Cells[5].Value;
            row1.Cells[6].Value = row.Cells[6].Value;
            row1.Cells[7].Value = row.Cells[7].Value;
            row1.Cells[8].Value = row.Cells[8].Value;
            row1.Cells[9].Value = row.Cells[9].Value;

            checkBox1.Checked = Boolean.Parse(row.Cells[0].Value.ToString());
            checkBox2.Checked = Boolean.Parse(row.Cells[1].Value.ToString());
            textBox1.Text = row.Cells[7].Value.ToString();
            comboBox1.SelectedItem= row.Cells[6].Value.ToString();

            //row1 = row;
            //dataGridView1.DataSource = row.;
            dataGridView1.Rows.Add(row1);
            // Console.WriteLine(dataGridView1.Rows.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Value = checkBox1.Checked.ToString();
            dataGridView1.Rows[0].Cells[1].Value = checkBox2.Checked.ToString();
            dataGridView1.Rows[0].Cells[7].Value = textBox1.Text.ToString();
            dataGridView1.Rows[0].Cells[6].Value = comboBox1.SelectedItem.ToString();
            int id = int.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString());
            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                //var val = db.productions.Select(x => x.PaymentID).ToList();
               // comboBox1.DataSource = val;

              
                //db.users.Add(us);
                //db.SaveChanges();
                var result = db.productions.Single(b => b.PaymentID == id);
                if (result != null)
                {
                    result.ARM = checkBox1.Checked;
                    result.ENTREG = checkBox2.Checked;
                    result.Observaciones = textBox1.Text;
                    result.Armador= comboBox1.SelectedItem.ToString();
                   
                    db.SaveChanges();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //productionform frm = new productionform();
            //frm.Show();
            //this.Close();
        }

        private void productionentryform_FormClosed(object sender, FormClosedEventArgs e)
        {
            //productionform frm = new productionform();
            //frm.Show();
        }
    }
}
