using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnTapTX2.Models;

namespace OnTapTX2.Controllers
{
    public class ObjectsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Objects
        public ActionResult Xemdanhsach(string SearchString)
        {
            var trangsucs = db.Trangsucs.Include(t => t.Danhmuc);
            if (!String.IsNullOrEmpty(SearchString))
            {
                int searchInt = int.Parse(SearchString);
                trangsucs = trangsucs.Where(p => p.Giatien > searchInt);
                //trangsucs = trangsucs.Where(p => p.TenTs.Contains(SearchString));
            }
            return View(trangsucs.ToList());
        }

        // GET: Objects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trangsuc trangsuc = db.Trangsucs.Find(id);
            if (trangsuc == null)
            {
                return HttpNotFound();
            }
            return View(trangsuc);
        }

        // GET: Objects/Create
        public ActionResult ThemDulieu()
        {
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc");
            return View();
        }

        // POST: Objects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemDulieu([Bind(Include = "MaTs,TenTs,Anh,Mota,Soluong,Giatien,MaDanhmuc")] Trangsuc trangsuc)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    trangsuc.Anh = "";
                    var f = Request.Files["AnhFile"];
                    if (f != null && f.ContentLength > 0)
                    {
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        Console.WriteLine(FileName);
                        string UploadPath = Server.MapPath("~/Content/Images/" + FileName);
                        f.SaveAs(UploadPath);
                        trangsuc.Anh = FileName;
                    }

                    db.Trangsucs.Add(trangsuc);
                    db.SaveChanges();
                }
                return RedirectToAction("Xemdanhsach");

            }
            catch (Exception ex)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu" + ex.Message;
                ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", trangsuc.MaDanhmuc);
                return View(trangsuc);
            }


        }

        // GET: Objects/Edit/5
        public ActionResult Suadulieu(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trangsuc trangsuc = db.Trangsucs.Find(id);
            if (trangsuc == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", trangsuc.MaDanhmuc);
            return View(trangsuc);
        }

        // POST: Objects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Suadulieu([Bind(Include = "MaTs,TenTs,Anh,Mota,Soluong,Giatien,MaDanhmuc")] Trangsuc trangsuc)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var f = Request.Files["AnhFile"];
                    if (f != null && f.ContentLength > 0)
                    {
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        Console.WriteLine(FileName);
                        string UploadPath = Server.MapPath("~/Content/Images/" + FileName);
                        f.SaveAs(UploadPath);
                        trangsuc.Anh = FileName;
                    }
                    db.Entry(trangsuc).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Xemdanhsach");
            }
            catch (Exception e)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu" + e;
                ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", trangsuc.MaDanhmuc);
                return View(trangsuc);
            }
        }

        // GET: Objects/Delete/5
        public ActionResult XoaDuLieu(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trangsuc trangsuc = db.Trangsucs.Find(id);
            if (trangsuc == null)
            {
                return HttpNotFound();
            }
            return View(trangsuc);
        }

        // POST: Objects/Delete/5
        [HttpPost, ActionName("XoaDuLieu")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            
            Trangsuc trangsuc = db.Trangsucs.Find(id);
            try
            {
                db.Trangsucs.Remove(trangsuc);
                db.SaveChanges();
                return RedirectToAction("Xemdanhsach");
            }catch(Exception ex)
            {
                ViewBag.Error = "Không xóa được bản ghi này" + ex;
                return View("XoaDuLieu", trangsuc);
            }

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
