using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTierLayer.DAL
{
    class ProfileDAL
    {
        DataTable dt = new DataTable();// default constructor //object
        public DataTable ReadProfile()
        {
            // 2 type of method such as return method and void method
            Connection conn = new Connection();
            if(ConnectionState.Closed == conn.con.State)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from preUsers", conn.con);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }catch
            {
                throw;
            }
      
        } 
    }
}
