using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebKendo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult KendoUI()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Kendo_editor()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult InformationStudents()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}