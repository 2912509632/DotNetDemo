using System.Web.Mvc;

namespace DemoMvcFilter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[DemoMvcFilter.Filter.DemoActionFilter] //使用Action过滤器
        //[DemoMvcFilter.Filter.DemoResultFilter] //使用Result过滤器
        [DemoMvcFilter.Filter.DiyHandleError] //使用错误过滤器
        public ActionResult Index()
        {
            //制造错误
            int a = 0;
            int b = 13 / a;
            return View();
        }
    }
}