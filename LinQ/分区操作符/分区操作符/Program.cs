using System;
using System.Linq;

namespace 分区操作符
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据源
            int[] data = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

            //当前页
            int currentPage = 0;
            //每页显示数量
            int pageSize = 5;

            while (pageSize * currentPage < data.Length)
            {
                //分页操作
                var page= data.Skip(pageSize * currentPage).Take(pageSize);

                //展示数据
                Console.WriteLine("第{0}页数据：",currentPage+1);
                foreach (int i in page)
                    Console.WriteLine(i.ToString());

                //更新页码
                currentPage++;
            }
        }
    }
}
