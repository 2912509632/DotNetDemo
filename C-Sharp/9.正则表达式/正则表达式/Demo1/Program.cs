using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //普通邮箱正则
            Regex mail = new Regex(@"\w+@\w+\.\w+");
            //日期正则
            Regex date = new Regex(@"\d{4}-([0-2]?)\d-([0-3]?)\d");

            while (true)
            {
                Console.WriteLine("请输入一个邮箱：");
                string m = Console.ReadLine();
                Console.WriteLine(mail.IsMatch(m) ? "有效" : "无效");
                Console.WriteLine();
                Console.WriteLine("请输入一个日期：");
                string d = Console.ReadLine();
                Console.WriteLine(date.IsMatch(d) ? "有效" : "无效");
                Console.WriteLine();
            }

        }
    }
}

