using System;

namespace ModeFirst开发方式
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DemoContainer db = new DemoContainer())
            {
                for (int i = 0; i < 50; i++)
                {
                    Info info = new Info()
                    {
                        ID = i,
                        Name = "Name" + i,
                        Pass = "Pass" + i
                    };
                    db.InfoSet.Add(info);
                }
                db.SaveChanges();
                Console.WriteLine("数据添加成功！");


                Console.WriteLine("\t ID \t Name \t Pass");
                foreach (Info i in db.InfoSet)
                    Console.WriteLine("\t {1} \t {1} \t {2}",i.ID,i.Name,i.Pass);
            }
        }
    }
}
