using Bai4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4.Controllers
{
    public class EmployeeManagementController : Controller
    {
        // GET: EmployeeManagement
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        //tạo view sử dụng helper
        [HttpGet]
        public ActionResult Input()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CalSalaryV1()
        //Action này nhận dữ liệu nhập và xử lý
        {
            string id = Request["id"];
            string name = Request["name"];
            int amount = int.Parse(Request["amount"]);
            double salary = double.Parse(Request["salary"]);
            Employee e = new Employee(id, name, amount, salary);
            return View(e);
        }

        //xử lí form theo cách 2
        [HttpPost]
        public ActionResult CalSalaryV2(string id, string name, int amount, double salary)
        {
            Employee e = new Employee(id, name, amount, salary);
            return View("CalSalaryV1",e);
            //trả về view là view hiển thị đã có
            //(dùng chung 1 view)
            //và gửi đi đối tượng e( là đối tượng employee vừa tạo)
        }


        //xử lí form theo cách 3
        [HttpPost]
        public ActionResult CalSalaryV3(Employee emp)
        {
            return View("CalSalaryV1", emp);
        }

        //cách 4
        [HttpPost]
        public ActionResult CalSalaryV4(FormCollection form)
        {
            Employee e = new Employee();
            e.id = form["id"];
            e.name = form["name"];
            e.amount = int.Parse(form["amount"]);
            e.salary = double.Parse(form["salary"]);
            return View("CalSalaryV1", e);
        }
    }
}