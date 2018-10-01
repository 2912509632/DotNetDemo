using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=11;
            do
            {
                Console.WriteLine("当前数值："+i);
                i--;
            }
            while (i > 0 & i < 11); //注意所限定的条件，第一次是不满足的
            Console.WriteLine("程序执行完毕！");
        }
    }
}
