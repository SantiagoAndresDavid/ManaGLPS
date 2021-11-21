using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DALL
{
    public class ConnectionManager
    {
        public DbConnection Connection;

        public ConnectionManager(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
        }

        public void Open()
        {
            Connection.Open();
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}
