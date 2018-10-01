using System;
using System.Text;
using System.IO;

namespace _4_复制文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //复制output.txt的文件流到input.txt

            //文件目录
            string app = Directory.GetCurrentDirectory();

            //读取文件流
            FileStream output = new FileStream(app + "\\output.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            //写入文件流
            FileStream input = new FileStream(app + "\\input.txt", FileMode.Create, FileAccess.Write, FileShare.None);

            const int bufferSize = 256;
            byte[] buffer = new byte[bufferSize];//缓冲区
            bool IsEnd = false;

            do
            {
                int size = output.Read(buffer, 0, bufferSize);
                if (size == 0) IsEnd = true;
                if (size < bufferSize)
                {
                    Array.Clear(buffer, size, bufferSize - size);
                }
                //将读取到缓冲区的数据流写入输入文件流
                input.Write(buffer, 0, buffer.Length);
            }
            while (!IsEnd);


            //**************
            //方式二
            //**************
            //output.CopyTo(input);

            input.Dispose();
            output.Dispose();

            Console.WriteLine("数据流复制完毕！");
        }
    }
}
