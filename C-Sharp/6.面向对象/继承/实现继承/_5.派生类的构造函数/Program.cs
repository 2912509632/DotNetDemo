using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.派生类的构造函数
{
    //派生类的无参构造函数

    class Partent1
    {
        public Partent1()
        {
            Console.WriteLine("我是父类的构造函数！");
        }
    }

    class Test1 : Partent1
    {
        public Test1()
        {
            Console.WriteLine("我是子类的构造函数！");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test1 t = new Test1();
        }
    }
}


//输出：
//我是父类的构造函数！
//我是子类的构造函数！
//请按任意键继续. . .