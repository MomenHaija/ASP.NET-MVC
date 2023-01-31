using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test12.Controllers
{
    public class MomenController : Controller
    {
        // GET: Momen
        public ActionResult Index()
        {
            return View();
        }
        public string About()
        {
            return "This is About Momen";

        }

        public string Contact()
        {
            return "For contact Me Phone:0775053512";

        }


        public ActionResult GetImage()
        {
            var imagePath = "C:\\Users\\haija\\ASP.NET-Validation\\29-12\\test12\\test12\\Content\\fuice_juice_fb_sm.jpg";
            var stream = new FileStream(imagePath, FileMode.Open);
            return File(stream, "image/jpeg", "fuice_juice_fb_sm.jpg");
        }
        public ActionResult show()
        {
            string html = "<h1>Click on image for Download</h1>" +
                "<a href='" + Url.Action("GetImage") + "'>" +
                            "<img src='../Content/fuice_juice_fb_sm.jpg' height='500' width='800' alt='Image to download' />" +
                          "</a>" +
                          "<br />";

            return Content(html);
        }

    }
}