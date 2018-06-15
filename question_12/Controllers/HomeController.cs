using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace question_12.Controllers
{
    public struct MyBrowser
    {
        public string Name;
        public string Version;
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(ShowBrowser());
        }

        public MyBrowser ShowBrowser()
        {

            MyBrowser myBrowser;
            myBrowser.Name = Request.Browser.Browser;
            myBrowser.Version = Request.Browser.Version;

            return myBrowser;
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}