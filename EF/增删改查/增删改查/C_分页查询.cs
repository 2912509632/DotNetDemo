using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;


namespace 增删改查
{
    class C_分页查询
    {
        static void Main(string[] args)
        {
            List<Users> query = GetPage<string>(1, 2,w  => w.UNum > 0, o => o.UName);
            Console.WriteLine("\t 编号 \t 账号 \t 密码");
            foreach (Users u in query)
                Console.WriteLine("\t {0} \t {1} \t {2}", u.UNum, u.UName, u.UPass);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="Tkey">排序列的数据类型</typeparam>
        /// <param name="pageIndex">当前页索引</param>
        /// <param name="pageSize">每页显示的数量</param>
        /// <param name="where">查询范围表达式</param>
        /// <param name="order">排序表达式</param>
        /// <returns></returns>
        private static List<Users> GetPage<Tkey>(int pageIndex,int pageSize,
                                             Expression<Func<Users,bool>> where,
                                             Expression<Func<Users,Tkey>> order)
        {
            using (EFDemoEntities db = new EFDemoEntities())
            {
                return db.Users.Where(where).OrderBy(order).Skip(pageIndex * pageSize).Take(pageSize).ToList();
            }
        }

      
    }
}
