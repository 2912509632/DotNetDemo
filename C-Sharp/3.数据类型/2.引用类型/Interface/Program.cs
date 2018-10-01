using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Interface
{

    /// <summary>
    /// 定义接口
    /// </summary>
    interface TestInterface
    {
        void How();
    }

    /// <summary>
    /// 实现接口
    /// </summary>
    class Program:TestInterface  //接口
    {
        void TestInterface.How()
        {
            Console.WriteLine("我实现了接口");
        }

        static void Main(string[] args)
        {
            //创建实现接口的类的对象
            TestInterface ti = new Program();
            ti.How();
        }
    }
}
