using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.DataAccess.Dao
{
    public class SqlDao
    {
        private static SqlDao _instance;

        private SqlDao()
        {

        }

        public static SqlDao GetInstance()
        {
            return _instance ?? (_instance = new SqlDao());

        }

        // private const string ConnectionString = "Data Source=172.104.22.63;Initial Catalog=ingenyas_Desktop;uid=ingenyas_ecoronado;pwd=-sjEgcQEkXYL";
        // private const string ConnectionString = "Data Source=localhost;Initial Catalog=ingenyas_desktop;uid=root;pwd=Coro.1610";
        //private const string ConnectionString = "Data Source=3.236.134.119;Initial Catalog=ingenyas_desktop;uid=app;pwd=app.1234";

        // private const string ConnectionString = "Data Source=212.1.210.98;Initial Catalog=ingenyat_dev;uid=ingenyat_admin;pwd=123Queso";
        
        private const string ConnectionString = "server=212.1.210.98;database=ingenyat_dev;user=ingenyat_admin;password=123Queso";



        public void ExecuteProcedure(SqlOperation sqlOperation)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception msg)
                {
                    throw msg;
                }
                finally
                {
                    conn.Close();
                }

            }
        }
        public List<Dictionary<string, object>> ExecuteQueryProcedure(SqlOperation sqlOperation)
        {
            var lstResult = new List<Dictionary<string, object>>();

            using (var conn = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }
                try
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var dict = new Dictionary<string, object>();
                            for (var lp = 0; lp < reader.FieldCount; lp++)
                            {
                                dict.Add(reader.GetName(lp), reader.GetValue(lp));
                            }
                            lstResult.Add(dict);
                        }
                    }
                }
                catch (Exception msg)
                {

                    throw msg;
                }
                finally
                {
                    conn.Close();
                }

            }

            return lstResult;
        }
    }
}
