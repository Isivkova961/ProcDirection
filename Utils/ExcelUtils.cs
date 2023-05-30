using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assistant.Utils
{
    public static class ExcelUtils
    {
        public static string ConnectionString(string FileName)
        {
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=" + FileName + ";" + "Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";
            return connectionString;
        }

        public static void Exec(this OleDbCommand cmd)
        {
            cmd.TryExec(() => cmd.ExecuteNonQuery());
        }

        public static OleDbCommand Query(this string commandText, string FileName)
        {
            return commandText.Query(CommandType.Text, FileName);
        }

        public static OleDbCommand StoredProc(this string commandText, string FileName)
        {
            return commandText.Query(CommandType.StoredProcedure, FileName);
        }

        private static OleDbCommand Query(this string commandText, CommandType commandType, string FileName)
        {
            var cmd = new OleDbCommand
            {
                Connection = new OleDbConnection(ConnectionString(FileName)),
                CommandText = commandText,
                CommandType = commandType,
                CommandTimeout = 216000
            }; //60 * 60 * 60
            return cmd;
        }

        public static DataTable ToDataTable(this OleDbCommand cmd)
        {
            DataTable dt = null;
            cmd.TryExec(() =>
            {
                var da = new OleDbDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            });
            return dt;
        }

        private static void TryExec(this OleDbCommand cmd, ThreadStart func)
            //, NpgsqlInfoMessageEventHandler onInfoMessage = null)
        {
            var commandText = cmd.CommandText ?? "-";
            if (commandText.Length > 60)
                commandText = commandText.Substring(0, 60).Replace("\r", " ").Replace("\n", " ") + "...";
            var message = string.Format("{0} <{1}>", cmd.CommandType, commandText);
            InternalTryExec(cmd, func);
        }

        public static DataTable TableWorkExcel(string FileName)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet("EXCEL");
            OleDbConnection con = new OleDbConnection(ConnectionString(FileName));
            con.Open();
            DataTable schemaTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                         new object[] { null, null, null, "TABLE" });
            string sheet1 = (string)schemaTable.Rows[0].ItemArray[2];
            // Берем название первого листа
            string select = String.Format("SELECT * FROM [{0}]", sheet1);

            OleDbDataAdapter ad = new OleDbDataAdapter(select, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }

        private static object InternalTryExec(OleDbCommand cmd, ThreadStart func)
        {
            using (cmd.Connection)
            {
                using (cmd)
                {
                    try
                    {
                        if (cmd.Connection.State != ConnectionState.Open)
                        {
                            cmd.Connection.Open();
                        }
                        func();
                    }
                    catch (Exception e)
                    {
                    }
                    finally
                    {
                        cmd.Connection.Close();
                    }
                    return null;
                }
            }
        }
    }
}
