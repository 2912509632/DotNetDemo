using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _3_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add('A', "123");
            sl.Add('B', "234");
            sl.Add('C', "345");
            sl.Add('D', "456");
            sl.Add('E', "567");
            sl.Add('F', "678");
            sl.Add('G', "789");
            sl.Add('H', "890");

            if (sl.Contains('I'))
            {
                Console.WriteLine("键值I已存在！");
            }
            else
            {
                sl.Add('I', "901");
            }

            //获取键
            ICollection keys = sl.Keys;
            //通过键访问值
            foreach (char c in keys)
            {
                Console.WriteLine(sl[c]);
            }
        }
    }
}
