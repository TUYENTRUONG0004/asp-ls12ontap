using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tdt_lession12ontap.Models;

namespace Tdt_lession12ontap.Controllers
{
    public class Tdt_TACGIAController : Controller
    {
        private TruongDinhTuyen_2210900134Entities db = new TruongDinhTuyen_2210900134Entities();

        // GET: Tdt_TACGIA
        public ActionResult Index()
        {
            return View(db.Tdt_TACGIA.ToList());
        }

        // GET: Tdt_TACGIA/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tdt_TACGIA tdt_TACGIA = db.Tdt_TACGIA.Find(id);
            if (tdt_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(tdt_TACGIA);
        }

        // GET: Tdt_TACGIA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tdt_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Tdt_MaTG,Tdt_TenTacGia")] Tdt_TACGIA tdt_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Tdt_TACGIA.Add(tdt_TACGIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tdt_TACGIA);
        }

        // GET: Tdt_TACGIA/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tdt_TACGIA tdt_TACGIA = db.Tdt_TACGIA.Find(id);
            if (tdt_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(tdt_TACGIA);
        }

        // POST: Tdt_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Tdt_MaTG,Tdt_TenTacGia")] Tdt_TACGIA tdt_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tdt_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tdt_TACGIA);
        }

        // GET: Tdt_TACGIA/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tdt_TACGIA tdt_TACGIA = db.Tdt_TACGIA.Find(id);
            if (tdt_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(tdt_TACGIA);
        }

        // POST: Tdt_TACGIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tdt_TACGIA tdt_TACGIA = db.Tdt_TACGIA.Find(id);
            db.Tdt_TACGIA.Remove(tdt_TACGIA);
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
