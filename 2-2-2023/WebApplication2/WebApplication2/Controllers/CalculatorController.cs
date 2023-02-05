using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
        //Calculator
        //[ActionName("Sum")]
        //[HttpGet]
        //public ActionResult Sum()
        //{
        //    ViewBag.n1 = 0;
        //    ViewBag.n2 = 0;
        //    ViewBag.n3 = 0;
        //    ViewBag.result = 0;
        //    return View();
        //}
        //[ActionName("Sum")]
        //[HttpPost]
        //public ActionResult result(int n1,int n2,int n3)
        //{
        //    ViewBag.n1 = n1;    
        //    ViewBag.n2 = n2;
        //    ViewBag.n3 = n3;
        //    ViewBag.result=n1+ n2+n3;
        //    return View();
        //}

        [ActionName("Sum")]
        [HttpGet]
        public ActionResult FormSum()
        {

            ViewBag.n4 = 0;
            ViewBag.n5 = 0;
            ViewBag.n6 = 0;
           
            ViewBag.result = 0;
            return View();
        }
        [ActionName("Sum")]
        [HttpPost]
        public ActionResult formresult(FormCollection obj)
        {
          
            int n4 = int.Parse(obj["n4"]);
            int n5 = int.Parse(obj["n5"]);
            int n6 = int.Parse(obj["n6"]);


            int result =n4+n5+n6;
            
            ViewBag.n4 = n4;
            ViewBag.n5 = n5;
            ViewBag.n6 = n6;
            ViewBag.result = result;

            return View();
        }
        [HttpGet]
        public ActionResult GoodMorning()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GoodMorning(string FirstName,string LastName)
        {
            if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName)) 
            {
                return Content("Good Morning " + FirstName + " " + LastName);

            }
            else
            {
                return View();
            }
        }


    }
}