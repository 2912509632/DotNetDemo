using System;
using System.Data.SqlClient;

namespace SqlDataReader类
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("使用SqlDataReader读取表数据");
            string sqlConn = "Data Source=.;Initial Catalog=jnds;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string sql = "select * from test";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                Console.WriteLine("Tset表的数据如下：");
                Console.WriteLine("\t ID \t UName \t Code \t addTime");
                while (sdr.Read()) //下一条有数据时返回True并读取
                {
                    Console.WriteLine("\t {0} \t {1} \t {2} \t {3}",sdr["id"],sdr["uname"],sdr["code"],sdr["addTime"]);
                }
            }
            catch
            {
                Console.WriteLine("读取数据过程中出现异常！");
            }
            finally
            {
                conn.Close();
                Console.WriteLine("数据库连接已关闭！");
            }
        }
    }
}
