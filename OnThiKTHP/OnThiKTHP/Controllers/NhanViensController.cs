using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnThiKTHP.Models;

namespace OnThiKTHP.Controllers
{
    public class NhanViensController : Controller
    {
        private Model1 db = new Model1();

        // GET: NhanViens
        public ActionResult Index()
        {
            var nhanViens = db.NhanViens.Include(n => n.Phong);
            return View(nhanViens.ToList());
        }


        //Sử dụng NhanVienController, viết các action method, partialview và sửa file _Layout.cshtml
        //sao cho khi chạy project, trên menu chỉ hiển thị các tên phòng lấy từ bảng Phong và mục Index; trong
        //đó Index link tới xem toàn bộ danh sách nhân viên ở câu 1 và tên phòng sẽ link tới action ở câu 5 phía
        //dưới.
        public PartialViewResult CategoryMenu() //nho la particalview
        {
            var li = db.Phongs.ToList();
            return PartialView(li);
        }

//        tạo các action và view để khi click vào một phòng ban
//        trên menu, danh sách nhân viên thuộc về phòng đó hiển thị ra màn hình
        [Route("NhanVienTheoPhong/{Maphong}")] //Định tuyến cho phương thức
        public ActionResult HienThiTheoPhong(int Maphong)
        {
            var list = db.NhanViens.Where(p => p.Maphong == Maphong).ToList();
            return View(list);
        }



        // GET: NhanViens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // GET: NhanViens/Create
        public ActionResult Create()
        {
            ViewBag.Maphong = new SelectList(db.Phongs, "Maphong", "Tenphong");
            return View();
        }

        // POST: NhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]  
        //Nhớ cmt dòng này nhé

//        thêm nhân viên sử dụng công nghệ Ajax,cập nhập một phần trang web: Khi click vào button “Save”
//        sẽ hiển thị thông báo thêm thành công hay không ngay ở phía dưới form nhập dữ liệu.
        public ActionResult Create( NhanVien nhanVien)
        {
            try
            {
                db.NhanViens.Add(nhanVien);
                db.SaveChanges();
                //trả về xâu Json nếu result = true
                return Json(new { result = true, JsonRequestBehavior.AllowGet });
            }
            catch (Exception er)
            {
                //trả về xâu Json nếu result = false, vì có lỗi không thêm được
                return Json(new { result = false, error = er.Message });
            }
        }

        // GET: NhanViens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.Maphong = new SelectList(db.Phongs, "Maphong", "Tenphong", nhanVien.Maphong);
            return View(nhanVien);
        }

        // POST: NhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Manv,Hoten,Tuoi,Diachi,Luong,Maphong")] NhanVien nhanVien)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(nhanVien).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.Maphong = new SelectList(db.Phongs, "Maphong", "Tenphong", nhanVien.Maphong);
        //    return View(nhanVien);
        //}


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(NhanVien nv)
        {
            try
            {
                var nhanVien = db.NhanViens.Find(nv.Manv);
                if(nhanVien == null)
                {
                    return Json(new { result = false, error = "Khong tim thay nhan vien" });
                }
                else
                {
                    nhanVien.Hoten = nv.Hoten;
                    nhanVien.Tuoi = nv.Tuoi;
                    nhanVien.Luong = nv.Luong;
                    nhanVien.Maphong = nv.Maphong;
                    nhanVien.Diachi = nv.Diachi;
                    db.SaveChanges();
                    return Json(new { result = true, JsonRequestBehavior.AllowGet });

                }
            }
            catch (Exception ex)
            {
                // Trả về xâu Json nếu result = false
                return Json(new { result = false, error = ex.Message });
            }
        }

        // GET: NhanViens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhanVien nhanVien = db.NhanViens.Find(id);
            db.NhanViens.Remove(nhanVien);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
