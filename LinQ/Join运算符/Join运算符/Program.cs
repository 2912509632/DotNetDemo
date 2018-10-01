using System;
using System.Collections.Generic;
using System.Linq;

namespace Join运算符
{
    /// <summary>
    /// 学生信息类
    /// </summary>
    class StuInfo
    {
        public int StuID { get; set; }
        public string StuName { get; set; }
        public string StuSex { get; set; }
    }

    /// <summary>
    /// 学生成绩类
    /// </summary>
    class StuScore
    {
        public int StuID { get; set; }
        public double Chinese { get; set; }
        public double Math { get; set; }
        public double English { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //初始化数据
            List<StuInfo> info = new List<StuInfo>()
            {
                new StuInfo() { StuID=1000,StuName="何吉",StuSex="男"},
                new StuInfo() { StuID=1001,StuName="梁瑞",StuSex="女"},
                new StuInfo() { StuID=1002,StuName="张啸",StuSex="男"},
                new StuInfo() { StuID=1003,StuName="氪金",StuSex="女"},
                new StuInfo() { StuID=1004,StuName="詹浓",StuSex="男"}
            };
            List<StuScore> socre = new List<StuScore>()
            {
                new StuScore() { StuID=1000,Chinese=59.5,English=87,Math=25},
                new StuScore() { StuID=1001,Chinese=70,English=87,Math=65},
                new StuScore() { StuID=1002,Chinese=59.5,English=87,Math=25},
                new StuScore() { StuID=1003,Chinese=89,English=87,Math=45},
                new StuScore() { StuID=1004,Chinese=120,English=37,Math=25}
            };
            //join查询
            //查出平均成绩大于60的学生信息及数学成绩
            var query = from i in info
                       join s in socre
                       on i.StuID equals s.StuID
                       where (s.Chinese + s.English + s.Math) / 3 > 60
                       select new {
                           i.StuID,
                           i.StuName,
                           i.StuSex,
                           s.Math
                       };

            //输出信息
            Console.WriteLine("平均成绩大于60的学生信息及数学成绩");
            Console.WriteLine("\t 学号 \t 姓名 \t 性别 \t 数学成绩");
            foreach (var v in query)
                Console.WriteLine("\t {0} \t {1} \t {2} \t {3}",v.StuID,v.StuName,v.StuSex,v.Math);
        }
    }
}
