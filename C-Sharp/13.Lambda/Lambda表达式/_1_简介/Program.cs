using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_简介
{
    class Program
    {
        delegate int Del(int x);

        static void Main(string[] args)
        {
            Del test = x => x * x;
            Console.WriteLine(test(5));

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            Console.WriteLine(oddNumbers);
        }

    }
}
