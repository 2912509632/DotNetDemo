using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.派生的接口
{
    /// <summary>
    /// 实现IDemoTest接口的类，必须实现IDemo接口和IDemoTest接口的所有成员
    /// </summary>
    class Person:IDemoTest
    {

        private string _name;

        private bool _sex;


        public void Work()
        {
            Console.WriteLine("我的工作是，自由职业！");
        }
        
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public bool IsMan(bool val)
        {
            _sex = val;
            return val;
        }

        public string Job()
        {
            return "我是有一名大学生！";
        }

        public void Hello()
        {
            char sex = _sex ? '男' : '女';
            Console.WriteLine("我叫{0}\n性别：{1}\n职业：{2}", _name, sex, Job());
        }
    }
}
