using System;
using System.Text;
using System.IO;

namespace _1_使用文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取文件路径
            string path = Directory.GetCurrentDirectory() + "\\test.txt";

            //创建FileStream实例
            
            FileStream file = new FileStream(path,//文件路径
                                           FileMode.Open, //打开已存在文件
                                           FileAccess.ReadWrite, //可读写文件
                                           FileShare.Read //其他文件流拥有只读权限
                                           );

           
            //获取流信息
            Console.WriteLine("CanRead:"+file.CanRead);
            Console.WriteLine("CanWrite:" + file.CanWrite);
            Console.WriteLine("CanSeek:" + file.CanSeek);
            Console.WriteLine("CanTimeoute:" + file.CanTimeout);
            Console.WriteLine("光标当前的位置："+file.Position);
            //如果支持超时则设置流超时限制(毫秒)
            if (file.CanTimeout)
            {
                file.ReadTimeout = 1000;
                file.WriteTimeout = 1000;
            }
            else
            {
                Console.WriteLine("当前文件流不支持超时限制！");
            }

            //分析文件编码
            Console.WriteLine("文件编码为："+GetEncoding(file).ToString());
        }


        /// <summary>
        /// 分析文件编码方法
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Encoding GetEncoding(Stream stream)
        {
            if (!stream.CanSeek)
            {
                throw new Exception("该流不支持查找功能！");
            }
            Encoding encoding = Encoding.ASCII;

            byte[] temp=new byte[5]; //缓冲区
            stream.Read(temp, 0, 5); //读取头部5个字节到缓冲区

            //utf-8
            if (temp[0] == 0xef && temp[1] == 0xbb && temp[2] == 0xbf)
            {
                encoding = Encoding.UTF8;
                stream.Seek(3, SeekOrigin.Begin);
            }

            //utf-32
            if (temp[0] == 0xff && temp[1] == 0xfe && temp[2] == 0&&temp[3]==0)
            {
                encoding = Encoding.UTF32;
                stream.Seek(4, SeekOrigin.Begin);
            }

            //utf-16 / Unicode
            if (temp[0] == 0xff && temp[1] == 0xfe)
            {
                encoding = Encoding.Unicode;
                stream.Seek(2, SeekOrigin.Begin);
            }

            //BigEndUnicode
            if (temp[0] == 0xfe && temp[1] == 0xff )
            {
                encoding = Encoding.BigEndianUnicode;
                stream.Seek(2, SeekOrigin.Begin);
            }

            return encoding;
        }

    }
}
