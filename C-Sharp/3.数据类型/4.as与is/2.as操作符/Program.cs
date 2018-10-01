using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.as操作符
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            var res = obj as Test;
            if (res != null)
            {
                Console.WriteLine("类型成功转换！");
            }
            else
            {
                Console.WriteLine("类型转换失败！");
            }
        }
    }

    class Test
    {
    }
}
