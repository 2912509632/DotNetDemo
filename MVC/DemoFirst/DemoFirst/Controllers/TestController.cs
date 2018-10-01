using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoFirst.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            return View();
        }

        public JsonResult CheckName()
        {
            using (DemoEntities db = new DemoEntities())
            {
                string name = Request.QueryString["UName"].ToString();
                var user = db.Users.Where(u => u.UName == name).FirstOrDefault();
                return user == null ? Json(false, JsonRequestBehavior.AllowGet) : Json(true, JsonRequestBehavior.AllowGet);
            }
        }
    }
}