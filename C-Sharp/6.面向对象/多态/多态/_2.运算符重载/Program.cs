using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.运算符重载
{
    //矩形类
    class Box
    {
        //矩形属性
        public double Long { get; set; } //长

        public double Width { get; set; } //宽

        public double Value { get; set; } //面积和

        //计算两个矩形面积和方法
        //使用重载运算符+实现
        public static Box operator+(Box a,Box b)
        {
            Box box=new Box();
            box.Value = a.Long * a.Width;
            box.Value += b.Long * b.Width;
            return box;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //使用重载运算符
            Box b1 = new Box();
            b1.Long = 5;
            b1.Width = 3;

            Box b2 = new Box();
            b2.Long = 8;
            b2.Width = 7;

            //使用b3接收矩形面积和
            Box b3 = new Box();
            b3 = b1 + b2;
            //输出面积和
            Console.WriteLine(b3.Value);  //输出：71
        }
    }
}
