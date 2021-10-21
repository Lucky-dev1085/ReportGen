using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReportGen
{
    public partial class FrmUser : DevExpress.XtraEditors.XtraForm
    {
        public FrmUser()
        {
            InitializeComponent();
        }
        Christian_FranciscoEntities db = new Christian_FranciscoEntities();
        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ChFraDataSet);

        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaprintDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.ChFraDataSet.Login);

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkEdit1.Checked==true)
                {
                    passTextEdit.Properties.UseSystemPasswordChar = false;
                    con_PassTextEdit.Properties.UseSystemPasswordChar = false;
                    passTextEdit.Properties.PasswordChar = '\0';
                    con_PassTextEdit.Properties.PasswordChar= '\0';
                }
                else
                {
                    passTextEdit.Properties.UseSystemPasswordChar = true;
                    con_PassTextEdit.Properties.UseSystemPasswordChar = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void LoginGridControl_Click(object sender, EventArgs e)
        {

        }

        private void SimpleButton5_Click(object sender, EventArgs e)
        {
            try
            {

                var query = (from ord in db.Logins
                             .AsEnumerable()
                             where ord.id == int.Parse(idTextBox.Text)
                                 select ord).First();
                    query.Name = nameTextEdit.Text;
                    query.UserName = userNameTextEdit.Text;
                    query.Pass = passTextEdit.Text;
                    query.Con_Pass = con_PassTextEdit.Text;
                    query.Email = emailTextEdit.Text;
                    query.Job = jobTextEdit.Text;
                    query.Role = roleComboBox.SelectedItem.ToString();
                if (is_ActiveCheckBox.Checked==true)
                {
                    query.Is_Active = true;
                }
                    db.SaveChanges();
            }
            catch (Exception)
            {

            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {

                var query = (from ord in db.Logins
                             .AsEnumerable()
                             where ord.id == int.Parse(idTextBox.Text)
                             select ord).First();
                db.Logins.Remove(query);
                db.SaveChanges();
            }
            catch (Exception)
            {

            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                simpleButton1.Enabled = true;
                simpleButton4.Enabled = true;
                simpleButton6.Enabled = false;
                simpleButton5.Enabled = false;
                idTextBox.Text = "";
                nameTextEdit.Text="";
                userNameTextEdit.Text="";
                passTextEdit.Text="";
                con_PassTextEdit.Text="";
                emailTextEdit.Text="";
                jobTextEdit.Text="";
                roleComboBox.Text="";
                is_ActiveCheckBox.Checked = false;
            }
            catch (Exception)
            {

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                simpleButton1.Enabled = false;
                simpleButton4.Enabled = false;
                simpleButton6.Enabled = true;
                simpleButton5.Enabled = true;
                Login objCli = new Login();
                objCli.Name = nameTextEdit.Text;
                objCli.UserName = userNameTextEdit.Text;
                objCli.Pass = passTextEdit.Text;
                objCli.Con_Pass = con_PassTextEdit.Text;
                objCli.Email = emailTextEdit.Text;
                objCli.Job = jobTextEdit.Text;
                if (is_ActiveCheckBox.Checked == true)
                {
                    objCli.Is_Active = true;
                }
                objCli.Role = roleComboBox.SelectedItem.ToString();
                db.Logins.Add(objCli);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                idTextBox.Text = "";
                nameTextEdit.Text = "";
                userNameTextEdit.Text = "";
                passTextEdit.Text = "";
                con_PassTextEdit.Text = "";
                emailTextEdit.Text = "";
                jobTextEdit.Text = "";
                roleComboBox.Text = "";
                is_ActiveCheckBox.Checked = false;
            }
            catch (Exception)
            {

            }
        }
    }
}