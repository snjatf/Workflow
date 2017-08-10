using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Workflow.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page!!!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult mytest()
        {
            ViewBag.Message = "Your contact page.";

            var obj = new
            {
                Name = "wonder4",
                Id = 1
            };
            return Json(obj,JsonRequestBehavior.AllowGet);
            //return Content(obj.ToString());
        }
    }
}