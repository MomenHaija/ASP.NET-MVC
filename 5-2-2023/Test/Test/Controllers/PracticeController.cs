using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class PracticeController : Controller
    {
        // GET: Practice
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Action()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Action(string user)
        {
            return Content("Hello" + user);
        }

    }
}