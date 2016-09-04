using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAcessLayer;

namespace BusinessLayer
{
    public class Business
    {
        DataAccess da = new DataAccess();

        public int Id { get; set; }
        public string Name { get; set; }

        SqlCommand cmd = new SqlCommand();

        public DataSet BL_Bind()
        {
            return da.NA_Bind();
        }

        public DataTable SearchGenre(string name)
        {
            // your businees logic, calculations or validations may go here
            return new DataAccess().SearchGenre(name);
        }
    }
}
