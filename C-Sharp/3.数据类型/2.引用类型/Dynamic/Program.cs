using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dyn = 5;
            object obj = 5;
            Console.WriteLine("dyn的数据类型是："+dyn.GetType());
            Console.WriteLine("obj的数据类型是：" + obj.GetType());
            dyn = dyn + 3; //编译不报错
            obj = obj + 3; //无法通过编译
        }
    }
}
