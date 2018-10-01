using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            al.Add("1");
            al.Add(2);
            al.Add("123");
            al.Add("Bc");
            foreach (var v in al)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("------------------");
            al.Remove("1");
            al.RemoveAt(1);
            foreach (var v in al)
            {
                Console.WriteLine(v);
            }
        }
    }
}
