using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            //给参数赋值
            a = 5;
            b = 7;
            //改变参数
            Change(out a,out b);
            Console.WriteLine("a={0}\nb={1}",a,b);
        }

        static void Change(out int a,out int b)
        {
            //Console.WriteLine("赋值前：a{0}，b{1}",a,b); //编译不通过 使用未赋值变量
            a = 10;
            b = 20;
        }
    }
}
