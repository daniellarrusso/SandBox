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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        
        public DataSet NA_Bind()
        {
            SqlDataAdapter sda = new SqlDataAdapter("dbo.GetGenre", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;

        }
        public void insertData (SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "GetGenre";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        public DataTable SearchGenre(string name)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                using (SqlDataAdapter ad = new SqlDataAdapter("SearchGenre", conn))
                {
                    ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter prm = new SqlParameter("@name", SqlDbType.VarChar);
                    prm.Value = name;
                    ad.SelectCommand.Parameters.Add(prm);

                    ad.Fill(table);
                }
            }
            return table;
        }
    }
}
