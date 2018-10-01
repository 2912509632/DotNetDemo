using System;
using System.Linq;

namespace CodeFirst示例
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DemoContext db = new DemoContext())
            {
                bool res = db.Database.CreateIfNotExists();
                Console.WriteLine("数据库创建：" + (res ? "成功" : "失败"));
                Info i = new Info() {
                    InfoID=1,
                    Name="Name",
                    Pass="Pass"
                };
                db.Info.Add(i);
                db.SaveChanges();
                Console.WriteLine(db.Info.FirstOrDefault().Name);
            }
        }
    }
}
