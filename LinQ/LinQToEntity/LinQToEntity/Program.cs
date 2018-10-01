using System;
using System.Linq;

namespace LinQToEntity
{
    class Program
    {
        /// <summary>
        /// LinQ To Entity
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //数据库实体
            using (LINQEntities db = new LINQEntities())
            {
                //查询Test表数据
                var query = from s in db.Test
                            select s;

                //展示数据
                Console.WriteLine("\t ID \t Name \t Sex \t Time");
                foreach (Test t in query)
                    Console.WriteLine("\t {0} \t {1} \t {2} \t {3}",t.ID,t.Name,t.Sex,t.Time);

                //添加一行数据
                Test add = new Test()
                {
                    Name = "张三",
                    Sex = "男",
                    Time = DateTime.Now
                };
                db.Test.Add(add);
                //保存修改
                db.SaveChanges();
                Console.WriteLine("数据添加成功！");

                //修改ID为1005的数据
                Test update = db.Test.First(x=>x.ID==1005);
                update.Name = "修改了";
                update.Sex = "女";
                update.Time = DateTime.Now;
                //保存修改
                db.SaveChanges();
                Console.WriteLine("数据修改成功！");


                //删除最新一条的数据
                //删除数据
                db.Test.Remove(db.Test.FirstOrDefault());
                //保存修改
                db.SaveChanges();
                Console.WriteLine("数据删除成功！");


                //展示数据
                Console.WriteLine("\t ID \t Name \t Sex \t Time");
                foreach (Test t in query)
                    Console.WriteLine("\t {0} \t {1} \t {2} \t {3}", t.ID, t.Name, t.Sex, t.Time);

            }
        }
    }
}
