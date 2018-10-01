using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _5_lock使用
{
    
    /// <summary>
    /// 账户类
    /// </summary>
    class Account
    {
        private object obj = new int();  //lock的对象  符合lock要求  具体要求见上文
        Random ran = new Random(); //随机数对象
        int balance; //账户余额

        public Account(int num)
        {
            balance = num; //构造函数为余额赋值
        }

        int Change(int x)
        {
            if (balance < 0)
            {
                throw new Exception("您已负债，账户被冻结！");
            }
            lock (obj) //使用lock确保每次只被一个线程操作
            {
                if (balance >= x)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("当前执行进程："+Thread.CurrentThread.Name);
                    Console.WriteLine("改变前余额：" + balance);
                    balance -= x;
                    Console.WriteLine("余额减去{0}后为{1}",x,balance);
                    Console.WriteLine("-------------------------------------");
                    return balance;
                }
                else
                {
                    return 0;
                }
            }
        }

        public void Run()
        {
            while (true)
            {
                //循环生成随机使用余额数
                Change(ran.Next(1, 10));
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Thread[] ths=new Thread[10]; //线程数组
            Account acc = new Account(1000); //实例化账户类
            //初始化线程数组
            for (int i = 0; i < 10; i++)
            {
                Thread th = new Thread(new ThreadStart(acc.Run));
                ths[i] = th;
                ths[i].Name = "Thread" + (i + 1).ToString();
                ths[i].Start(); //启动线程
            }
            

        }
    }

}
