//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 简单查询和延时加载
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        public int AID { get; set; }
        public string ATitle { get; set; }
        public string AText { get; set; }
        public Nullable<System.DateTime> ATime { get; set; }
        public Nullable<int> CID { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
