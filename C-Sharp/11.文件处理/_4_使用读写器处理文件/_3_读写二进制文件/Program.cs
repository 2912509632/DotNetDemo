using System;
using System.Text;
using System.IO;

namespace _3_读写二进制文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //文件地址
            string test = Directory.GetCurrentDirectory() + "\\Test.bin";

            ////写入二进制
            //FileStream inputStream = File.Open(test, FileMode.Create);
            //using (BinaryWriter writer = new BinaryWriter(inputStream))
            //{
            //    writer.Write("我是测试数据\n");
            //    writer.Write("我是二进制数据\n");
            //    writer.Write("我是最后一句");
            //}
            //Console.WriteLine("数据写入完毕！");

            //读取写入的字符串的二进制数据
            FileStream outputStream = File.Open(test, FileMode.Open);
            using (BinaryReader reader = new BinaryReader(outputStream))
            {
                Console.WriteLine("读取数据如下：");
                //读取必须采用和写入同样数据类型的方法
                Console.WriteLine(reader.ReadString());
                Console.WriteLine(reader.ReadString());
                Console.WriteLine(reader.ReadString());
            }
        }
    }
}
