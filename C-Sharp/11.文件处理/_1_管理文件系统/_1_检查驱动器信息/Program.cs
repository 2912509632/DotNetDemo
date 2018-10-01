using System;
using System.IO;

namespace _1_检查驱动器信息
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取驱动器新
            var drives = DriveInfo.GetDrives();

            try
            {
                //输出信息
                foreach (var v in drives)
                {
                    Console.WriteLine("盘符：" + v.Name);
                    Console.WriteLine("格式：" + v.DriveFormat);
                    Console.WriteLine("类型：" + v.DriveType);
                    Console.WriteLine("剩余：" + v.AvailableFreeSpace + "KB");
                }
            }
            catch
            {
                Console.WriteLine("操作发生异常！");
            }

        }
    }
}
