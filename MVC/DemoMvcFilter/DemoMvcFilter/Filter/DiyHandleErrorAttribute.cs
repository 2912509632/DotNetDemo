using System;
using System.Web.Mvc;

namespace DemoMvcFilter.Filter
{
    /// <summary>
    /// 自定义异常过滤器
    /// </summary>
    public class DiyHandleErrorAttribute:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //获取异常处理对象，不处理异常时可以不获取
            Exception e = filterContext.Exception;
            //处理异常处理对象
            filterContext.Result = new RedirectResult("~/Error.html");    //跳转到异常页
            //标记异常处理完成
            filterContext.ExceptionHandled = true;
            //调用系统异过滤器
            base.OnException(filterContext);
        }
    }
}