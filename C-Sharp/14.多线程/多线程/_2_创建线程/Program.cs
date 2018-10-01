using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _2_创建线程
{
    class Program
    {
        static long num = 0;
        //新线程执行的方法
        static void ChangeNum(object i)
        {
            while (true)
            {
                num += int.Parse(i.ToString());
                Thread.Sleep(100); //线程延时100毫秒
            }
        }

        static void Main(string[] args)
        {
            //实例化委托
            ParameterizedThreadStart pts = new ParameterizedThreadStart(ChangeNum);
            //实例化Thread
            Thread th = new Thread(pts);
            //启动线程
            th.Start(2);

            //循环输出Num
            while (true)
            {
                Console.WriteLine(num);
                System.Threading.Thread.Sleep(1000); //线程延时500毫秒
            }
        }

    }
}
