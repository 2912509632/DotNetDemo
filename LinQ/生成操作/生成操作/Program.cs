using System;
using System.Collections.Generic;
using System.Linq;

namespace 生成操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //生成数据
            IEnumerable<string> data = Enumerable.Repeat("Hello World！", 5);

            //输出数据
            foreach (string s in data)
                Console.WriteLine(s);
        }
    }
}
