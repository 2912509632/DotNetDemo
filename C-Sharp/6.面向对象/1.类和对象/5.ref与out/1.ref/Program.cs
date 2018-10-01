using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.@ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("改变前：a:{0},b:{1}",a,b);
            Change(ref a,ref b);
            Console.WriteLine("改变后：a:{0},b:{1}", a, b);
        }

        static void Change(ref int a, ref int b)
        {
            a = a + 3;
            b = b + 7;
        }
    }
}
