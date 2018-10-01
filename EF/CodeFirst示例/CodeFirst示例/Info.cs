using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst示例
{
    public class Info
    {
        [Key]
        public int InfoID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Pass { get; set; }


        //导航属性
        //属性设置成virtual实现延迟加载
        public virtual List<Grade> Grade { get; set; }
    }
}
