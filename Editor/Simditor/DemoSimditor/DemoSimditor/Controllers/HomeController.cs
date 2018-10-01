using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoSimditor.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpImg()
        {
            return Json(new {
                success=true,
                msg="上传成功",
                file_path = "http://www.ninecms.com/UpLoad/2018/2/20180211214219.png"
            });
        }

    }
}
