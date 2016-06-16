using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LWALDTECH.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Lindenwal Technology Solutions (Application Page)";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How to reach Lindenwald Technology Solutions";

            return View();
        }
        public ActionResult FunStuff()
        {
            ViewBag.Message = "Fun Stuff Page";
            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "This is a test page";
            return View();
        }
    }
}