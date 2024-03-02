using baitap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap2.Controllers
{
    public class Cau2Controller : Controller
    {
        // GET: Cau2
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Output()
        {
            var TenChuHo = Request["textHoTen"];
            var HoUuTien = Request["chkHoUuTien"];
            var LoadDien = Request["dropDownLoaiDien"];
            var chiSoCu = Request["textChiSoCu"];
            var chiSoMoi = Request["textChiSoMoi"];

            TienDien tienDien = new TienDien(TenChuHo);
            tienDien.Calculate(Convert.ToDouble(chiSoCu), Convert.ToDouble(chiSoMoi), LoadDien, HoUuTien);

            return View(tienDien);
        }
    }
}