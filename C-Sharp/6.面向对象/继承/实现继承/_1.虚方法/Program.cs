using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1 t1 = new Test1();
            t1.Show();
            Test2 t2 = new Test2();
            t2.Show();
        }
    }


    /// <summary>
    /// 测试基类
    /// </summary>
    class Partent
    {
        public virtual void Show()
        {
            Console.WriteLine("我是基类的虚方法！");
        }
    }

    /// <summary>
    /// 不重写虚方法
    /// </summary>
    class Test1 : Partent
    {
 
    }

    /// <summary>
    /// 重写虚方法
    /// </summary>
    class Test2 : Partent
    {
        public override void Show()
        {
            Console.WriteLine("我重写了基类的Show方法");
        }
    }
}

