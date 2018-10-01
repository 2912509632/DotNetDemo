using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst示例
{
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }

        [Required]
        public double Chinese { get; set; }

        [Required]
        public double English { get; set; }

        [Required]
        public double IT { get; set; }

        //外键
        [ForeignKey("Info")]
        public int InfoID { get; set; }

        //导航属性
        public virtual Info Info { get; set; }
    }
}
