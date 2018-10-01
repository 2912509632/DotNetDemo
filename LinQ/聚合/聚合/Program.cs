using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 聚合
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

            //查询数据
            var query = from info in infos
                        where info.Year == infos.Min(m => m.Year)
                        select info;

            //展示数据
            foreach (Info i in query)
                Console.WriteLine("\t {0} \t {1} \t {2}",i.Name,i.Sex,i.Year);
        }
    }

    class Info
    {
        public string Name { get; set; }

        public string Sex { get; set; }

        public int Year { get; set; }
    }
}
