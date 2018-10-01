using System;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace _1_使用压缩流
{
    class Program
    {
        ///// <summary>
        ///// 压缩流
        ///// </summary>
        ///// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    string app = Directory.GetCurrentDirectory();

        //    FileStream input = File.Open(app + "\\Test.txt", FileMode.Open); //源文件流
        //    FileStream output = File.Open(app + "\\Test", FileMode.Create); //压缩后的文件流

        //    using (DeflateStream stream = new DeflateStream(output, CompressionMode.Compress))
        //    {
        //        input.CopyTo(stream);//将压缩流传递给output
        //    }
        //    Console.WriteLine("压缩完毕！");

        //}

        /// <summary>
        /// 解压缩
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string app = Directory.GetCurrentDirectory();

            FileStream input = File.Open(app + "\\Test", FileMode.Open);//压缩文件位置
            using (MemoryStream mStream = new MemoryStream()) //创建压缩缓存
            using (DeflateStream dStream = new DeflateStream(input, CompressionMode.Decompress))
            {
                dStream.CopyTo(mStream);//解压缩
                //读取解压缩内容
                mStream.Seek(0, SeekOrigin.Begin);
                using (StreamReader reader = new StreamReader(mStream, Encoding.UTF8, true, 4096))
                {
                    Console.WriteLine("读取内容如下：");
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
        }
    }
}
