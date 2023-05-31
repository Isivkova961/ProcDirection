using System;
using System.Collections.Generic;
using System.Configuration;
using Npgsql;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Dynamic;

namespace Assistant.Utils
{
    public static class SqlUtils
    {
        public static string messageErr = "";
        public static void Exec(this SqlCommand cmd)
        {
            cmd.TryExec(() => cmd.ExecuteNonQuery());
        }

        public static string ExecD(this SqlCommand cmd)
        {
            dynamic o = null;
            cmd.TryExec(() =>
            {
                o = cmd.ExecuteScalar().ToString();

            });
            return o;
        }
    

        public static dynamic ToParams(this SqlCommand cmd)
        {
            dynamic o = null;
            cmd.TryExec(() =>
            {
                cmd.ExecuteNonQuery();
                o = new ExpandoObject();
                var dict = (IDictionary<string, object>)o;
                foreach (SqlParameter param in cmd.Parameters)
                {
                    dict.Add(param.ParameterName.TrimStart('@'), param.Value);
                }
            });
            return o;
        }

        public static DataSet ToDataSet(this SqlCommand cmd)
        {
            DataSet ds = null;
            cmd.TryExec(() =>
            {
                var da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
            });
            return ds;
        }

        public static DataTable ToDataTable(this SqlCommand cmd)
        {
            DataTable dt = null;
            cmd.TryExec(() =>
            {
                var da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            });
            return dt;
        }

        public static SqlDataReader ToDataReader(this SqlCommand cmd)
        {
            SqlDataReader dr = null;
            cmd.TryExec(() =>
            {
                dr = cmd.ExecuteReader();
            });
            return dr;
        }


        public static SqlCommand Params(this SqlCommand cmd, params object[] args)
        {
            if (args == null || args.Length == 0) return cmd;
            cmd.Parameters.AddWithValue(args[0].ToString(), args[1]);
            return cmd;
        }


        private static void TryExec(this SqlCommand cmd, ThreadStart func)
        {
                var commandText = cmd.CommandText ?? "-";
                if (commandText.Length > 60) commandText = commandText.Substring(0, 60).Replace("\r", " ").Replace("\n", " ") + "...";
                var message = string.Format("{0} <{1}>", cmd.CommandType, commandText);

            InternalTryExec(cmd, func);

        }

        private static object InternalTryExec(SqlCommand cmd, ThreadStart func)
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
                        messageErr = e.Message;
                    }
                    finally
                    {
                        cmd.Connection.Close();
                    }
                    return null;
                }
            }
        }

        public static string ConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["bd"].ConnectionString;
            return connectionString;
        }

        public static SqlCommand Query(this string commandText)
        {
            return commandText.Query(CommandType.Text);
        }

        public static SqlCommand StoredProc(this string commandText)
        {
            return commandText.Query(CommandType.StoredProcedure);
        }

        private static SqlCommand Query(this string commandText, CommandType commandType)
        {
            var cmd = new SqlCommand
            {
                Connection = new SqlConnection(ConnectionString()),
                CommandText = commandText,
                CommandType = commandType,
                CommandTimeout = 216000
            }; //60 * 60 * 60
            return cmd;
        }

        public static SqlReader ToReader(this SqlCommand cmd)
        {
            return cmd != null ? new SqlReader(cmd) : null;
        }

        public static dynamic[] ToArray(this SqlCommand cmd)
         {
             var results = new List<dynamic[]>();
             cmd.TryExec(() =>
             {
                 var reader = cmd.ToReader();
                 var list = new List<IDictionary<string, object>>();
                 foreach (IDictionary<string, object> item in reader)
                 {
                     if (reader.TableNumber > results.Count)
                     {
                         results.Add(list.ToArray());
                         while (reader.TableNumber > results.Count)
                         {
                             results.Add(new IDictionary<string, object>[0]);
                         }
                         list.Clear();
                     }
                     list.Add(item);
                 }
                 results.Add(list.ToArray());
                 while (reader.TotalTableCount >= results.Count) //данные кусок кода нужен для корректной обработки пустых наборов, которые возвращаются в конце
                 {
                     results.Add(new IDictionary<string, object>[0]);
                 }
             });
             return results.Count == 1 ? results[0] : results.ToArray();
         }

        }
}
