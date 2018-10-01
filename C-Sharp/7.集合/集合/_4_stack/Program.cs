using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_stack
{
    class Program
    {
        /// <summary>
        /// 堆栈
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //后进先出的栈
            Stack s = new Stack();
            //压栈
            s.Push("A");
            s.Push(1);
            s.Push("B");
            s.Push(2);
            s.Push("C");
            s.Push(3);
            s.Push("3");
            s.Push('D');
            //输出
            foreach (var v in s)
            {
                Console.WriteLine(v);
            }
            //判断存在
            if (s.Contains("A"))
            {
                Console.WriteLine("存在！");
            }
            else
            {
                Console.WriteLine("不存在！");
            }
            //移除顶部对象
            Console.WriteLine("现在在顶部的是:"+s.Peek());
            //移除
            s.Pop();
            Console.WriteLine("移除后顶部的是:" + s.Peek());
        }
    }
}
