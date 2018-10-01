using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DemoMvcApi.Controllers
{
    public class TestController : ApiController
    {
        List<Models.Info> infos = new List<Models.Info>()
        {
            new Models.Info(){ ID=1,Name="张三",Sex="男"},
            new Models.Info(){ ID=2,Name="李四",Sex="女"},
            new Models.Info(){ ID=3,Name="王五",Sex="男"},
            new Models.Info(){ ID=4,Name="钱六",Sex="男"},
            new Models.Info(){ ID=5,Name="赵七",Sex="女"}
        };


        public IEnumerable<Models.Info> GetInfo()
        {
            return infos;
        }


        public IHttpActionResult GetJson()
        {
            return Json(infos);
        }

        public IHttpActionResult GetInfoById(int id)
        {
            Models.Info i = infos.FirstOrDefault(o => o.ID == id);
            if (i == null)
                return NotFound();
            else
                return Ok(i);
        }
       
    }
}
