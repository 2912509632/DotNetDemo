using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_泛型简介
{
    class Program
    {
        static void Main(string[] args)
        {

           
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            foreach (var v in list)
            {
                Console.WriteLine(v); 
            }

        }
    }

 
}
