using System;
using System.Collections.Generic;
using System.Linq;

namespace Group操作
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

            //按性别分组
            var query = from i in info 
                        group i by i.StuSex into n 
                        select n;

            //展示数据
            foreach (var group in query)
            {
                Console.WriteLine((group.Key == "男" ? "男" : "女")+"生信息如下：");
                foreach (var i in group)
                    Console.WriteLine("\t {0} \t {1} \t {2}",i.StuID,i.StuName,i.StuSex);
            }        
        }
    }
}
