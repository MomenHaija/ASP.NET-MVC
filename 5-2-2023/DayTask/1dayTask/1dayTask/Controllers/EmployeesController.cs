using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using _1dayTask.Models;
using _1dayTask.Models;
namespace _1dayTask.Controllers
{
    public class EmployeesController : Controller
    {
        private TaskTwoMVCEntities db = new TaskTwoMVCEntities();

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        [HttpPost]
        public ActionResult Index (string searchtext, string searchtype)
        {
            var emp = from employee in db.Employees select employee; ;

            try
            {
                int serarc = int.Parse(searchtype);
                switch (serarc)
                {
                    case 1:
                        emp = from employee in db.Employees where employee.First_Name.Contains(searchtext) select employee;

                        break;
                    case 2:
                        emp = from employee in db.Employees where employee.Last_name.Contains(searchtext) select employee;
                        break;
                    case 3:
                        emp = from employee in db.Employees where employee.E_mail.Contains(searchtext) select employee;
                        break;



                }

                return View ("Index",emp.ToList());
            }
            catch(Exception ex)
            {
                return View(emp.ToList());
            }
        }
        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        public PartialViewResult Lastorder()
        {
            var orders = db.Orders.OrderByDescending(o => o.Orderid).FirstOrDefault();
            return PartialView("_Lastorder", orders);
        }
        public PartialViewResult info()
        {
            var t = db.Employees;
            return PartialView("View1", t.ToList());
        } 
        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,First_Name,Last_name,E_mail,Phone,Age,Job_Title,Gender,picture,CV")] Employee employee,HttpPostedFileBase picture,HttpPostedFileBase CV)
        {
            string pic = Path.GetFileName(picture.FileName);
            string cv = Path.GetFileName(CV.FileName);

            if (ModelState.IsValid)
            {
              
                string path = "../Images/"+ Path.GetFileName(picture.FileName);
                picture.SaveAs(Server.MapPath(path));
                employee.picture = path;

                string CVpath = "../Images/" + Path.GetFileName(CV.FileName);
                CV.SaveAs(Server.MapPath(CVpath));
                employee.CV = CVpath;

                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");

            }


            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,First_Name,Last_name,E_mail,Phone,Age,Job_Title,Gender,picture,CV")] Employee employee,string picturelink,string CVlink, HttpPostedFileBase picture, HttpPostedFileBase CV)
        {
            string picpath="";
            string path = "";
            if (employee.picture != null)
            {
                path = "~/Images/" + Path.GetFileName(picture.FileName);
                picpath = "../Images/" + Path.GetFileName(picture.FileName);
                picture.SaveAs(Server.MapPath(path));
                

            }
            else
            {
                picpath=picturelink;
            }

            string CVlinke = "";
            string CVpath = "";
            if (employee.CV != null)
            {
                CVpath = "~/Images/" + Path.GetFileName(CV.FileName);
                CVlinke = "../Images/" + Path.GetFileName(CV.FileName);
                CV.SaveAs(Server.MapPath(CVpath));


            }
            else
            {
                CVlinke = CVlink;
            }


            if (ModelState.IsValid)
            {
                employee.picture = picpath;
                employee.CV = CVlinke;  
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
