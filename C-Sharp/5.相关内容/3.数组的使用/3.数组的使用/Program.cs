using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.数组的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明数组
            string[] strs = new string[5];//先声明后赋值
            strs[0] = "0";
            strs[1] = "1";
            strs[2] = "2";
            strs[3] = "3";
            strs[4] = "￥";

            int[] arr = new int[] { 1,2,3,4,5,6,7}; //声明的同时赋值
            
            //访问数组
            Console.WriteLine("strs最后一个为："+strs[4]);
            //循环访问
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(string.Format("第{0}个元素为：{1}",i+1,arr[i]));
            }

        }
    }
}
