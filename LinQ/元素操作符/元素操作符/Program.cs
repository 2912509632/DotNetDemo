using System;
using System.Linq;

namespace 元素操作符
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据源
            int[] data = new int[] {1,2,3,4,5,6,7,8,9 };

            //返回大于5的第一个元素
            var query = data.First(x=>x>5);

            //输出
            Console.WriteLine(query);
        }
    }
}
