using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _2_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            //哈希表
            Hashtable ht = new Hashtable();
            ht.Add('A', "123");
            ht.Add('B', "456");
            ht.Add('C', "789");
            ht.Add('D', "101");
            ht.Add('E', "102");
            ht.Add('F', "103");

            //获取键集合
            ICollection keys = ht.Keys;

            //遍历输出对应值
            foreach (char c in keys)
            {
                Console.WriteLine(ht[c]);
            }

        }
    }
}
