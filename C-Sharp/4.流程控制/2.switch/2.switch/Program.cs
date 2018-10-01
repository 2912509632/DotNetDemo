using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.@switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入星期的阿拉伯数字：");
            byte day = byte.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("星期一");
                    break;
                case 2:
                    Console.WriteLine("星期二");
                    break;
                case 3:
                    Console.WriteLine("星期三");
                    break;
                case 4:
                    Console.WriteLine("星期四");
                    break;
                case 5:
                    Console.WriteLine("星期五");
                    break;
                case 6:
                    Console.WriteLine("星期六");
                    break;
                case 7:
                    Console.WriteLine("星期日");
                    break;
                default:
                    Console.WriteLine("不存在");
                    break;
            }

            Console.WriteLine("语句执行完毕！");
        }
    }
}
