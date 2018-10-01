using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _6_BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建大小为8的点阵列
            BitArray bita = new BitArray(8);
            BitArray bitb = new BitArray(8);
            
            //将数字转为byte数组
            byte[] a = { 5 };
            byte[] b = { 58 };

            //将值存入点阵列
            bita = new BitArray(a);
            bitb = new BitArray(b);

            //输出点整列中的值
            foreach (var v in bita)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("----------");

            foreach (var v in bitb)
            {
                Console.WriteLine(v);
            }
        }

    }
}
