using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_捕获异常
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 5;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("错误提示："+e.Message);
            }
            finally
            {
                Console.WriteLine("程序执行完毕！");
            }
        }
    }
}
