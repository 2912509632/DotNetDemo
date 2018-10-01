using System;
using System.Data.Entity.Infrastructure;

namespace 增删改查
{
    class D_修改数据
    {
        static void Main(string[] args)
        {
            //创建修改的对象
            Users change = new Users()
            {
                UNum =10000,
                UName="admin",
                UPass="admin"
            };

            using (EFDemoEntities db = new EFDemoEntities())
            {
                //将对象加入EF容器
                DbEntityEntry entity = db.Entry<Users>(change);

                //设置对象状态
                entity.State = System.Data.EntityState.Unchanged;
                //Modified状态  设置被修改的列
                entity.Property("UNum").IsModified = false;
                entity.Property("UName").IsModified = true;
                entity.Property("UPass").IsModified = true;
                //保存修改
                db.SaveChanges();
                Console.WriteLine("数据修改成功！");
            }


        }
    }
}
