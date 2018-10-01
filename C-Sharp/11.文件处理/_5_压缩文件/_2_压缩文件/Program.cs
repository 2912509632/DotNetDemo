//.Net 4.5以上
//引用DLL System.IO.Compression
//引用DLL System.IO.Compression.FileSystem.dll

using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace _2_压缩文件
{
    class Program
    {
        static void Main(string[] args)
        {
           //根目录
            string root = Directory.GetCurrentDirectory();

            //Zip文件流
            FileStream zipStream = File.Create(root + "\\Test.zip");
            using(ZipArchive archive=new ZipArchive(zipStream,ZipArchiveMode.Create))//创建ZipArchive实例
            {
                //获取指定目录下待压缩文件路径的集合
                IEnumerable<string> files = Directory.EnumerateFiles(root + "\\Test", "*", SearchOption.AllDirectories);
                //为每个文件创建ZipArchiveEntry实体
                foreach (string file in files)
                {
                    ZipArchiveEntry entry=archive.CreateEntry(Path.GetFileName(file)); //创建实体
                    using (FileStream input = File.OpenRead(file)) //读取文件
                    using(Stream output=entry.Open()) //打开Zip实体存档项
                    {
                        input.CopyTo(output); //复制文件到Zip对象
                    }
                }
            }

            Console.WriteLine("文件压缩完毕！");
        }
    }
}
