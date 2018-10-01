using System.Web.Mvc;

namespace DemoMvcFilter.Filter
{
    public class DemoResultFilterAttribute:ActionFilterAttribute
    {
        /// <summary>
        /// 加载视图前执行
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<br/>视图加载前<br/>" + System.DateTime.Now.ToString());
            base.OnResultExecuting(filterContext);
        }

        /// <summary>
        /// 视图加载后执行
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<br/>视图加载后<br/>" + System.DateTime.Now.ToString());
            base.OnResultExecuted(filterContext);
        }
    }
}