using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using De2.Models;

namespace De2.Controllers
{
    public class QuanLySanphamController : Controller
    {
        private List<Sanpham> danhsach = new List<Sanpham>();
        public QuanLySanphamController()
        {
            danhsach.Add(new Sanpham("S01", "San pham 1", 10, 100, 0));
            danhsach.Add(new Sanpham("S02", "San pham 2", 20, 120, 1));
            danhsach.Add(new Sanpham("S03", "San pham 3", 15, 200, 1));
            danhsach.Add(new Sanpham("S04", "San pham 4", 30, 150, 0));
            danhsach.Add(new Sanpham("S05", "San pham 5", 20, 50, 1));
        }

        public ActionResult HienThiDS()
        {
            List<Sanpham> li1 = new List<Sanpham>();
            List<Sanpham> li2 = new List<Sanpham>();
            foreach(var item in danhsach)
            {
                if (item.giatien > 100) li1.Add(item);
                if (item.giamgia == 1) li2.Add(item);
            }
            ViewBag.li1 = li1;
            ViewBag.li2 = li2;
            return View(danhsach);
        }
        // GET: QuanLySanpham
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display(Sanpham sp)
        {
            return View(sp);
        }
    }
}