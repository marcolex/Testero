using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.API
{
    public class SqlOperation
    {

        public string ProcedureName { get; set; }
        public List<MySqlParameter> Parameters { get; set; }

        public SqlOperation()
        {
            Parameters = new List<MySqlParameter>();
        }

        public void AddVarcharParam(string paramName, string paramValue)
        {
            var param = new MySqlParameter("_" + paramName, MySqlDbType.VarChar)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }

        public void AddIntParam(string paramName, int paramValue)
        {
            var param = new MySqlParameter("_" + paramName, MySqlDbType.Int32)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }

        public void AddDoubleParam(string paramName, double paramValue)
        {
            var param = new MySqlParameter("_" + paramName, MySqlDbType.Decimal)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }

        public void AddDateTimeParam(string paramName, DateTime paramValue)
        {
            var param = new MySqlParameter("_" + paramName, MySqlDbType.DateTime)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }

        internal void AddStringParam(string paramName, string paramValue)
        {
            var param = new MySqlParameter("_" + paramName, MySqlDbType.String)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }
    }
}
