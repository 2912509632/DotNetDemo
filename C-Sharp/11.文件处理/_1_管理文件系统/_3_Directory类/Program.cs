using System;
using System.Text;
using System.IO;

namespace _3_Directory类
{
    class Program
    {
        static void Main(string[] args)
        {
            string app = Directory.GetCurrentDirectory();
            Console.WriteLine("应用程序当前目录："+app);
            //检查是否存在目录test
            string test = app + "\\test";
            if (Directory.Exists(test))
            {
                Console.WriteLine("存在test目录！");
                //删除test目录
                Directory.Delete(test);
                Console.WriteLine("test目录已被删除！");
            }
            else
            {
                Console.WriteLine("不存在test目录！");
                //创建test目录
                Directory.CreateDirectory(test);
                Console.WriteLine("test目录创建成功！");
                var lists=Directory.EnumerateDirectories(app);
                Console.WriteLine("目录列表：");
                foreach (var v in lists)
                {
                    Console.WriteLine(v.ToString());
                }
            }
        }
    }
}
