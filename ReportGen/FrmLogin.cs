using ReportGen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportGen
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            //MessageBox.Show("Please input server, database and connection details.", "aaa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            InitializeComponent();
        }
        private bool IsvalidUser(string userName, string password, string role)
        {
            //return true;
            Christian_FranciscoEntities context = new Christian_FranciscoEntities();
            var query = from p in context.Logins
                        where p.UserName == userName
                        && p.Pass == password
                        && p.Role == role
                        select p;

            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string getUserRole(string userName, string password)
        {

            try
            {
                Christian_FranciscoEntities context = new Christian_FranciscoEntities();
                var query = (from p in context.Logins
                             where p.UserName == userName
                             && p.Pass == password
                             select p).First();

                return query.Role;
            }
            catch(Exception ex)
            {
                return "";
            }
        }
        int CountOPEN;
        int newcount;

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                textEdit1.Text = Properties.Settings.Default.UserName;
                textBox1.Text = Properties.Settings.Default.Countopn.ToString();
                checkEdit1.Checked = true;
            }
            this.textEdit2.Focus();
        }
        private void btnlog_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Countopn <= 160)
            {

                string strRole = getUserRole(textEdit1.Text, textEdit2.Text);

                if (checkEdit1.Checked)
                {
                    if (textBox1.Text == "0")
                    {
                        CountOPEN++;
                        Properties.Settings.Default.UserName = textEdit1.Text;
                        Properties.Settings.Default.Countopn = CountOPEN;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        //CountOPEN = int.Parse(textBox1.Text);
                        //CountOPEN++;
                        Properties.Settings.Default.UserName = textEdit1.Text;
                        //Properties.Settings.Default.Countopn = CountOPEN;
                        Properties.Settings.Default.Save();
                    }

                }
                if (strRole != "")
                {
                    if(strRole == "PRODUCCION" || strRole == "ENTREGAS")
                    {
                        string a = textEdit1.Text;
                        a = a.ToUpper();
                        string b = textEdit2.Text;
                        productionform frm = new productionform(a, strRole);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        string a = textEdit1.Text;
                        a = a.ToUpper();
                        string b = textEdit2.Text;
                        FrmMain ma = new FrmMain(a, strRole);
                        ma.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("You need to check your username or password");
                    textEdit2.Text = "";
                    textEdit2.Focus();
                }
                //}
            }

        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlog_MouseClick(object sender, MouseEventArgs e)
        {
            //CountOPEN++;
            //Properties.Settings.Default.Countopn += CountOPEN;
            //Properties.Settings.Default.Save();
            //MessageBox.Show(CountOPEN.ToString());
        }
    }
}
