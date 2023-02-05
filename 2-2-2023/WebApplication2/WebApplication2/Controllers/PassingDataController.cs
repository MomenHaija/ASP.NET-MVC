using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class PassingDataController : Controller
    {
        // GET: PassingData
        public ActionResult Index()
        {
            return View();
        }
        [ActionName("Greate")]
        [HttpGet]
        public ActionResult Greate()
        {
            ViewBag.id = 0;
            ViewBag.categoryName = "";
            return View();
        }
        [ActionName("Greate")]
        [HttpPost]
        public ActionResult Greate(int id,string categoryName)
        {
            ViewBag.id = id;
            ViewBag.categoryName = categoryName;
            return View();
        }


    }
}