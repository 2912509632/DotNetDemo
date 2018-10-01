using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明object类型
            object obj;
            obj = 10;
            Console.WriteLine("此时obj数据类型为："+obj.GetType());
            Console.WriteLine("此时obj数据值为：" + obj);

            //装箱操作
            int a = 10;
            object obj1 = a;
            Console.WriteLine("obj1的值为："+obj1);

            //拆箱操作
            int b = (int)obj1; //显式拆箱
            Console.WriteLine("b的值为："+b);
        }
    }
}
