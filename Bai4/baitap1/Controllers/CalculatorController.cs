using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap1.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TinhToan()
        {
            var a = 0.0;
            var b = 0.0;

            string calOperator = "+";

            if (Request["text_number_a"] != null)
            {
                a = double.Parse(Request["text_number_a"]);
            }

            if (Request["text_number_b"] != null)
            {
                b = double.Parse(Request["text_number_b"]);
            }

            if (Request["phep_tinh"] != null)
            {
                calOperator = Request["phep_tinh"];
            }

            switch (calOperator)
            {
                case "+":
                    ViewBag.KetQua = a + b;
                    break;
                case "-":
                    ViewBag.KetQua = a - b;
                    break;
                case "*":
                    ViewBag.KetQua = a * b;
                    break;
                case "/":
                    if (b == 0) ViewBag.KetQua = "Không chia được cho 0";
                    else ViewBag.KetQua = a / b;
                    break;
                default:
                    break;
            }
            return View();
        }
    }

}