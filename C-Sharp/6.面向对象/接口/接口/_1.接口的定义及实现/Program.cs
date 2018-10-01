using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.接口的定义及实现
{
    class Program1
    {
        static void Main(string[] args)
        {
         
            //通过实现接口的类使用
            Student stu = new Student();
            stu.Name = "张三";
            stu.IsMan(false);
            stu.Hello();

            //通过实例化引用了接口的类实现
            IDemo solider = new Soldier();
            solider.Name = "王五";
            solider.IsMan(true);
            solider.Hello();
            //只能使用接口中声明的成员


            Console.WriteLine("\n***使用接口数组***\n");
            //使用接口数组
            IDemo[] arry=new IDemo[2];
            arry[0] = stu;
            arry[1] = solider;
            arry[0].Hello();
            arry[1].Hello();

            Console.WriteLine("\n***强制转换实现接口中不存在实现类中存在的方法***\n");
            //强制转换实现接口中不存在实现类中存在的方法
            Soldier s2 = (Soldier)solider;
            s2.FirstJob();
        }
    }

}