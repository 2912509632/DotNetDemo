using System;
using System.Data.SqlClient;

namespace SQLServer连接数据库
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据库连接字符串
            string sqlStr = "data source=.;database=student;integrated security=SSPI";
            //数据连接对象
            SqlConnection conn = new SqlConnection(sqlStr);
            try
            {
                //打开数据库连接
                conn.Open();
                //创建数据表语句
                string createTable = "create table test(id int primary key)";
                //命令执行对象
                SqlCommand cmd = new SqlCommand(createTable, conn);
                //执行命令
                int line = cmd.ExecuteNonQuery();
                Console.WriteLine("受影响行数：" + line);
            }
            finally
            {
                //关闭数据库连接
                conn.Close();
            }
        }
    }
}
