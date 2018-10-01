using System;
//导入线程操作命名空间
using System.Threading;

namespace _1_Thread类
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            //设置当前线程名称
            th.Name = "Main";
            Console.WriteLine("th线程的名称为：{0}",th.Name);
        }
    }
}
