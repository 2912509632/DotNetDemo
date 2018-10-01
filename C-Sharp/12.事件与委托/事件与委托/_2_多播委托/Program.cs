using System;

namespace _2_多播委托
{
    //声明委托
    public delegate double Number(double num);

    /// <summary>
    /// 数字计算类
    /// </summary>
    internal class Cal
    {
        public static double x = 5;

        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double Sum(double num)
        {
            x += num;
            return x;
        }

        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double Sub(double num)
        {
            x -= num;
            return x;
        }

        /// <summary>
        /// 乘法
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double Mul(double num)
        {
            x *= num;
            return x;
        }
    }

    /// <summary>
    /// 程序入口
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            //实例化委托
            Number list; //空委托
            Number sum = new Number(Cal.Sum);
            Number sub = new Number(Cal.Sub);
            Number mul = new Number(Cal.Mul);

            Console.WriteLine("当前x值为：" + Cal.x);

            //多播委托
            list = sum;
            list += sum;
            list += sub;
            list += mul;
            list -= sum;

            list(5);

            Console.WriteLine("当前x值为：" + Cal.x);
        }
    }
}