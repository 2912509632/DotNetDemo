using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.静态构造函数
{
    class Program
    {

        //类成员
        private static int x=0;

        Program()
        {
            x = 5;
        }

        static Program()
        {
            x = 10;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(x);
            Program p = new Program();
            Console.WriteLine(x);
        }
    }
}
