using System.Configuration;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    public class SqlConnections
    {
        private static string ConnectionString
        {
            get
            {
                string conn = ConfigurationManager.ConnectionStrings["NorthWindConnection"].ToString();
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder (conn);
                sb.ApplicationName = ApplicationName ?? sb.ApplicationName;
                sb.ConnectTimeout = (ConnectionTimeout > 0) ? ConnectionTimeout : sb.ConnectTimeout;
                return sb.ToString();
            }
        }

        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
            
        }

        public static string ApplicationName { get; set; }

        public static int ConnectionTimeout { get; set; }
    }
}
