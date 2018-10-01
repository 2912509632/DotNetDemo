using System;
using System.Collections.Generic;
using System.Linq;

namespace 量词操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化数据
            List<Info> infos = new List<Info>()
            {
                new Info() { Name="张三",Sex="",Year=1995},
                new Info() { Name="李四",Sex="",Year=1887},
                new Info() { Name="王五",Sex="",Year=1978},
                new Info() { Name="钱六",Sex="",Year=1994},
                new Info() { Name="周七",Sex="",Year=1997}
            };

            //查询是否存在
            var query = infos.Select(m => m.Year).Contains(1997);
            Console.WriteLine(query);
       
        }
    }

    class Info
    {
        public string Name { get; set; }

        public string Sex { get; set; }

        public int Year { get; set; }
    }
}
