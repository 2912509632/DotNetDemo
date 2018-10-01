using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.as与is
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object(); //声明object类型对象
            bool res = obj is Test; //测试对象是否为Test类型，是返回true否返回false
            if (res)
            {
                Console.WriteLine("obj为Test类型对象");
            }
            else
            {
                Console.WriteLine("obj不是Test类型对象");
            }
        }
    }


    //类
    class Test
    { 
    }
}
