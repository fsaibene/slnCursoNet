using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALIntegrador
{
    internal static class ServiceDB
    {
        internal static SqlConnection Conexion()
        {
            string connStr = Properties.Settings.Default.dbCurso;
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }
    }
}
