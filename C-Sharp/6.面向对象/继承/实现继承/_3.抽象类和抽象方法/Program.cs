using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.抽象类和抽象方法
{
    //抽象类
    abstract class Partent
    {
        //非抽象方法
        public void Show()
        {
            Console.WriteLine("我是抽象类里的非抽象方法!");
        }

        //返回数字抽象方法
        public abstract double Sum();

        //带有参数的抽象方法
        public abstract void Tell(string str);

        //暂时无功能的抽象方法
        public abstract void Null(); 
    }

    class Test : Partent
    {
        //实现返回数字的抽象方法
        public override double Sum()
        {
            return 123;
        }

        //实现带参的抽象方法
        public override void Tell(string str)
        {
            Console.WriteLine(str);
        }

        //暂不实现抽象方法的具体功能,抛出未实现的异常！
        public override void Null()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Show();
            Console.WriteLine(t.Sum());
            t.Tell("Hello");
            t.Null();
        }
    }
}
