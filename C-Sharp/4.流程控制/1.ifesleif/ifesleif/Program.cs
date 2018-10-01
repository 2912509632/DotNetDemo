using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ifesleif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入当前时间：");
            byte time = byte.Parse(Console.ReadLine());

            if (time >= 6 && time < 12)
            {
                Console.WriteLine("现在是上午！");
            }
            else if (time >= 12 && time < 18)
            {
                Console.WriteLine("现在是下午！");
            }
            else if (time >= 18 && time < 6)
            {
                Console.WriteLine("现在是晚上！");
            }
            else
            {
                Console.WriteLine("您输入的时间有误！");
            }
        }
    }
}
