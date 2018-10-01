using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_泛型委托
{
    class Program
    {
        static void Main(string[] args)
        {
            DelTest<int> del1 = new DelTest<int>(Test);
            del1.Invoke(123456);

            DelTest<string> del2 = new DelTest<string>(Test);
            del2.Invoke("Hello Word!");

            //不存在double类型的实现方法导致编译器报错。
            //DelTest<double> del3 = new DelTest<double>(Test); 
            //del3.Invoke(123.22);
        }

        /// <summary>
        /// 泛型委托
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        private delegate void DelTest<T>(T item);

        //委托方法
        private static void Test(int i)
        {
            Console.WriteLine("值：{0}\n类型：{1}",i,i.GetType());
        }

        private static void Test(string str)
        {
            Console.WriteLine("值：{0}\n类型：{1}", str, str.GetType());
        }

    }
}
