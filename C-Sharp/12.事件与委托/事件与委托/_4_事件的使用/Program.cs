using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_事件的使用
{
    
    /// <summary>
    /// 发布器类
    /// </summary>
    class publisher
    {
        //声明委托
        public delegate void DelTest(string msg);
        //声明事件
        public event DelTest DelEvent;

        public void Begin(string msg)
        {
            //如果订阅列表不为空开始推送
            if (DelEvent != null)
            {
                Console.WriteLine("服务器开始推送消息！");
                DelEvent(msg);
            }
        }
    }

    /// <summary>
    /// 订阅器类
    /// </summary>
    class subscriber 
    {
        public void MakeMsg(string msg)
        {
            Console.WriteLine("客户端响应推送！");
            Console.WriteLine("字符串："+msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //实例化发布器类
            publisher pub = new publisher();
            //实例化订阅器类
            subscriber sub = new subscriber();
            //使用订阅器类MakeMsg方法，实例化订阅器委托并订阅事件DelEvent
            pub.DelEvent+=new publisher.DelTest(sub.MakeMsg);
            //开始推送
            pub.Begin("Hellow World!");

            Console.WriteLine("程序运行完毕！");

        }
    }
}
