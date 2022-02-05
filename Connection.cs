using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsAdo_CristoChacon
{
    internal class Connection
    {
        SqlConnection connection;

        public SqlConnection Connec
        {
            get { return connection; }
            set { connection = value; }
        }

        public Connection()
        {
            String strConn = "Data Source=localhost;Initial Catalog=bdHoteles;Integrated Security=true";
            Connec = new SqlConnection(strConn);
        }
    }
}
