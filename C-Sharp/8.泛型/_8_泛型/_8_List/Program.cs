using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _8_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化泛型集合
            List<string> list = new List<string>();
            //添加数据
            list.Add("123");
            list.Add("345");
            list.Add("234");
            list.Add("C478");
            list.Add("6478");
            list.Add("A6478");

            //遍历集合
            Console.WriteLine("添加数据后:");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
           
            //判断存在并移除
            if (list.Contains("6478"))
            {
                //移除数据
                list.Remove("6478");
            }
            Console.WriteLine("移除数据后：");
            //遍历集合
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            //排序 按首字母升序排列
            list.Sort();
            Console.WriteLine("数据排列后：");
            //遍历集合
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            //反转排序 
            list.Reverse();
            Console.WriteLine("反转排列后：");
            //遍历集合
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

        }
    }



}
