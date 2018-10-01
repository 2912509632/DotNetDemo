using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.接口的定义及实现
{    
    //学生类实现人类接口
    class Student : IDemo
    {

        private string _name;

        private bool _sex;

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
            char sex=_sex?'男':'女';
            Console.WriteLine("我叫{0}\n性别：{1}\n职业：{2}",_name,sex,Job());
        }
    }
}
