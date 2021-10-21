using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportGen
{
    public partial class userform : Form
    {
        int id=-1;
        String btn = "";
        public userform()
        {
            InitializeComponent();
            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                
                List<user> a = db.users.ToList<user>();
                
                dataGridView1.DataSource = a;

            }
        }

        private void button2_Click(object sender, EventArgs e)      //add btn
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            checkBox1.Enabled = true;
            btn = "Add";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)                  //remove btn
        {
            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                user us = new user();
                us.ID = id;
                us.Name = textBox1.Text;
                us.Cantidad = decimal.Parse(textBox2.Text.Trim());
                us.isActive = checkBox1.Checked;
                db.Entry(us).State = EntityState.Deleted;
                db.SaveChanges();
                List<user> a = db.users.ToList<user>();

                dataGridView1.DataSource = a;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            checkBox1.Checked = bool.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)      // Edit btn
        {
            btn = "Edit";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            checkBox1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)      // save btn 
        {
            if (btn == "Add")
            {
                 using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
                 {
                    user us = new user();
                    us.Name = textBox1.Text;
                    us.Cantidad = decimal.Parse(textBox2.Text.Trim());
                    us.isActive = checkBox1.Checked;
                    db.users.Add(us);
                    db.SaveChanges();
                    List<user> a = db.users.ToList<user>();


                    dataGridView1.DataSource = a;
                 }
            }
            else if (btn == "Edit") {
                using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
                {
                    user us = new user();
                    us.Name = textBox1.Text;
                    us.Cantidad = decimal.Parse(textBox2.Text.Trim());
                    us.isActive = checkBox1.Checked;
                    //db.users.Add(us);
                    //db.SaveChanges();
                    var result = db.users.Single(b => b.ID == id);
                    if (result != null)
                    {
                        result.Name = textBox1.Text;
                        result.isActive= checkBox1.Checked;
                        result.Cantidad = decimal.Parse(textBox2.Text.Trim());
                        db.SaveChanges();
                    }
                    List<user> a = db.users.ToList<user>();

                    dataGridView1.DataSource = a;
                }

            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            checkBox1.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)      //cancel btn
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            checkBox1.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void userform_FormClosed(object sender, FormClosedEventArgs e)
        {
            productionform frm = new productionform();
            frm.Show();
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
