using System;
using System.Data.SqlClient;
using System.Configuration;
namespace DataAL
{
    public class Helper
    {
        SqlConnection conn;
        SqlCommand cmd;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            using (conn = new SqlConnection(cstr))
            {
                using (cmd = new SqlCommand(cmdtext, conn))
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
