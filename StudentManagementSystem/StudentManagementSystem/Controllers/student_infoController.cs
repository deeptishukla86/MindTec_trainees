using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    [Authorize]
    public class student_infoController : Controller
    {
        private project_1Entities db = new project_1Entities();

        // GET: student_info
        public ActionResult Index()
        {
            var student_info = db.student_info.Include(s => s.userdetail);
            return View(student_info.ToList());
        }

        // GET: student_info/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student_info student_info = db.student_info.Find(id);
            if (student_info == null)
            {
                return HttpNotFound();
            }
            return View(student_info);
        }

        // GET: student_info/Create
        public ActionResult Create()
        {
            ViewBag.id = new SelectList(db.userdetails, "id", "userid");
            return View();
        }

        // POST: student_info/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,city,email,phone,department,year,physics,chemistry,mathematics,placement_status,company")] student_info student_info)
        {
            if (ModelState.IsValid)
            {
                db.student_info.Add(student_info);
                db.SaveChanges();
                return RedirectToAction("index");
            }

            ViewBag.id = new SelectList(db.userdetails, "id", "userid", student_info.id);
            return View(student_info);
        }

        // GET: student_info/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student_info student_info = db.student_info.Find(id);
            if (student_info == null)
            {
                return HttpNotFound();
            }
            ViewBag.id = new SelectList(db.userdetails, "id", "userid", student_info.id);
            return View(student_info);
        }

        // POST: student_info/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,city,email,phone,department,year,physics,chemistry,mathematics,placement_status,company")] student_info student_info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_info).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id = new SelectList(db.userdetails, "id", "userid", student_info.id);
            return View(student_info);
        }

        // GET: student_info/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student_info student_info = db.student_info.Find(id);
            if (student_info == null)
            {
                return HttpNotFound();
            }
            return View(student_info);
        }

        // POST: student_info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            student_info student_info = db.student_info.Find(id);
            db.student_info.Remove(student_info);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult placements(String placement_status)
        {
            var stu = db.student_info.ToList();
            var pla = stu.Where(s => s.placement_status == "placed"|| s.placement_status == "Placed");
            return View(pla);
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
