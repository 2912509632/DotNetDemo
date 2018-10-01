using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Infrastructure;

namespace 增删改查
{
    class A_简单查询和延时加载
    {
        static void Main(string[] args)
        {
            using (EFDemoEntities db = new EFDemoEntities())
            {
                DbQuery<Users> query = db.Users.Where(u => u.UName == "admin") as DbQuery<Users>;
                Users admin = query.FirstOrDefault();
                Console.WriteLine("\t 编号 \t 账户 \t 密码");
                Console.WriteLine("\t {0} \t {1} \t {2}", admin.UNum, admin.UName, admin.UPass);
            }
        }
    }
}
