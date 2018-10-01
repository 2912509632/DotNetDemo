using System;
using System.Text;
using System.IO;

namespace _3_写入文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Directory.GetCurrentDirectory()+"\\test.txt";

            //创建文件流
            FileStream stream = new FileStream(test, FileMode.Create, FileAccess.Write, FileShare.Read);

            //写入UTF8编码字节序列
            byte[] preamble = Encoding.UTF8.GetPreamble();
            stream.Write(preamble, 0, preamble.Length);

            //写入信息
            //转码字符串为字节
            string str = "我是写入的测试信息！";
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            //写入字节码
            stream.Write(buffer, 0, buffer.Length);

            //销毁文件流对象
            stream.Dispose();

            Console.WriteLine("内容写入成功！");
        }
    }
}
