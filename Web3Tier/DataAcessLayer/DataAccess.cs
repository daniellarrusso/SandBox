using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAcessLayer
{
    public class DataAccess
    {
        SqlConnection con = SqlConnections.GetSqlConnection();

        
        public DataTable Read()
        {
            DataTable dt = new DataTable();
            
            SqlCommand cmd = new SqlCommand("dbo.GetEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                
                return dt;
            }
            catch
            {
                throw;
            }
        }

        public void insertData (SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
           // cmd.CommandText = "GetGenre";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        public DataTable SearchGenre(int employeeId)
        {
            DataTable table = new DataTable();
            using (con)
            {
                using (SqlDataAdapter ad = new SqlDataAdapter("SearchEmployees", con))
                {
                    ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter prm = new SqlParameter("@EmployeeId", SqlDbType.VarChar);
                    prm.Value = employeeId;
                    ad.SelectCommand.Parameters.Add(prm);

                    ad.Fill(table);
                }
            }
            return table;
        }
    }
}
