using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_匿名方法
{
    //声明委托
    public delegate string otherDel(string str);
    
    class Program
    {
        static void Main(string[] args)
        {
            //使用匿名方法实例化委托
            otherDel del = delegate(string str)
            {
                return "您传入的值是："+str;
            };
            Console.WriteLine(del("Hello World！"));
        }
    }
}
