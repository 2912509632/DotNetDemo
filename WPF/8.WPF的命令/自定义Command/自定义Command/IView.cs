using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义Command
{
    public interface IView
    {
        //属性
        bool IsChanged { get; set; }

        //方法
        void Clear();
    }
}
