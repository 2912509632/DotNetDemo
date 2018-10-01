using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @delegate
{

    /// <summary>
    /// 声明委托
    /// </summary>
    delegate double TestDelegate(double num);

    class Program
    {
        static double Sum(double num)
        {
            return num + num;
        }

        static void Main(string[] args)
        {
            TestDelegate test = Sum;//实例化委托
            Console.WriteLine("4+4="+test(4));

        }
    }
}
