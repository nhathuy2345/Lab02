using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab02.Controllers
{
    public class lab02Controller : Controller
    {
        public ActionResult bai2()
        {
            return View();
        }
        public ActionResult bai1()
        {
            return View();
        }

        public ActionResult vd5()
        {
            return View();
        }

        public ActionResult vd4()
        {
            return View();
        }


        public ActionResult vd3()
        {
            return View();
        }
        public ActionResult vd2()
        {
            return View();
        }
        public ActionResult vidu1()
        {
            return View();
        }
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
    }
}