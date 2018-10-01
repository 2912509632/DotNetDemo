using System.Web.Mvc;

namespace DemoMvcFilter.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [DemoMvcFilter.Filter.DiyAuthorizeAttribute]
        public ActionResult Index()
        {
            return View();
        }
    }
}