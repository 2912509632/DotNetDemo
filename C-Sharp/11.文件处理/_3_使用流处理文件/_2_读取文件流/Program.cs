using System;
using System.Text;
using System.IO;

namespace _2_读取文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取文件路径(文本格式为ASCII)
            string path = Directory.GetCurrentDirectory() + "\\test.txt";

            //创建FileStream实例

            FileStream file = new FileStream(path,//文件路径
                                           FileMode.Open, //打开已存在文件
                                           FileAccess.Read, //只读写文件
                                           FileShare.Read //其他文件流拥有只读权限
                                           );

            const int bufferSize = 256; //缓冲区大小常量
            byte[] buffer=new byte[bufferSize]; //缓冲区
            bool IsEnd=false; //是否读取结束
            StringBuilder str=new StringBuilder(); //存储字符串

            file.Seek(3, SeekOrigin.Begin);//设置流的起始位置

            //读取文件流
            do
            {
                int size = file.Read(buffer, 0, bufferSize);//读取指定数量字节到缓冲区，完毕则返回0
                if (size == 0) IsEnd = true;
                //读取数量小于缓冲区大小，清理缓冲区
                if (size < bufferSize)
                {
                    Array.Clear(buffer, size, bufferSize - size);
                }
                //将指定编码数据转为字符串
                str.Append(Encoding.UTF8.GetString(buffer));
            }
            while (!IsEnd);

            //销毁数据流
            file.Dispose();

            //输出字符串
            Console.WriteLine(str);

        }
    }
}
