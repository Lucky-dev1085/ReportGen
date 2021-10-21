using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ReportGen
{
    public partial class productionform : Form
    {
        private string m_strUserName;
        private string strRole;

        public productionform(DateTime frm_date, DateTime to_date, string strUserName, string strRole)
        {
            InitializeComponent();
            barcode_reader.Focus();
            barcode_reader.Select();

            this.dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dateTimePicker1.Value = frm_date;
            this.dateTimePicker2.Value = to_date;
            this.m_strUserName = strUserName;
            this.strRole = strRole;

            if (this.strRole == "PRODUCCION")
            {
                dataGridView1.Columns[1].ReadOnly = true;
                //dataGridView1.Columns[6].ReadOnly = true;
                dataGridView1.Columns[9].ReadOnly = true;
                dataGridView1.Columns[10].ReadOnly = true;

                //comboBox1.Enabled = false;
            }
            if (this.strRole == "ENTREGAS")
            {
                dataGridView1.Columns[0].ReadOnly = true;
            }

            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                dataGridView1.Rows.Clear();
                List<VREPGEN> a = db.VREPGENs.SqlQuery("Select * from VREPGEN where Fecha >= @a and Fecha <= @b",
                    new SqlParameter[] { new SqlParameter("@a", frm_date), new SqlParameter("@b", to_date) }).ToList<VREPGEN>();
                for (int i = 0; i < a.Count; i++)
                {
                    int id1 = a[i].CIDMOVIMIENTO;

                    if (db.productions.Any(o => o.PaymentID == id1))
                    {

                    }
                    else
                    {
                        production po = new production();
                        po.PaymentID = a[i].CIDMOVIMIENTO;
                        db.productions.Add(po);
                        db.SaveChanges();
                    }
                }


                db.Database.CommandTimeout = 300;

                var result = (from t in db.VREPGENs
                              join s in db.productions on t.CIDMOVIMIENTO equals s.PaymentID
                              where (t.Fecha >= frm_date.Date && t.Fecha <= to_date.Date && s.ENTREG == false)

                              orderby t.Fecha, t.Folio, t.CIDMOVIMIENTO


                              select new
                              {
                                  ARM = s.ARM,
                                  ENTREG = s.ENTREG,
                                  ID = t.CIDMOVIMIENTO,
                                  Fecha = t.Fecha,
                                  Folio = t.Folio,
                                  Clientes = t.Clientes,
                                  Producto = t.Producto,
                                  Detalles1 = t.Detalles1,
                                  Detalles2 = t.Detalles2,
                                  Armador = s.Armador,
                                  Obervaciones = s.Observaciones,
                                  Total = t.Total
                              }
                            ).ToList();
                var val = db.users.Select(x => x.Name).ToList();
                comboBox1.DataSource = val;

                this.Armado.MaxDropDownItems = 4;
                for (int i = 0; i < val.Count; i++)
                    this.Armado.Items.Add(val[i].Trim());

                decimal sum2 = 0;

                for (int i = 0; i < result.Count; i++)
                {
                    String strArmador = result[i].Armador;
                    if (result[i].Armador != null)
                    {
                        for (int j = 0; j < val.Count; j++)
                        {
                            if (val[j].Trim() == result[i].Armador.Trim())
                            {
                                strArmador = result[i].Armador;
                                break;
                            }
                            else
                                strArmador = null;

                        }
                    }

                    if (strArmador != null)
                        strArmador = strArmador.ToString().Trim();

                    string[] row = new string[] {
                        (result[i].ARM) ? "true" : "false",
                        (result[i].ENTREG) ? "true" : "false",
                        result[i].ID.ToString(),
                        result[i].Fecha.ToString("yyyy-MM-dd"),
                        result[i].Folio.ToString(),
                        result[i].Clientes,
                        result[i].Producto,
                        result[i].Detalles1,
                        result[i].Detalles2,
                        strArmador,
                        result[i].Obervaciones,
                        result[i].Total.ToString("C2", new CultureInfo("en-US", false))
                    };

                    try
                    {
                        dataGridView1.Rows.Add(row);
                    }
                    catch (Exception ex)
                    {
                    
                    }

                    if (result[i].Total.ToString() != string.Empty)
                    {
                        sum2 += Convert.ToDecimal(result[i].Total.ToString());
                    }
                }

                //String strCur = sum2.ToString("C2", CultureInfo.CurrentCulture);
                label9.Text = sum2.ToString("C2", new CultureInfo("en-US", false));


            }

        }

        public productionform(string strUserName, string strRole)
        {
            InitializeComponent();
            this.dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.m_strUserName = strUserName;
            this.strRole = strRole;

            if (this.strRole == "PRODUCCION")
            {
                dataGridView1.Columns[1].ReadOnly = true;
                //dataGridView1.Columns[6].ReadOnly = true;
                dataGridView1.Columns[9].ReadOnly = true;
                dataGridView1.Columns[10].ReadOnly = true;

                //comboBox1.Enabled = false;
            }
            if (this.strRole == "ENTREGAS")
            {
                dataGridView1.Columns[0].ReadOnly = true;
            }

            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                DateTime dt1 = dateTimePicker1.Value;
                DateTime dt2 = dateTimePicker2.Value;
                dataGridView1.Rows.Clear();
                List<VREPGEN> a = db.VREPGENs.SqlQuery("Select * from VREPGEN where Fecha >= @a and Fecha <= @b",
                    new SqlParameter[] { new SqlParameter("@a", dt1), new SqlParameter("@b", dt2) }).ToList<VREPGEN>();
                for (int i = 0; i < a.Count; i++)
                {
                    int id1 = a[i].CIDMOVIMIENTO;

                    if (db.productions.Any(o => o.PaymentID == id1))
                    {

                    }
                    else
                    {
                        production po = new production();
                        po.PaymentID = a[i].CIDMOVIMIENTO;
                        db.productions.Add(po);
                        db.SaveChanges();
                    }
                }
                var result = (from t in db.VREPGENs
                              join s in db.productions on t.CIDMOVIMIENTO equals s.PaymentID
                              where (t.Fecha >= dt1.Date && t.Fecha <= dt2.Date && s.ENTREG == false)
                              orderby t.Fecha, t.Folio, t.CIDMOVIMIENTO
                              select new
                              {
                                  ARM = s.ARM,
                                  ENTREG = s.ENTREG,
                                  ID = t.CIDMOVIMIENTO,
                                  Fecha = t.Fecha,
                                  Folio = t.Folio,
                                  Clientes = t.Clientes,
                                  Producto = t.Producto,
                                  Detalles1 = t.Detalles1,
                                  Detalles2 = t.Detalles2,
                                  Armador = s.Armador,
                                  Obervaciones = s.Observaciones,
                                  Total = t.Total
                              }
                            ).ToList();

                var val = db.users.Select(x => x.Name).ToList();
                comboBox1.DataSource = val;

                decimal sum2 = 0;

                for (int i = 0; i < result.Count; i++)
                {
                    String strArmador = result[i].Armador;
                    if (result[i].Armador != null)
                    {
                        for (int j = 0; j < val.Count; j++)
                        {
                            if (val[j] == result[i].Armador)
                            {
                                strArmador = result[i].Armador;
                                break;
                            }
                            else
                                strArmador = null;

                        }
                    }
                    string[] row = new string[] {
                        (result[i].ARM) ? "true" : "false",
                        (result[i].ENTREG) ? "true" : "false",
                        result[i].ID.ToString(),
                        result[i].Fecha.ToString("yyyy-MM-dd"),
                        result[i].Folio.ToString(),
                        result[i].Clientes,
                        result[i].Producto,
                        result[i].Detalles1,
                        result[i].Detalles2,
                        strArmador,
                        result[i].Obervaciones,
                        result[i].Total.ToString("C2", new CultureInfo("en-US", false))
                    };

                    dataGridView1.Rows.Add(row);

                    if (result[i].Total.ToString() != string.Empty)
                    {
                        sum2 += Convert.ToDecimal(result[i].Total.ToString());
                    }
                }

                //String strCur = sum2.ToString("C2", CultureInfo.CurrentCulture);
                label9.Text = sum2.ToString("C2", new CultureInfo("en-US", false));

                this.Armado.MaxDropDownItems = 4;
                for (int i = 0; i < val.Count; i++)
                    this.Armado.Items.Add(val[i]);
            }
            barcode_reader.Focus();
            barcode_reader.Select();
        }

        public productionform()
        {
            InitializeComponent();

            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                dataGridView1.Rows.Clear();

                DateTime dt1 = dateTimePicker1.Value;
                DateTime dt2 = dateTimePicker2.Value;
                List<VREPGEN> a = db.VREPGENs.SqlQuery("Select * from VREPGEN where Fecha >= @a and Fecha <= @b",
                    new SqlParameter[] { new SqlParameter("@a", dt1), new SqlParameter("@b", dt2) }).ToList<VREPGEN>();
                for (int i = 0; i < a.Count; i++)
                {
                    int id1 = a[i].CIDMOVIMIENTO;

                    if (db.productions.Any(o => o.PaymentID == id1))
                    {

                    }
                    else
                    {
                        production po = new production();
                        po.PaymentID = a[i].CIDMOVIMIENTO;
                        db.productions.Add(po);
                        db.SaveChanges();
                    }
                }
                var result = (from t in db.VREPGENs
                              join s in db.productions on t.CIDMOVIMIENTO equals s.PaymentID
                              where (t.Fecha >= dt1.Date && t.Fecha <= dt2.Date && s.ENTREG == false)
                              orderby t.Fecha, t.Folio, t.CIDMOVIMIENTO
                              select new
                              {
                                  ARM = s.ARM,
                                  ENTREG = s.ENTREG,
                                  ID = t.CIDMOVIMIENTO,
                                  Fecha = t.Fecha,
                                  Folio = t.Folio,
                                  Clientes = t.Clientes,
                                  Producto = t.Producto,
                                  Detalles1 = t.Detalles1,
                                  Detalles2 = t.Detalles2,
                                  Armador = s.Armador,
                                  Obervaciones = s.Observaciones,
                                  Total = t.Total
                              }
                            ).ToList();

                var val = db.users.Select(x => x.Name).ToList();
                comboBox1.DataSource = val;

                decimal sum2 = 0;

                for (int i = 0; i < result.Count; i++)
                {
                    String strArmador = result[i].Armador;
                    if (result[i].Armador != null)
                    {
                        for (int j = 0; j < val.Count; j++)
                        {
                            if (val[j] == result[i].Armador)
                            {
                                strArmador = result[i].Armador;
                                break;
                            }
                            else
                                strArmador = null;

                        }
                    }
                    string[] row = new string[] {
                        (result[i].ARM) ? "true" : "false",
                        (result[i].ENTREG) ? "true" : "false",
                        result[i].ID.ToString(),
                        result[i].Fecha.ToString("yyyy-MM-dd"),
                        result[i].Folio.ToString(),
                        result[i].Clientes,
                        result[i].Producto,
                        result[i].Detalles1,
                        result[i].Detalles2,
                        strArmador,
                        result[i].Obervaciones,
                        result[i].Total.ToString("C2", new CultureInfo("en-US", false))
                    };

                    dataGridView1.Rows.Add(row);

                    if (result[i].Total.ToString() != string.Empty)
                    {
                        sum2 += Convert.ToDecimal(result[i].Total.ToString());
                    }
                }

                label9.Text = sum2.ToString("C2", new CultureInfo("en-US", false));

                this.Armado.MaxDropDownItems = 4;
                for (int i = 0; i < val.Count; i++)
                    this.Armado.Items.Add(val[i]);

            }

            barcode_reader.Focus();
            barcode_reader.Select();
        }

        public DataTable LINQResultToDataTable<t>(IEnumerable<t> Linqlist)
        {
            DataTable dt = new DataTable();
            PropertyInfo[] columns = null;
            if (Linqlist == null) return dt;
            foreach (t Record in Linqlist)
            {
                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;
                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }
                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }
                DataRow dr = dt.NewRow();
                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue(Record, null);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public DataTable ToDataTable<T>(IEnumerable<T> items)
        {
            var tb = new DataTable(typeof(T).Name);
            System.Reflection.PropertyInfo[] props = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (var prop in props)
            {
                tb.Columns.Add(prop.Name, prop.PropertyType);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                tb.Rows.Add(values);
            }
            return tb;
        }

        private void btnFetchData_Click(object sender, EventArgs e)
        {
            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                if (textBox1.Text != string.Empty)
                {
                    int nId = int.Parse(textBox1.Text.Trim());
                    dataGridView1.Rows.Clear();
                    List<VREPGEN> a = db.VREPGENs.SqlQuery("Select * from VREPGEN where CIDMOVIMIENTO = @a",
                        new SqlParameter("@a", nId)).ToList<VREPGEN>();
                    for (int i = 0; i < a.Count; i++)
                    {
                        int id1 = a[i].CIDMOVIMIENTO;

                        if (db.productions.Any(o => o.PaymentID == id1))
                        {

                        }
                        else
                        {
                            production po = new production();
                            po.PaymentID = a[i].CIDMOVIMIENTO;
                            db.productions.Add(po);
                            db.SaveChanges();
                        }
                    }
                    var result = (from t in db.VREPGENs
                                  join s in db.productions on t.CIDMOVIMIENTO equals s.PaymentID
                                  where t.CIDMOVIMIENTO == nId
                                  select new
                                  {
                                      ARM = s.ARM,
                                      ENTREG = s.ENTREG,
                                      ID = t.CIDMOVIMIENTO,
                                      Fecha = t.Fecha,
                                      Folio = t.Folio,
                                      Clientes = t.Clientes,
                                      Producto = t.Producto,
                                      Detalles1 = t.Detalles1,
                                      Detalles2 = t.Detalles2,
                                      Armador = s.Armador,
                                      Obervaciones = s.Observaciones,
                                      Total = t.Total
                                  }
                                ).ToList();

                    var val = db.users.Select(x => x.Name).ToList();

                    decimal sum2 = 0;

                    for (int i = 0; i < result.Count; i++)
                    {
                        String strArmador = result[i].Armador;
                        if (result[i].Armador != null)
                        {
                            for (int j = 0; j < val.Count; j++)
                            {
                                if (val[j].Trim() == result[i].Armador.Trim())
                                {
                                    strArmador = result[i].Armador;
                                    break;
                                }
                                else
                                    strArmador = null;

                            }
                        }

                        if (strArmador != null)
                            strArmador = strArmador.ToString().Trim();

                        string[] row = new string[] {
                            (result[i].ARM) ? "true" : "false",
                            (result[i].ENTREG) ? "true" : "false",
                            result[i].ID.ToString(),
                            result[i].Fecha.ToString("yyyy-MM-dd"),
                            result[i].Folio.ToString(),
                            result[i].Clientes,
                            result[i].Producto,
                            result[i].Detalles1,
                            result[i].Detalles2,
                            strArmador,
                            result[i].Obervaciones,
                            result[i].Total.ToString("C2", new CultureInfo("en-US", false))
                        };

                        dataGridView1.Rows.Add(row);

                        if (result[i].Total.ToString() != string.Empty)
                        {
                            sum2 += Convert.ToDecimal(result[i].Total.ToString());
                        }
                    }

                    label9.Text = sum2.ToString("C2", new CultureInfo("en-US", false));
                }
                else
                {

                }

            }
            barcode_reader.Focus();
            barcode_reader.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                if (textBox2.Text != string.Empty)
                {
                    int folio = int.Parse(textBox2.Text.Trim());
                    dataGridView1.Rows.Clear();
                    List<VREPGEN> a = db.VREPGENs.SqlQuery("Select * from VREPGEN where Folio = @a",
                        new SqlParameter("@a", folio)).ToList<VREPGEN>();
                    for (int i = 0; i < a.Count; i++)
                    {
                        int id1 = a[i].CIDMOVIMIENTO;

                        if (db.productions.Any(o => o.PaymentID == id1))
                        {

                        }
                        else
                        {
                            production po = new production();
                            po.PaymentID = a[i].CIDMOVIMIENTO;
                            db.productions.Add(po);
                            db.SaveChanges();
                        }
                    }
                    var result = (from t in db.VREPGENs
                                  join s in db.productions on t.CIDMOVIMIENTO equals s.PaymentID
                                  where t.Folio == folio
                                  orderby t.Fecha, t.Folio, t.CIDMOVIMIENTO
                                  select new
                                  {
                                      ARM = s.ARM,
                                      ENTREG = s.ENTREG,
                                      ID = t.CIDMOVIMIENTO,
                                      Fecha = t.Fecha,
                                      Folio = t.Folio,
                                      Clientes = t.Clientes,
                                      Producto = t.Producto,
                                      Detalles1 = t.Detalles1,
                                      Detalles2 = t.Detalles2,
                                      Armador = s.Armador,
                                      Obervaciones = s.Observaciones,
                                      Total = t.Total
                                  }
                                ).ToList();

                    var val = db.users.Select(x => x.Name).ToList();

                    decimal sum2 = 0;

                    for (int i = 0; i < result.Count; i++)
                    {
                        String strArmador = result[i].Armador;
                        if (result[i].Armador != null)
                        {
                            for (int j = 0; j < val.Count; j++)
                            {
                                if (val[j].Trim() == result[i].Armador.Trim())
                                {
                                    strArmador = result[i].Armador;
                                    break;
                                }
                                else
                                    strArmador = null;

                            }
                        }

                        if (strArmador != null)
                            strArmador = strArmador.ToString().Trim();

                        string[] row = new string[] {
                            (result[i].ARM) ? "true" : "false",
                            (result[i].ENTREG) ? "true" : "false",
                            result[i].ID.ToString(),
                            result[i].Fecha.ToString("yyyy-MM-dd"),
                            result[i].Folio.ToString(),
                            result[i].Clientes,
                            result[i].Producto,
                            result[i].Detalles1,
                            result[i].Detalles2,
                            strArmador,
                            result[i].Obervaciones,
                            result[i].Total.ToString("C2", new CultureInfo("en-US", false))
                        };

                        dataGridView1.Rows.Add(row);

                        if (result[i].Total.ToString() != string.Empty)
                        {
                            sum2 += Convert.ToDecimal(result[i].Total.ToString());
                        }
                    }

                    label9.Text = sum2.ToString("C2", new CultureInfo("en-US", false));
                }
                else
                {

                }

            }
            barcode_reader.Focus();
            barcode_reader.Select();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
            //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            DataGridViewSelectedRowCollection select= dataGridView1.SelectedRows;
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;
            productionentryform frm = new productionentryform(row);
            frm.Show();
           this.Close();
           */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                string armador = comboBox1.SelectedItem.ToString();
                DateTime dt1 = dateTimePicker1.Value;
                DateTime dt2 = dateTimePicker2.Value;
                Console.WriteLine(armador);
                dataGridView1.Rows.Clear();

                var result = (from t in db.VREPGENs
                              join s in db.productions on t.CIDMOVIMIENTO equals s.PaymentID
                              where (s.Armador == armador) && (t.Fecha >= dt1.Date && t.Fecha <= dt2.Date)
                              orderby t.Fecha, t.Folio, t.CIDMOVIMIENTO
                              select new
                              {
                                  ARM = s.ARM,
                                  ENTREG = s.ENTREG,
                                  ID = t.CIDMOVIMIENTO,
                                  Fecha = t.Fecha,
                                  Folio = t.Folio,
                                  Clientes = t.Clientes,
                                  Producto = t.Producto,
                                  Detalles1 = t.Detalles1,
                                  Detalles2 = t.Detalles2,
                                  Armador = s.Armador,
                                  Obervaciones = s.Observaciones,
                                  Total = t.Total
                              }
                            ).ToList();

                var val = db.users.Select(x => x.Name).ToList();

                decimal sum2 = 0;

                for (int i = 0; i < result.Count; i++)
                {
                    String strArmador = result[i].Armador;
                    if (result[i].Armador != null)
                    {
                        for (int j = 0; j < val.Count; j++)
                        {
                            if (val[j].Trim() == result[i].Armador.Trim())
                            {
                                strArmador = result[i].Armador;
                                break;
                            }
                            else
                                strArmador = null;

                        }
                    }

                    if (strArmador != null)
                        strArmador = strArmador.ToString().Trim();

                    string[] row = new string[] {
                        (result[i].ARM) ? "true" : "false",
                        (result[i].ENTREG) ? "true" : "false",
                        result[i].ID.ToString(),
                        result[i].Fecha.ToString("yyyy-MM-dd"),
                        result[i].Folio.ToString(),
                        result[i].Clientes,
                        result[i].Producto,
                        result[i].Detalles1,
                        result[i].Detalles2,
                        strArmador,
                        result[i].Obervaciones,
                        result[i].Total.ToString("C2", new CultureInfo("en-US", false))
                    };

                    dataGridView1.Rows.Add(row);

                    if (result[i].Total.ToString() != string.Empty)
                    {
                        sum2 += Convert.ToDecimal(result[i].Total.ToString());
                    }
                }

                label9.Text = sum2.ToString("C2", new CultureInfo("en-US", false));
            }
            barcode_reader.Focus();
            barcode_reader.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                dataGridView1.Rows.Clear();

                DateTime dt1 = dateTimePicker1.Value;
                DateTime dt2 = dateTimePicker2.Value;
                List<VREPGEN> a = db.VREPGENs.SqlQuery("Select * from VREPGEN where Fecha >= @a and Fecha <= @b",
                    new SqlParameter[] { new SqlParameter("@a", dt1), new SqlParameter("@b", dt2) }).ToList<VREPGEN>();
                for (int i = 0; i < a.Count; i++)
                {
                    int id1 = a[i].CIDMOVIMIENTO;

                    if (db.productions.Any(o => o.PaymentID == id1))
                    {

                    }
                    else
                    {
                        production po = new production();
                        po.PaymentID = a[i].CIDMOVIMIENTO;
                        db.productions.Add(po);
                        db.SaveChanges();
                    }
                }
                var result = (from t in db.VREPGENs
                              join s in db.productions on t.CIDMOVIMIENTO equals s.PaymentID
                              where (t.Fecha >= dt1.Date && t.Fecha <= dt2.Date && s.ENTREG == false)
                              orderby t.Fecha, t.Folio, t.CIDMOVIMIENTO
                              select new
                              {
                                  ARM = s.ARM,
                                  ENTREG = s.ENTREG,
                                  ID = t.CIDMOVIMIENTO,
                                  Fecha = t.Fecha,
                                  Folio = t.Folio,
                                  Clientes = t.Clientes,
                                  Producto = t.Producto,
                                  Detalles1 = t.Detalles1,
                                  Detalles2 = t.Detalles2,
                                  Armador = s.Armador,
                                  Obervaciones = s.Observaciones,
                                  Total = t.Total
                              }
                            ).ToList();

                var val = db.users.Select(x => x.Name).ToList();

                decimal sum2 = 0;

                for (int i = 0; i < result.Count; i++)
                {
                    String strArmador = result[i].Armador;
                    if (result[i].Armador != null)
                    {
                        for (int j = 0; j < val.Count; j++)
                        {
                            if (val[j].Trim() == result[i].Armador.Trim())
                            {
                                strArmador = result[i].Armador;
                                break;
                            }
                            else
                                strArmador = null;

                        }
                    }

                    if (strArmador != null)
                        strArmador = strArmador.ToString().Trim();

                    string[] row = new string[] {
                        (result[i].ARM) ? "true" : "false",
                        (result[i].ENTREG) ? "true" : "false",
                        result[i].ID.ToString(),
                        result[i].Fecha.ToString("yyyy-MM-dd"),
                        result[i].Folio.ToString(),
                        result[i].Clientes,
                        result[i].Producto,
                        result[i].Detalles1,
                        result[i].Detalles2,
                        strArmador,
                        result[i].Obervaciones,
                        result[i].Total.ToString("C2", new CultureInfo("en-US", false))
                    };

                    dataGridView1.Rows.Add(row);

                    if (result[i].Total.ToString() != string.Empty)
                    {
                        sum2 += Convert.ToDecimal(result[i].Total.ToString());
                    }
                }

                label9.Text = sum2.ToString("C2", new CultureInfo("en-US", false));

            }
            barcode_reader.Focus();
            barcode_reader.Select();
        }

        private void lnkSettings_Click(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
                return;
            }

            userform frm = new userform();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[0].Value + "-----");

            if (Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) == true && Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) == false)
            {
                // Color col = Color.Green;

                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                //dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
            }
            else if (Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) == false && Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) == true)
            {
                Color col = Color.LightGreen;

                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                //dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
            }
            else if (Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) == true && Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) == true)
            {
                Color col = Color.LightGreen;

                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                //dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
            }
            else
            {
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }


            //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];// get you required index
            // check the cell value under your specific column and then you can toggle your colors
            //  row.DefaultCellStyle.BackColor = Color.Green;
        }

        private void textbox1_keypress(object sender, KeyPressEventArgs e)
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

        private void textbox2_keypress(object sender, KeyPressEventArgs e)
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

        private void dataGridViewer1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String strNew = "";

            if (dataGridView1[e.ColumnIndex, e.RowIndex].Value == null)//incase it is a blanked cell
            {
                strNew = "";
            }
            else
            {
                strNew = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            }

            int nId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            String strArmdas = ((dataGridView1.Rows[e.RowIndex].Cells[9].Value == null) ? "" : dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
            String strOber = ((dataGridView1.Rows[e.RowIndex].Cells[10].Value == null) ? "" : dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());

            using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
            {
                var result = db.productions.Single(b => b.PaymentID == nId);
                if (result != null)
                {
                    try
                    {
                        String dt = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                        if (this.strRole == "PRODUCCION" || this.strRole == "ADMIN")     //ARM, ARM_Fecha 
                        {
                            result.ARM = Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                            result.ARM_Fecha = (Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) == true ? dt : "");
                        }
                        if (this.strRole == "ENTREGAS" || this.strRole == "ADMIN")   //ENTREG, ENTREG_Fecha
                        {
                            result.ENTREG = Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                            result.ENTREG_Fecha = (Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) == true ? dt : "");
                            result.ENTREG_User = Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) ? this.m_strUserName : "";
                            result.Armador = strArmdas;
                            result.Observaciones = strOber;
                        }
                        

                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        String strEx = ex.ToString();
                        MessageBox.Show(strEx);
                    }
                }
            }

            barcode_reader.Focus();
            barcode_reader.Select();
        }

        private void productionFormClosing(object sender, FormClosedEventArgs e)
        {
            if (this.strRole == "PRODUCCION" || this.strRole == "ENTREGAS")
                Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (this.strRole == "PRODUCCION")
            //{
            //    MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
            //    return;
            //}
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            frmReportProdDay aa = new frmReportProdDay(dt1, dt2, this.m_strUserName);
            aa.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if (this.strRole == "PRODUCCION")
            //{
            //    MessageBox.Show("NO TIENE ACCESO A ESTE MODULO");
            //    return;
            //}
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            string armador = comboBox1.SelectedItem.ToString();
            frmReportProdDay aa = new frmReportProdDay(dt1, dt2, this.m_strUserName, armador);
            aa.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            frmReportProdDayArmed aa = new frmReportProdDayArmed(dt1, dt2, this.m_strUserName);
            aa.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.strRole == "PRODUCCION")
            {
                return;
            }
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            frmReportProdDayDeliverd aa = new frmReportProdDayDeliverd(dt1, dt2, this.m_strUserName);
            aa.ShowDialog();
        }

        private void barcodeInputKeyDownHandler(object sender, KeyEventArgs e)
        {
            //  0000000008938
            if (e.KeyCode == Keys.Enter)    //enter key is down
            {
                String strBarcode = barcode_reader.Text;

                if (strBarcode.Length == 12) strBarcode = "0" + strBarcode;
                if (strBarcode.Length != 13)
                {
                    MessageBox.Show("Please try again scan barcode.");
                    barcode_reader.Text = "";
                    barcode_reader.Focus();
                    return;
                }

                Ean13 ean13 = new Ean13();
                ean13.CountryCode = strBarcode.Substring(0, 2);
                ean13.ManufacturerCode = strBarcode.Substring(2, 5);
                ean13.ProductCode = strBarcode.Substring(7, 5);
                ean13.CalculateChecksumDigit();
                if (strBarcode.Substring(12, 1) != ean13.ChecksumDigit)
                {
                    MessageBox.Show("Please try again scan barcode.");
                    barcode_reader.Text = "";
                    barcode_reader.Focus();
                    return;
                }

                strBarcode = strBarcode.Substring(0, 12);
                int index = 0;
                while (strBarcode.Substring(index, 1) == "0")
                {
                    index++;
                }

                String strID = strBarcode.Substring(index, 12 - index);

                String dt = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                int nID = int.Parse(strID);

                using (Christian_FranciscoEntities db = new Christian_FranciscoEntities())
                {
                    var result = db.productions.SingleOrDefault(b => b.PaymentID == nID);

                    if (result != null)
                    {
                        try
                        {
                            if (this.strRole == "PRODUCCION" || this.strRole == "ADMIN")     //ARM, ARM_Fecha 
                            {
                                result.ARM = true;
                                result.ARM_Fecha = dt;
                            }
                            if (this.strRole == "ENTREGAS" || this.strRole == "ADMIN")   //ENTREG, ENTREG_Fecha
                            {
                                result.ENTREG = true;
                                result.ENTREG_Fecha = dt;
                                result.ENTREG_User = this.m_strUserName;
                            }

                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            String strEx = ex.ToString();
                            MessageBox.Show(strEx);
                        }
                    }
                    else
                    {
                        try
                        {
                            production po = new production();

                            po.PaymentID = nID;

                            if (this.strRole == "PRODUCCION" || this.strRole == "ADMIN")     //ARM, ARM_Fecha 
                            {
                                po.ARM = true;
                                po.ARM_Fecha = dt;
                            }
                            if (this.strRole == "ENTREGAS" || this.strRole == "ADMIN")   //ENTREG, ENTREG_Fecha
                            {
                                po.ENTREG = true;
                                po.ENTREG_Fecha = dt;
                                po.ENTREG_User = this.m_strUserName;
                            }

                            db.productions.Add(po);

                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            String strEx = ex.ToString();
                            MessageBox.Show(strEx);
                        }
                    }
                }

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) == nID)
                    {
                        if (this.strRole == "PRODUCCION" || this.strRole == "ADMIN")     //ARM, ARM_Fecha 
                        {
                            dataGridView1.Rows[i].Cells[0].Value = true;
                            MessageBox.Show(strID + " checked");

                            barcode_reader.Text = "";
                            barcode_reader.Focus();

                            break;
                        }
                        if (this.strRole == "ENTREGAS" || this.strRole == "ADMIN")   //ENTREG, ENTREG_Fecha
                        {
                            dataGridView1.Rows[i].Cells[1].Value = true;
                            MessageBox.Show(strID + " checked");

                            barcode_reader.Text = "";
                            barcode_reader.Focus();

                            break;
                        }
                    }
                }
            }
        }
    }
}
