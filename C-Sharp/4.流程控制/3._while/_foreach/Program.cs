
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[] { "A","B","C","D","E"};

            foreach (var v in str)
            {
                Console.WriteLine("当前字符串："+v);
            }

            Console.WriteLine("程序执行完毕！");
        }
    }
}
