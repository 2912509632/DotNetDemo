using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.派生的接口
{

   /// <summary>
   /// 演示接口
   /// </summary>
    interface IDemo
    {

        /// <summary>
        /// 姓名
        /// </summary>
        string Name { get; set; }


        /// <summary>
        /// 是否为男
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        bool IsMan(bool val);


        /// <summary>
        /// 职业
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        string Job();

        /// <summary>
        /// 打招呼
        /// </summary>
        void Hello();

    }
}
