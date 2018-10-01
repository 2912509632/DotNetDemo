using System;
using System.Text;
using System.IO;

namespace _2_StreamWriter类
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = File.Open(Directory.GetCurrentDirectory() + "\\Test.txt", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(stream))
            {
                //写入文件编码格式
                byte[] preamble = Encoding.UTF8.GetPreamble();
                stream.Write(preamble,0,preamble.Length);
                //写入数据
                for (int i = 1; i < 10; i++)
                {
                    writer.Write("我是测试信息" + i+"\n");
                }
            }
        }
    }
}
