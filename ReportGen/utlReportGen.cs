using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ReportGen
{
    class utlReportGen
    {
        const string ProgName = "Reporte de Notas de Venta";
        private static string sql = "";
        private static SqlConnection con;
        private static SqlDataReader dr;
        private static SqlDataAdapter da = new SqlDataAdapter();
        private static SqlCommand cmd;
        private static DataTable dt = new DataTable();
        private static SqlCommandBuilder scb;

        private static void createCommand(String query)
        {
            con = new SqlConnection(Properties.Settings.Default.connStr);
            cmd = con.CreateCommand();
            cmd.CommandText = query;
        }
        private static SqlDataReader executeCommand()
        {            
            if (con.State == ConnectionState.Closed)
                con.Open();
            dr = cmd.ExecuteReader();
            return dr;
        }

        private static void closeConnection()
        {
            con.Close();
        }

        public static bool checkConnection()
        {
            try
            {
                sql = "select count(1) from admClientes";
                createCommand(sql);
                dr = executeCommand();
                dr.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                closeConnection();
            }
        }

        public static void GetRecords(DateTime fromDate, DateTime toDate, DataTable dtData)
        {
            try
            {
                sql = "select 0, c.c fecha,d.cfolio,b.crazonsocial,c.cunidadescapturadas,a.cnombreproducto,c.creferencia,c.cobservamov,c.cneto from admproductos  a, admclientes b, admmovimientos c,admdocumentos d  where c.ciddocumento=d.ciddocumento and a.cidproducto=c.cidproducto and b.cidclienteproveedor=d.cidclienteproveedor and c.cfecha>=@fromDate and c.cfecha<=@toDate and d.cseriedocumento='NV' order by 1";
                createCommand(sql);
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);
                dr = executeCommand();
                while(dr.Read())
                {
                    dtData.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7],dr[8]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }
        }

    }
}
