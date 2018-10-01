using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;

namespace 简单查询和延时加载
{
    class Program
    {
        /// <summary>
        /// 简单查询
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using (EFDemoEntities db = new EFDemoEntities())
            {
                DbQuery<Users> query = db.Users.Where(u => u.UName == "admin") as DbQuery<Users>;
                Users admin = query.FirstOrDefault();
                Console.WriteLine("\t 编号 \t 账户 \t 密码");
                Console.WriteLine("\t {0} \t {1} \t {2}",admin.UNum,admin.UName,admin.UPass );
            }
        }
    }
}
