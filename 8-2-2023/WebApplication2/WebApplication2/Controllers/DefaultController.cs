using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            int d = int.Parse(DateTime.Now.Hour.ToString());
            Response.Write(d);
            if (d > 15) { Response.Write(true); }
            else { Response.Write(false); }
            string day= System.DateTime.Now.DayOfWeek.ToString();
            string date= System.DateTime.Now.Date.ToString("yyyy-MM-dd");
            Response.Write(date);
            Response.Write(day);    
            return View();

        }
    }
}