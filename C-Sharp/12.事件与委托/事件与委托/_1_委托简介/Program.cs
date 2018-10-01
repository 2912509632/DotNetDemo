using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_委托简介
{
    //声明委托
    public delegate string DelTest();

    class Program
    {
        //输出方法
        static string Write1()
        {
            return "我是输出方法1";
        }

        static string Write2()
        {
            return "我是输出方法2";
        }

        static string Write3()
        {
            return "我是输出方法3";
        }


        //主方法
        static void Main(string[] args)
        {
            //实例化委托
            DelTest del1 = new DelTest(Write1);
            DelTest del2 = new DelTest(Write2);
            DelTest del3 = new DelTest(Write3);

            //输出
            Console.WriteLine(del1());
            Console.WriteLine(del2());
            Console.WriteLine(del3());
        }
    }


}
