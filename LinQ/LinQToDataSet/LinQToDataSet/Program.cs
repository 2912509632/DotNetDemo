using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LinQToDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //从数据库填充数据到DataSet
            string SqlConn = "Data Source=.;Initial Catalog=LINQ;Integrated Security=True";
            string sql = "select * from Test";
            SqlDataAdapter sda = new SqlDataAdapter(sql, SqlConn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            
            //使用LinQ读取DataSet中ID大于1005数据
            var query = from v in ds.Tables[0].AsEnumerable()
                        where v.Field<int>("ID") > 1005
                        select v;

            //展示数据
            foreach (var v in query)
                Console.WriteLine("ID：{0} Name：{1} Sex：{2} Time：{3} ",v.Field<int>("ID"),v.Field<string>("Name"),v.Field<string>("Sex"),v.Field<DateTime>("Time"));
        }
    }
}
