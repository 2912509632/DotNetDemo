using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_泛型类
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class Base
    { }

    class Base<T>
    { }

    class One<T> : Base
    { }

    class Two<T> : Base<int>
    { }

    class Three<T> : Base<T>
    { }

}
