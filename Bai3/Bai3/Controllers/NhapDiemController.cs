using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai3.Models;

namespace Bai3.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            //Truyền DL từ Controller sang View sử dụng ViewBag/ViewData
            ViewBag.Id = "SV001";
            ViewBag.name = "Nguyễn Anh Tuấn";
            ViewData["Mark"] = 9.5;
            return View();
        }

        public ActionResult Detail2(SinhVien sv)
        {
            //Truyền DL từ Controller sang View sử dụng Model
            sv.Id = "SV001";
            sv.Name = "Nguyễn Anh Tuấn";
            sv.Marks = 9.5;
            //Truyền đối tượng sv cho View
            return View(sv);
        }
    }
}