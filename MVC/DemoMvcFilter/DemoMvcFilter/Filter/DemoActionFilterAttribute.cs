using System.Web.Mvc;

namespace DemoMvcFilter.Filter
{
    public class DemoActionFilterAttribute:ActionFilterAttribute
    {
        /// <summary>
        /// Action执行前执行
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<br/>Action执行前<br/>" + System.DateTime.Now.ToString());
            base.OnActionExecuting(filterContext);
        }

        /// <summary>
        /// Action
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<br/>Action执行后<br/>" + System.DateTime.Now.ToString());
            base.OnActionExecuted(filterContext);
        }
    }
}