using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.类
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.a = 5;
            test.b = 6;
            Console.WriteLine(test.Sum());
        }
    }

    class Test
    {
        //类成员
        public int a; 
        
        public int b;
        //类方法
        public int Sum()
        {
            return a + b;
        }
    }
}
