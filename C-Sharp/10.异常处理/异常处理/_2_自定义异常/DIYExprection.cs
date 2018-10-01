using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_自定义异常
{

    [Serializable] //可序列化
    public class QDIYExprection:ApplicationException
    {
        //默认构造参数
        public QDIYExprection()
        { }

        //带有错误信息的构造参数
        public QDIYExprection(string message)
            : base(message)
        { }

        //带有错误信息，异常信息的构造参数
        public QDIYExprection(string message, Exception e)
            : base(message, e)
        { }

        //带有序列化相关信息的构造参数
        public QDIYExprection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        { }
    }
}
