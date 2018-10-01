using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace _5_Queue
{
    class Program
    {
        /// <summary>
        /// 先进先出的队列
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //创建队列对象
            Queue q = new Queue();
            //向队列尾部添加数据
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);

            Console.WriteLine("循环显示");
            foreach (var v in q)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("判断是否存在 ‘1’ ");
            if (q.Contains(1))
            {
                Console.WriteLine("存在！");
            }
            else
            {
                Console.WriteLine("不存在！");
            }

            //移除末尾变量
            Console.WriteLine("当前移除的是{0}",q.Dequeue());
            Console.WriteLine("当前移除的是{0}", q.Dequeue());
        }
    }
}
