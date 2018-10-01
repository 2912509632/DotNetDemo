using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.密封类和密封方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Own o = new Own();
            o.Show();
            Top t = new Top();
            t.Hellow();
            Middlen m = new Middlen();
            m.Hellow();
            Buttom b = new Buttom();
            b.Output();
        }
    }


    class Top
    {
        public virtual void Hellow()
        {
            Console.Write("我是Top父类");
        }
    }

    sealed class Own
    {
        //密封类，不能被其他类所继承,但是可以实现
        public void Show()
        {
            Console.WriteLine("我是密封类！");
        }
    }

    class Middlen : Top
    {
        public sealed override void Hellow()
        {
            Console.WriteLine("我是将Top父类的Hellow方法重写为密封方法");
        }
    }

    class Buttom : Middlen
    {
        //错误	1	“_4.密封类和密封方法.Buttom.Hellow()”: 继承成员“_4.密封类和密封方法.Middlen.Hellow()”是 sealed，无法进行重写
        //public override void Hellow()
        //{
        //    Console.WriteLine("我是将Top父类的Hellow方法重写为密封方法");
        //}
        public void Output()
        {
            Console.WriteLine("我是Buttom子类");
        }
    }
}
