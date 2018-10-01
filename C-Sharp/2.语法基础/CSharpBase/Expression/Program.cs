using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpBase; //测试引用命名空间

namespace Expression
{

    class Program
    {

        /// <summary>
        /// 表达式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //声明变量 num1 与 num2
            int num1 = 5;
            int num2 = 10;
            int res;

            //简单的数学运算符
            //二元 + 运算
            int sum = num1 + num2;
            Console.WriteLine(sum);
            //一元 - 运算
            res = -num1;
            Console.WriteLine(res);

            //字符串连接运算符
            string str;
            string str1 = "123";
            string str2 = "456";
            str = str1 + str2;
            Console.WriteLine(str);

            //简单表达式
            //++a与a++
            int res1, res2;
            int a = 5;
            int b = 5;
            res1 = a++; //寄存器中a的值执行+1已变成6，返回a的值
            res1 = a + 1; //再次使用a的值，此时a的值为6，+1后等于7
            res2 = ++b;
            Console.WriteLine(string.Format("c=a++={0}\nc=++b={1}", res1, res2));

            //赋值
            //验证 j*=k与j=j*k等效
            int res3;
            int j = 5;
            int k = 10;
            res3 = j * k;
            j *= k;
            Console.WriteLine(j + "\n" + res3);

            //三元运算符
            int test = 50;
            test = test > 49 ? test + 1 : test - 1;
            Console.WriteLine(test);


            //命名空间内容的调用
            Test.Test1.Me();
        }
    }
}



namespace Test
{
    //这里是代码
    class Test1
    {

        public static void Me() { }
    }
}