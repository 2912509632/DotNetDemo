using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1派生类的带参构造函数
{
    class Program
    {
        class Partent
        {
            public int Value = 0;

            public Partent(int a,int b)
            {
                Console.WriteLine("父类构造：Value={0}", Value);
                Console.WriteLine("父类构造：Value+a+b={0}",Value+a+b);
                Console.WriteLine("父类构造：Value={0}", Value);
            }
        }

        class Test : Partent
        {
            public Test(int x,int y,int z):base(x,y)
            {
                Console.WriteLine("您输入的X,Y,Z值为{0},{1},{2}",x,y,z);
                Console.WriteLine("子类构造：Value={0}", base.Value);
            }
        }

        static void Main(string[] args)
        {
            Test t = new Test(3, 5, 7);
        }
    }
}

//输出：
//父类构造：Value=0
//父类构造：Value+a+b=8
//父类构造：Value=0
//您输入的X,Y,Z值为3,5,7
//子类构造：Value=0
//请按任意键继续. . .