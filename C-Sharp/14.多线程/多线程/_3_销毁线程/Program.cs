using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _3_销毁线程
{
    class Program
    {
        static void Way()
        {
            try
            {
                Console.WriteLine("新线程已被启动...");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("引发异常：" + e.Message);
            }
            finally
            {
                Console.WriteLine("未捕获到异常！");
            }
        }

        static void Main(string[] args)
        {
            //启动新线程
            Thread th = new Thread(new ThreadStart(Way));
            th.Start();
            //休眠当前线程5S
            Console.WriteLine("主线程休眠5S");
            Thread.Sleep(5000);
            //销毁新线程
            th.Abort();
            Console.WriteLine("新线程已销毁！");
        }
    }
}
