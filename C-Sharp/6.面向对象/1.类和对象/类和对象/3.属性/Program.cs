using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.属性
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /// <summary>
    /// 学生属性
    /// </summary>
    public class Student
    {
        //学生姓名
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("学生不能姓名为空！");
                }
                _Name = value;
            }
        }
    }

    /// <summary>
    /// 自动属性
    /// </summary>
    public class AutoAttr
    {
        //无初始值的自动属性
        public string NoInit { get; set; }

        //带初始值的自动属性
        // public string Init { get; set; }="我是初始值"; .//仅C#6.0支持
    }

}
