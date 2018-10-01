using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_自定义异常
{

    /// <summary>
    /// 自定义异常类
    /// </summary>
    [Serializable] //可序列化
    public class DIYExprection : ApplicationException
    {
        //默认构造参数
        public DIYExprection()
        { }

        //带有错误信息的构造参数
        public DIYExprection(string message)
            : base(message)
        { }

        //带有错误信息，异常信息的构造参数
        public DIYExprection(string message, Exception e)
            : base(message, e)
        { }

        //带有序列化相关信息的构造参数
        public DIYExprection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        { }
    }


    /// <summary>
    /// 数据计算类
    /// </summary>
    public class Computer
    {
        public double a { set; get; }
        public double b { set; get; }

        /// <summary>
        /// 除法计算
        /// </summary>
        /// <returns></returns>
        public double Division()
        {
            if (a == 0 || b == 0)
            {
                //除数为0引发异常
                throw new QDIYExprection("除数不可以为0,你要记住哦！");
            }
            return a / b;
        }
    }


    /// <summary>
    /// 程序入口
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Computer c = new Computer();
                c.a = 5;
                c.b = 0;
                Console.WriteLine("a/b=" + c.Division());
            }
            catch (DIYExprection diy)
            {
                Console.WriteLine(diy.Message);
            }
            catch
            {
                Console.WriteLine("程序发生异常！");
            }
            finally
            {
                Console.WriteLine("程序运行完毕！");
            }
        }
    }
}
