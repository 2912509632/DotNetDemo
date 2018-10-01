using System;
using System.Linq;

namespace 相等
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据源
            string[] data1 = new string[] { "Hello", "Hello", "Hello", "Hello","Hello"};
            string[] data2 = new string[] { "Hello", "Hello", "Hello", "Hello"};
            //比较序列
            bool res = data1.SequenceEqual(data2);
            //展示数据
            Console.WriteLine("data1与data2是否相等："+res);
        }
    }
}
