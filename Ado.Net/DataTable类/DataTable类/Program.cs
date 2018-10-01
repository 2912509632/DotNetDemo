using System;
using System.Data;

namespace DataTable类
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable data = new DataTable();
            //指定列结构
            DataColumn id = new DataColumn("ID", typeof(Int32));
            data.Columns.Add(id);
            data.Columns.Add("Name",typeof(string));
            data.Columns.Add("Code",typeof(string));
            //指定主键
            DataColumn[] PKey = new DataColumn[] { data.Columns["ID"]} ;
            data.PrimaryKey = PKey;
            //添加数据
            data.Rows.Add(1000, "User", "DHJDJGFSKFNKSGHKJEUFGHBJS");
            data.Rows.Add(1001, "User", "DHJDJGFSKFNKSGHKJEUFGHBJS");
            data.Rows.Add(1002, "User", "DHJDJGFSKFNKSGHKJEUFGHBJS");
            data.Rows.Add(1003, "User", "DHJDJGFSKFNKSGHKJEUFGHBJS");
            data.Rows.Add(1004, "User", "DHJDJGFSKFNKSGHKJEUFGHBJS");
            data.Rows.Add(1005, "User", "DHJDJGFSKFNKSGHKJEUFGHBJS");
            data.Rows.Add(1006, "User", "DHJDJGFSKFNKSGHKJEUFGHBJS");
            data.Rows.Add(1007, "User", "DHJDJGFSKFNKSGHKJEUFGHBJS");
            //输出数据
            Console.WriteLine("DataTable数据：");
            Console.WriteLine("\t ID： \t Name： \t Code：");
            foreach (DataRow dr in data.Rows)
            {
                Console.WriteLine("\t {0} \t {1} \t {2} ",dr["ID"],dr["Name"],dr["Code"]);
            }
            Console.WriteLine("数据输出完毕！");
        }
    }
}
