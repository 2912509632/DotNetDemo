using System;

namespace 增删改查
{
    class F_批处理
    {
        static void Main(string[] args)
        {
            using (EFDemoEntities db = new EFDemoEntities())
            {
                //循环添加50个账户
                for(int i=0; i<50;i++)
                {
                    Users u = new Users()
                    {
                        UName = "Test" + i,
                        UPass="TestPass"+i,
                    };
                    db.Users.Add(u);
                }
                //保存更改
                //批处理 多次添加  一次实现
                db.SaveChanges();
                Console.WriteLine("数据添加成功！");
                
            }
        }



    }
}
