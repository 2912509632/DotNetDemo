//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 添加数据实体模型
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public Users()
        {
            this.Media = new HashSet<Media>();
        }
    
        public int UNum { get; set; }
        public string UName { get; set; }
        public string UPass { get; set; }
    
        public virtual ICollection<Media> Media { get; set; }
    }
}
