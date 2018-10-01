using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.实例构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.Show();
            Console.WriteLine("---------");
            Test t2 = new Test(3,4);
            t2.Show();
            
        }
    }

    class Test
    {

        private int x;
        private int y;

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Test()
        {
            this.x = 1;
            this.y = 2;
        }

        /// <summary>
        /// 带参构造方法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Test(int a, int b)
        {
            this.x = a;
            this.y = b;
        }

        public void Show()
        {
            Console.WriteLine("X：{0}\nY：{1}",this.x,this.y);
        }


    }
}
