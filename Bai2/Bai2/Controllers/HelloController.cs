using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "Đây là phương thức mặc định của 1 controller";
        //}
        //public string ChaoMung()
        //{
        //    return "Đây là phương thức chào mừng";
        //}

        //public string ChaoMung(string ten, int solan = 1)
        //{
        //    return ("Xin chao " + ten + " so lan la : "+ solan );
        //}

        //public string ChaoMung(string ten, int id)
        //{
        //    return ("Xin chao " + ten + " id : " + id);
        //}
    }
}