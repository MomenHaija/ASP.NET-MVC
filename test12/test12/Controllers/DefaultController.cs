using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test12.Models;

namespace test12.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult View1()
        {
           
            ViewBag.Message = "Your contact page.";
            student student = new student();
            student.Name = "Momen";
            student.Description = "hello";
            student.Id = 1;
            return View(student);
        }
    }
}