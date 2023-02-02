using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class sumController : Controller
    {
        // GET: sum


        //public ActionResult Index()
        //{
        //    return View();
        //}
        //    [ActionName("llSum")]
        //[HttpGet]
        //public ActionResult Sum_get()
        //{
        //    ViewBag.num1 = 0;
        //    ViewBag.num2 = 0;

        //    ViewBag.num3 = 0;

        //    ViewBag.result = 0;

           

        //    return View();
        //}


        //[ActionName("llSum")]
        //[HttpPost]
        //public ActionResult Sum_post(int num1,int num2,int num3) {
        
        
        //    int sum=num1+ num2+num3;
        //    ViewBag.result=sum;
        //    return View();
        
        //}



        //[ActionName("llSum")]
        //[HttpPost]
        //public ActionResult allsum(FormCollection obj)
        //{
        //   int num1 = int.Parse(obj["num1"]);
        //   int num2 = int.Parse(obj["num2"]);
        //   int num3 = int.Parse(obj["num3"]);

        //    int sum = num1 + num2 + num3;
        //    ViewBag.result = sum;
        //    return View();

        //}

        [ActionName("llSum")]
        [HttpPost]
        public ActionResult dataresult(int num1,int num2,int num3)
        {
            ViewBag.num1 = num1;    
            ViewBag.num2 = num2;    
            ViewBag.num3 = num3;    
            int s=num1+num2+num3;
            TempData["Sum"] = s;
            return RedirectToAction("Result");   
        }



        [ActionName("llSum")]

        [HttpGet]
        public ActionResult datasum() {

            ViewBag.num1 = 0;
            ViewBag.num2 = 0;
            ViewBag.num3 = 0;

            return View();
        }

        public ActionResult Result()
        {

            

            return View();
        }
       

    }
}