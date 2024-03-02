using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai7_BTVN.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult TinhToan()
        {
            var a = 0.0;
            var b = 0.0;
            if(Request["txta"] != null)
            {
                a = double.Parse(Request["txta"]);
            }
            if(Request["txtb"] != null)
            {
                b = double.Parse(Request["txtb"]);
            }
            string op = "";
            if(op == "Cộng")
            {
                ViewBag.kq = a + b;
            }
            if(op == "Trừ")
            {
                ViewBag.kq = a - b;
            }
            if(op == "Nhân")
            {
                ViewBag.kq = a * b;
            }
            if(op == "Chia")
            {
                if (b == 0) ViewBag.kq = "Không thực hiện được";
                else ViewBag.kq = a / b;
            }
            return View();
        }
    }
}