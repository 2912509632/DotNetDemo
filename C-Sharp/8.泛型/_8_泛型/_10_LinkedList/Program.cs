using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化链表泛型类
            LinkedList<int> link = new LinkedList<int>();
            link.AddFirst(1); //向第一个节点添加元素
            link.AddLast(2); //向最后一个节点添加元素
            link.AddLast(3);
            link.AddLast(4);
            link.AddLast(6);
            
            //展示数据
            Console.WriteLine("添加的元素如下:");
            foreach (int v in link)
                Console.WriteLine("值:"+v);
            
            //插入数据到2与3之间
            LinkedListNode<int> node = new LinkedListNode<int>(555);
            link.AddAfter(link.Find(2), node);//也可以直接输入值

            //展示数据
            Console.WriteLine("链表的元素如下:");
            foreach (int v in link)
                Console.WriteLine("值:" + v);
            
            //查找链表节点 555 并删除
            if (link.Contains(555))
            {
                link.Remove(555); //删除555的节点
            }

            //展示数据
            Console.WriteLine("删除后链表的元素如下:");
            foreach (int v in link)
                Console.WriteLine("值:" + v);
            

        }
    }
}
