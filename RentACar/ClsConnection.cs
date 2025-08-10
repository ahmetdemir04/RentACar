using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class ClsConnection
    {
        public string StrConnection = @"Data Source=ETIRNESE\SQLEXPRESS;Initial Catalog=rtcar;Integrated Security=True;TrustServerCertificate=True";
      
        public SqlConnection Connection()
        {
            SqlConnection con = new SqlConnection(StrConnection);

            if (con.State != System.Data.ConnectionState.Open)
                con.Open();

            return con;
        }
    }
}
