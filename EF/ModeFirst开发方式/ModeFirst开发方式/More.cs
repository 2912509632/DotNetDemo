//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModeFirst开发方式
{
    using System;
    using System.Collections.Generic;
    
    public partial class More
    {
        public int ID { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public int InfoID { get; set; }
    
        public virtual Info Info { get; set; }
    }
}
