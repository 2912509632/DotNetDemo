using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_泛型接口
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /// <summary>
    /// 泛型接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IMyClass<T>
    {

    }

    /// <summary>
    /// 多个泛型参数的泛型接口
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    interface ITestClass<TKey, TValue>
    { }


    /// <summary>
    /// 实现泛型接口的类
    /// </summary>
    /// 
    //如果IMyClass<T>泛型接口的泛型参数有约束，必须满足约束
    class MyClass : IMyClass<int>
    {
 
    }



}
