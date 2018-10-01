using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用求和函数
            Console.WriteLine(Sum(1,2));
        }


        /// <summary>
        /// 求和函数
        /// </summary>
        /// <param name="a">操作数a</param>
        /// <param name="b">操作数b</param>
        /// <returns>返回a与b的和</returns>
        static int Sum(int a,int b)        {
            int sum;
            sum = a + b;
            return sum;
        }
    }
}
