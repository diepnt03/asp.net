using OnThiKTHP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnThiKTHP.Controllers
{
    public class LoginController : Controller
    {
//        Tạo các action và view cần thiết cho phép người dùng đăng nhập vào hệ thống.
//        Sử dụng bảng tblUser đã cho trong CSDL để kiểm tra người dùng có nhập đúng username và password hay không.
//          -Nếu nhập đúng thì hiển thị lời chào Welcome + username trên menu và xuất hiện link Logout bên cạnh
//           lời chào, đồng thời chuyển đến trang hiển thị toàn bộ danh sách ở câu 1. Nếu đăng nhập sai thì thông báo lỗi.
//          -Khi người dùng click vào link Logout thì đăng xuất khỏi hệ thống, trên menu không còn link Logout mà
//           thay vào đó là link Login
        private Model1 db = new Model1();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Login(string username, string password)
        {
            var user = db.tblUsers.Where(u => u.username == username && u.password == password).FirstOrDefault();
            if (user == null)
            {
                ViewBag.errMsg = "Sai ten dang nhap va mat khau";
                return View("Login");
            }
            else
            {
                Session["username"] = username;
                return RedirectToAction("Index", "Nhanviens");//chạy tới action Index
            }
        }
        public ActionResult Logout()
        {
            Session["username"] = null;
            return RedirectToAction("Index", "Nhanviens");
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }



    }
}