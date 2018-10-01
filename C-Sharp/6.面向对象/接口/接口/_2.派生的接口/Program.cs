using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.派生的接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化实现了接口的类
            Person p = new Person();
            p.Name = "李四";
            p.IsMan(true);
            p.Hello();
            p.Work();

            //将接口的引用类型指向实现类
            IDemoTest idt = p;

            //将接口强制转换为Person类
            Person p1 = (Person)idt;
            p1.Hello();
            p1.Work();
        }
    }
}
