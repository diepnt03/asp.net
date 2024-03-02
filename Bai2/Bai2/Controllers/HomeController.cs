using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditEmployee(int id)
        {
            return Content("<h1>id = " + id + "</h1>");
        }

        public ActionResult EditEmployee2(int empid)
        {
            return Content("<h1>empid = " + empid + "</h1>");
        }

        public ActionResult MyLink()
        {
            ViewBag.Message = "Liên kết của tôi";
            return View();
        }

        public ActionResult Display()
        {
            //return PartialView("_EmployeeDetail");
            //return new EmptyResult();
            //return Redirect("http://vnexpress.net");
            //return RedirectToAction("Welcome", "Haui");
            //return Json("Hello", JsonRequestBehavior.AllowGet);
            //return Content("Hello world");
            return File(@"d:\SinhVien.txt", "text/plain");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}