using daytasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace daytasks.Controllers
{
    public class TASKSController : Controller
    {
        // GET: TASKS
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult task1()
        {
            List<Models.Student> std = new List<Models.Student>();
            std.Add(new Models.Student { Id=  1,Name="Mayyas",Major="Arabic",Faculity= "college of Literature" });
            std.Add(new Models.Student { Id = 2, Name = "Momen", Major = "Electrical Engineering", Faculity = "college of Engineering" });
            std.Add(new Models.Student { Id = 3, Name = "sohaib", Major = "Mechanical Engineering", Faculity = "college of Engineering" });
            std.Add(new Models.Student { Id = 4, Name = "Yazzed", Major = "Mechanical Engineering", Faculity = "college of Engineering" });
            std.Add(new Models.Student { Id = 5, Name = "Mohammad", Major = "Electrical Engineering", Faculity = "college of Engineering" });

            return View(std);
        }
    }
}