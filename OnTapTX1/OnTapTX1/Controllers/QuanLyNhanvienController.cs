using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnTapTX1.Models;

namespace OnTapTX1.Controllers
{
    public class QuanLyNhanvienController : Controller
    {
        private List<NhanVien> danhsach = new List<NhanVien>();
        // GET: QuanLyNhanvien
        public QuanLyNhanvienController()
        {
            danhsach.Add(new NhanVien("Nv01", "Nguyen Van Anh", "Ha Noi", 15, 200000));
            danhsach.Add(new NhanVien("Nv02", "Le Thu Ha", "Hai Phong", 27, 250000));
            danhsach.Add(new NhanVien("Nv03", "Nguyen Van Hoang", "Ha Noi", 18, 250000));
            danhsach.Add(new NhanVien("Nv04", "Tran Thu Huong", "Hai phong", 25, 190000));
            danhsach.Add(new NhanVien("Nv05", "Nho Phuong Thao", "Quang Ninh", 20, 180000));
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HienThiDS()
        {
            List<NhanVien> li1 = new List<NhanVien>();
            List<NhanVien> li2 = new List<NhanVien>();
            foreach(var item in danhsach)
            {
                if (item.songaylam < 20) li1.Add(item);
                if (item.luongngay > 190000) li2.Add(item);
            }
            ViewBag.li1 = li1;
            ViewBag.li2 = li2;
            return View(danhsach);
        }

        public ActionResult Display(NhanVien nv)
        {
            return View(nv);
        }
    }
}