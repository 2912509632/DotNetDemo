using System;
using System.Data.SqlClient;

namespace SQLConnection类
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqlStr = "data source=.;database=student;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(sqlStr);
            try
            {
                conn.Open();
                Console.WriteLine("数据库连接已打开！");
            }
            catch
            {
                Console.WriteLine("数据库连接出现异常！");
            }
            finally
            {
                conn.Close();
                Console.WriteLine("数据库连接已关闭！");
            }
        }
    }
}
