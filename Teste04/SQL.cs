using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes04e05
{
    public class SQL
    {
        public SqlConnection connection = new SqlConnection();

        public SQL()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = "DESKTOP-5LSHH6H\\SQLEXPRESS"; 
            sb.UserID = "sa"; 
            sb.Password = "ygor1234";
            sb.InitialCatalog = "Aluno"; 
            sb.Encrypt = true; 
            sb.TrustServerCertificate = true;

            connection.ConnectionString = sb.ConnectionString;
        }
    }
}
