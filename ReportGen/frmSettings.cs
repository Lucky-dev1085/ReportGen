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
    public partial class frmSettings : Form
    {
        const string ProgName = "Reporte de Notas de Venta";
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(txtServer.Text) || string.IsNullOrEmpty(txtDB.Text) || string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPwd.Text))
                    if (string.IsNullOrEmpty(txtServer.Text) || string.IsNullOrEmpty(txtDB.Text))

                    {
                        MessageBox.Show("Please input server, database and connection details.", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Properties.Settings.Default.server = txtServer.Text;
                Properties.Settings.Default.dbname = txtDB.Text;
                //Properties.Settings.Default.username = txtUser.Text;
                //Properties.Settings.Default.password = txtPwd.Text;
                //Properties.Settings.Default.connStr = "Server=" + Properties.Settings.Default.server + ";Database=" + Properties.Settings.Default.dbname + ";User Id=" + Properties.Settings.Default.username + ";Password=" + Properties.Settings.Default.password + ";";
                Properties.Settings.Default.connStr = "Server=" + Properties.Settings.Default.server + ";Database=" + Properties.Settings.Default.dbname + ";";
                //Properties.Settings.Default.connStr = "Server=DESKTOP-43GHU92\\SQLEXPRESS;Database=aaaa;";
                //Properties.Settings.Default.header1 = txtHeader1.Text;
                //Properties.Settings.Default.header2 = txtHeader2.Text;
                Properties.Settings.Default.Save();

                if (!utlReportGen.checkConnection())
                {
                    MessageBox.Show("Error! Not able to connect to database.", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Success! App connected to database.", ProgName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                txtServer.Text = Properties.Settings.Default.server;
                txtDB.Text = Properties.Settings.Default.dbname;
                //txtUser.Text = Properties.Settings.Default.username;
                //txtPwd.Text = Properties.Settings.Default.password;
                txtHeader1.Text = Properties.Settings.Default.header1;
                txtHeader2.Text = Properties.Settings.Default.header2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
