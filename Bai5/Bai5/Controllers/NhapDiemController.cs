using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai5.Models;
namespace Bai5.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(SinhVien sv)
        {//Đường dẫn tới file dữ liệu
            string path = Server.MapPath("~/StudentInfo.txt");
            //Khai báo 1 mảng kiểu xâu kí tự
            string[] lines = { sv.Id, sv.Name, sv.Mark.ToString() };
            //Ghi thông tin vào file
            System.IO.File.WriteAllLines(path, lines);
            ViewBag.HanhDong = "Đã ghi từ file";
            //Trả về view Index
            return View("Index");
        }

        public ActionResult Open(SinhVien sv)
        {//Đường dẫn tới file lưu dữ liệu
            string path = Server.MapPath("~/StudentInfo.txt");
            //Đọc file vào 1 mảng kiểu xâu kí tự
            string[] lines = System.IO.File.ReadAllLines(path);
            //Gán giá trị cho Model
            sv.Id = lines[0];
            sv.Name = lines[1];
            sv.Mark = Convert.ToDouble(lines[2]);
            //Thoogn tin đọc được
            ViewBag.ThongTin = "Ma sv: " + sv.Id + " - Ho ten: " + sv.Name + " - Diem: " + sv.Mark;
            ViewBag.HanhDong = "Đã đọc từ file";
            //Trả về view Index
            return View("Index",sv);
        }
    }
}