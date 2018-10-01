using System;
using System.Collections.Generic;
using System.Linq;

namespace Set操作
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data1 = new int[] { 1, 2, 4, 5, 7, 34, 87, 7 };
            int[] data2 = new int[] {1,2,3,4,5,};

            //除去data1中data2里存在的数据
            IEnumerable<int> res = data1.Except(data2);

            //展示数据
            foreach (int i in res)
                Console.WriteLine(i);
        }
    }
}
