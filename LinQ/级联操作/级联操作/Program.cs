using System;
using System.Linq;

namespace 级联操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化数据
            StuName[] names = new StuName[] {
                new StuName() {StrName="张三" },
                new StuName() {StrName="李四" },
                new StuName() {StrName="王五" },
                new StuName() {StrName="钱六" }
            };
            StuID[] ids = new StuID[] {
                new StuID() { StrID="10000"},
                new StuID() { StrID="10001"},
                new StuID() { StrID="10002"},
                new StuID() { StrID="10003"}
            };

            //级联查询
            var query = names.Select(name => name.StrName).Concat(ids.Select(id=>id.StrID));
            
            //展示数据
            foreach (var i in query)
            {
                Console.WriteLine(i.ToString());
            }

        }

    }

    public class StuName
    {
        public string StrName { get; set; }
    }

    public class StuID
    {
        public string StrID { get; set; }
    }
}
