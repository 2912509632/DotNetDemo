using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_泛型方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Show<int>(123);

            Console.WriteLine("------华丽的分割线------");

            Show<string>("Hello Word！");
        }


        public static void Show<T>(T t)
        {
            Console.WriteLine("我是泛型方法show<T>(T t)");
            Console.WriteLine("当前对象的数据类型是："+t.GetType());
            Console.WriteLine("当前数据是："+t);
            Console.WriteLine("使用泛型方法可以减少很多重复的工作！");
        }
    }
}
