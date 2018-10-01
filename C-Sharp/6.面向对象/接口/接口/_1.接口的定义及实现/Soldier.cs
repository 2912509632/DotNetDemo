using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.接口的定义及实现
{
    /// <summary>
    /// 
    /// </summary>
    class Soldier:IDemo
    {

        private string _name;

        private bool _sex;

        public string Name
        {
            get
            {
                return "人民解放军"+_name;
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
            return "我是一名人民子弟兵，我光荣！";
        }

        public void Hello()
        {
            char sex = _sex ? '男' : '女';
            Console.WriteLine("我叫{0}\n性别：{1}\n职业：{2}", _name, sex, Job());
        }

        public void FirstJob()
        {
            Console.WriteLine("我的首要任务是：维护祖国安全！");
        }
    }
}
