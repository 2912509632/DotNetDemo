using System;

namespace 增删改查
{
    class E_删除数据
    {
        static void Main(string[] args)
        {
            using (EFDemoEntities db = new EFDemoEntities())
            {
                //创建需要删除的对象
                Users del = new Users() { UNum = 10001 };
                //附加到EF中
                db.Users.Attach(del);
                //标记为删除
                db.Users.Remove(del);
                //提交修改
                db.SaveChanges();
                Console.WriteLine("数据删除成功！");
            }
        }
    }
}
