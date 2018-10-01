using System;
using System.IO;

namespace _2_Path使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //文件路径
            string src = @"E:\Word\Wiki.txt";
            Console.WriteLine("文件路径："+Path.GetFullPath(src));
            Console.WriteLine("文件名："+Path.GetFileName(src));
            Console.WriteLine("文件拓展名："+Path.GetExtension(src));
            //更改拓展名
            string newStr=Path.ChangeExtension(src, ".ini");
            Console.WriteLine("新的文件拓展名：" + Path.GetExtension(newStr));
        }
    }
}
