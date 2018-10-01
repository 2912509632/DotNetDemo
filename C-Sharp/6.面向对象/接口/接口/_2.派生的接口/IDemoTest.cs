using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.派生的接口
{
    /// <summary>
    /// 继承自IDemo的接口
    /// </summary>
    interface IDemoTest:IDemo
    {
        /// <summary>
        /// 所做的工作
        /// </summary>
        void Work();
    }
}
