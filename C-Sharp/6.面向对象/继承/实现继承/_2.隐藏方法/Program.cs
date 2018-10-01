using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.隐藏方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Show();
        }
    }

    class Partent
    {
        public void Show()
        {
            Console.WriteLine("我是基类！");
        }
    }

    class Test : Partent
    {
        new public void Show() //派生类中不使用new关键字将造成编译警告
        {
            Console.WriteLine("我是派生类！");
        }
    }
}
