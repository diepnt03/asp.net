using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai6.Controllers
{
    public class ListDiemController : Controller
    {
        // GET: ListDiem
        public ActionResult Bullets()
        {
            return View();
        }

        public ActionResult Numbering()
        {
            return View();
        }
    }
}