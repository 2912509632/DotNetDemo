using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace 枚举文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取应用程序目录
            string app = Directory.GetCurrentDirectory();
            //获取目录列表
            IEnumerable<string> dirs = Directory.EnumerateDirectories(app, "*", SearchOption.AllDirectories);
            Console.WriteLine("当前路径下所有目录：");
            foreach (string str in dirs)
            {
                Console.WriteLine(str);
            }
            IEnumerable<string> files = Directory.EnumerateFiles(app, "*", SearchOption.AllDirectories);
            Console.WriteLine("当前路径下所有文件：");
            foreach (string str in files)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("内容检索完毕！");
        }
    }
}
