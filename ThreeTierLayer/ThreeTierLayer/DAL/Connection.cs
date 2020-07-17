using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTierLayer.DAL
{
    class Connection
    {
        String a;
        //perameter constructor
        public Connection(String a)
        {
            this.a = a;
        }
        //default constructor
        public Connection()
        {

        }
        public SqlConnection con = new SqlConnection
            ("Data Source=.;Initial Catalog=registryDb;Integrated Security=True");
    }
}
