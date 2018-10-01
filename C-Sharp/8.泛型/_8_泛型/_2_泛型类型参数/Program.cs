using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_泛型类型参数
{
    class Program
    {
        static void Main(string[] args)
        {
            Test<float> f = new Test<float>();
            Test<object> obj = new Test<object>();
            Test<double> d = new Test<double>();

        }
    }

    public class Test<T>
    {
        public Test()
        {
            Console.WriteLine();
        }
    }
}
