using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.函数重载
{

    class Test
    {
        //参考方法
        public void Show()
        {
            Console.WriteLine("我是一个方法");
        }

        //参数个数的重载
        public void Show(string s)
        {
            Console.WriteLine(s);
        }

        //参数类型不同的重载
        public void Show(int a)
        {
            Console.WriteLine(a.ToString());
        }

        //参数个数不同的重载
        public double Show(string s, int a)
        {
            return int.Parse(s)+a;
        }

        //仅返回值类型不同的无法重载
        //public int Show()
        //{
        //    Console.WriteLine("我无法重载！编译不通过！");
        //}

    }


    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Show();
            t.Show("123");
            Console.WriteLine(t.Show("123",1));
        }
    }
}

//输出：
//我是一个方法
//123
//124
//请按任意键继续. . .