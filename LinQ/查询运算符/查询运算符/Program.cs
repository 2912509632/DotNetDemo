using System;
using System.Linq;

namespace 查询运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据源
            string[] data = new string[] { "Jiuone","HMister","Tolur","707","MXYVip"};
            //查询运算符
            var query = from str in data
                        where str.Length > 5
                        select str;
            //展示数据
            foreach (string s in query)
                Console.WriteLine(s);
        }
    }
}
