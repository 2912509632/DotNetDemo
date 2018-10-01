using System.Web.Mvc;

namespace DemoMvcFilter.Filter
{
    public class DiyAuthorizeAttribute:AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.RouteData.Values["controller"].ToString() == "Admin")
            {
                filterContext.HttpContext.Response.Write("您无权访问后台！");
            }

            //注释掉，防止调用系统授权验证机制
            //base.OnAuthorization(filterContext);
        }
    }
}