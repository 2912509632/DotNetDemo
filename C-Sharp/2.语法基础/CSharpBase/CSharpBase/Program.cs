//程序所需要使用的命名空间

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBase //程序命名空间
{
    class Program //类名
    {
        #region 我这是可折叠的部分，代码大纲
        static void Main(string[] args) //这是主方法整个程序的入口
        {
           //声明int类型变量,变量名为num
            int num;
            //为num变量赋值123
            num = 123;
            //输出num变量
            Console.WriteLine(num);

            //声明局部隐形变量 并赋值字符串 Test
            var str="Test";
            //输出变量str;
            Console.WriteLine(str);

        }
        #endregion
    }
}
