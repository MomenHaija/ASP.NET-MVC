using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class practiceController : Controller
    {
        // GET: practice
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Action1()
        {

            return View();
        }
        public ActionResult Action2()
        {

            return Content("Hello");
        }

    }
}