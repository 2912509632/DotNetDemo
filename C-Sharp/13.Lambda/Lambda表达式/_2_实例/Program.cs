using System;
using System.Linq;

namespace _2_实例
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //数组
            int[] Nums = { 4, 8, 9, 12, 4, 7, 45, 78, 3, 27, 19, 22 };

            //使用数组的Count方法 返回满足条件的数字
            int count = Nums.Count(x => x % 2 == 1);

            Console.WriteLine("符合要求的数字有{0}个", count);
        }
    }
}