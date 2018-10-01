using System;
using System.Text;
using System.IO;

namespace _4_File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取当前目录
            string app = Directory.GetCurrentDirectory();
            //test.txt文件路径
            string test = app + "\\test.txt";
            //验证文件
            if (File.Exists(test))
            {
                Console.WriteLine("文件存在");
            }
            else
            {
                Console.WriteLine("文件不存在");
                File.Create(test);
                Console.WriteLine("文件创建成功！");
            }
            //追加内容
            File.AppendAllText(test, "我是测试内容！",Encoding.UTF8);
            Console.WriteLine("写入内容成功！");
            //读取文件
            string[] content = File.ReadAllLines(test);
            foreach (var v in content)
            {
                Console.WriteLine(v.ToString());
            }
            //移动文件并重命名
            string newTest = app + "\\test1.txt";
            File.Move(test, newTest);
            Console.WriteLine("文件移动成功！");
        }
    }
}
