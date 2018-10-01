using System;
using System.Text;
using System.IO;

namespace _5_FileInfo使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //文件路径
            string test=Directory.GetCurrentDirectory()+"\\test.txt";
            //读取信息
            FileInfo info = new FileInfo(test);
            Console.WriteLine("文件信息如下：");
            Console.WriteLine("文件名："+info.Name);
            Console.WriteLine("是否只读："+info.IsReadOnly);
            Console.WriteLine("文件类型"+info.Extension);
            Console.WriteLine("文件创建时间："+info.CreationTime);
            Console.WriteLine("文件属性："+info.Attributes);
            Console.WriteLine("更改后的文件信息：");
            info.CreationTime = DateTime.Now;
            info.IsReadOnly = true;
            Console.WriteLine("是否只读：" + info.IsReadOnly);
            Console.WriteLine("文件创建时间：" + info.CreationTime);
        }
    }
}
