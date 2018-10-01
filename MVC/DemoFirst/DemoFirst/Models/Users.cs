using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DemoFirst.Models
{
    [MetadataType(typeof(UsersMetadata))]
    public partial class Users
    {   
    }


    /// <summary>
    /// 数据注解
    /// </summary>
    public class UsersMetadata
    {
        [Required]
        [Range(10000,99999,ErrorMessage ="超过最大允许长度！")]
        public int UNum { get; set; }

        [Required]
        [Remote("CheckName", "Test")]
        [MaxLength(20,ErrorMessage ="用户名过长！")]
        public string UName { get; set; }

        [Required]
        [PasswordPropertyText]
        public string UPass { get; set; }

        [IsEmail]
        public string Mail { get; set; }
    }


    //自定义注解属性
    //用于判断是否为邮箱
    public class IsEmailAttribute : RegularExpressionAttribute
    {
        public IsEmailAttribute() : base(@"^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.[a-zA-Z0-9]{2,6}$")
        {
        }
    }
}