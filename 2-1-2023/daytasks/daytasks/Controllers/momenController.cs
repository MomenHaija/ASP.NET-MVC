using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace daytasks.Controllers
{
    public class momenController : Controller
    {
        // GET: momen
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult View1()
        {
            ViewBag.momen = "Engineering";
            return View();
        }
    }
}