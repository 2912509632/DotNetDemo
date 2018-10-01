using System;
using System.Linq;

namespace 排序运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化数据
            int[] nums = new int[] { 1,3,5,-3,-5,7,8,9};

            //排序数据
            var query = from num in nums
                        orderby num 
                        select num;
            //展示数据
            foreach (int num in query)
                Console.WriteLine(num);
        }
    }
}
