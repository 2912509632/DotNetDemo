using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_泛型约束
{
    class Program
    {
        static void Main(string[] args)
        {
            ////不被允许的类型，编译器报错
            ////Test<IDisposable> test = new Test<IDisposable>();

            ////被允许的类型，编译通过
            //Test<int> test = new Test<int>();

            Key_Default<int> test = new Key_Default<int>();
            Console.WriteLine(test.GetValue());
        }
    }


    /// <summary>
    /// 带类型约束的泛型类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Test<T>
        where T : ITest,new() //多个约束时必须放在最后
    {

    }


    /// <summary>
    /// 接口约束
    /// </summary>
    public interface ITest
    {

    }

    /// <summary>
    /// 此泛型类的实现仅支持实现ITest接口的类型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MustUseInterface<T>
        where T : ITest
    {
        //泛型类内容
    }




    /// <summary>
    /// 基类约束
    /// </summary>
    public class MyTest
    {
        //我是基类
    }

    /// <summary>
    /// 此泛型类的实现仅支持MyTest的派生类或本身
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MustByBaseClass<T>
        where T : MyTest
    {
        //泛型类的内容
    }


    /// <summary>
    /// 构造函数约束
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MustByTest<T>
        where T : ITest, new()
    {
        //泛型类内容
    }


    /// <summary>
    /// 多个泛型参数时，需要为每个泛型参数写个独立的where语句
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class MulitInput<TKey, TValue>
        where TKey : struct
        where TValue : ITest
    {
        //泛型类内容
    }


    /// <summary>
    /// 裸类型约束
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class OnlyType<T>
    where T : ITest
    {
        void Test<U>()
            where U : T
        {
            //泛型方法实现代码
        }
    }


    
   /// <summary>
   /// 使用default关键字的泛型类
   /// </summary>
   /// <typeparam name="T"></typeparam>
    public class Key_Default<T>
    {
        /// <summary>
        /// 返回默认值
        /// </summary>
        /// <returns></returns>
        public T GetValue()
        {
            return default(T);
        }
    }

}
