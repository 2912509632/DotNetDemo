using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace 增删改查
{
    class B_根据条件排序和查询
    {
        static void Main(string[] args)
        {
            List<Users> query=GetListByOrder<int>(s=>!s.UName.Equals("Testing"),o=>o.UNum);
            Console.WriteLine("\t 编号 \t 账号 \t 密码");
            foreach (Users u in query)
                Console.WriteLine("\t {0} \t {1} \t {2}",u.UNum,u.UName,u.UPass);
        }

        /// <summary>
        /// 返回根据Lambda表达式排序后的用户表
        /// </summary>
        /// <typeparam name="TKey">排序字段类型</typeparam>
        /// <param name="where">数据查询条件</param>
        /// <param name="lambda">数据排序条件</param>
        /// <returns></returns>
        private static List<Users> GetListByOrder<TKey>(Expression<Func<Users, bool>> where,
                                                 Expression<Func<Users, TKey>> lambda)
        {
            using (EFDemoEntities db = new EFDemoEntities())
            {
                return db.Users.Where(where).OrderBy(lambda).ToList();
            }
        }

    }
}
