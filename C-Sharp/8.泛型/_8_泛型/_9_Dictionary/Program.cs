using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _9_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化Dictionary泛型类
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //添加数据
            dic.Add(1,"Test");
            dic.Add(3,"User");
            dic.Add(2, "Admin");
            dic.Add(5, "Adobe");
            dic.Add(4, "Microsoft");
            dic.Add(6, "Java");
            
            //遍历数据
            Console.WriteLine("现在数据如下：");
            foreach (int i in dic.Keys)
            {
                Console.WriteLine("键："+i+"值："+dic[i]);
            }

            //判断存在并删除
            if (dic.Keys.Contains(6))
            {
                //删除Key为6的数据
                dic.Remove(6);
            }
            //遍历数据
            Console.WriteLine("删除后数据如下：");
            foreach (int i in dic.Keys)
            {
                Console.WriteLine("键：" + i + "值：" + dic[i]);
            }

        }
    }
}
