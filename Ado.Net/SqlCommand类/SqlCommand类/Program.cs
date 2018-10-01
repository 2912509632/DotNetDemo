using System;
using System.Data.SqlClient;

namespace SqlCommand类
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqlStr = "data source=.;database=student;integrated security=SSPI;";
            using (SqlConnection conn = new SqlConnection(sqlStr))
            {
                conn.Open();
                string sql = "insert into test values(1)";
                SqlCommand cmd = new SqlCommand(sql,conn);
                int line = cmd.ExecuteNonQuery();
                Console.WriteLine("插入{0}调数据",line);
            }
        }
    }
}
