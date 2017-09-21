using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers
{
    public class SupliersController : Controller
    {
        private LacacaContext db = new LacacaContext();

        // GET: Supliers
        public ActionResult Index()
        {
            return View(db.Supliers.ToList());
        }

        // GET: Supliers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suplier suplier = db.Supliers.Find(id);
            if (suplier == null)
            {
                return HttpNotFound();
            }
            return View(suplier);
        }

        // GET: Supliers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supliers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SuplierId,SuplierName,SuplierAddress,SuplierDescription")] Suplier suplier)
        {
            if (ModelState.IsValid)
            {
                db.Supliers.Add(suplier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(suplier);
        }

        // GET: Supliers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suplier suplier = db.Supliers.Find(id);
            if (suplier == null)
            {
                return HttpNotFound();
            }
            return View(suplier);
        }

        // POST: Supliers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SuplierId,SuplierName,SuplierAddress,SuplierDescription")] Suplier suplier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(suplier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(suplier);
        }

        // GET: Supliers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suplier suplier = db.Supliers.Find(id);
            if (suplier == null)
            {
                return HttpNotFound();
            }
            return View(suplier);
        }

        // POST: Supliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Suplier suplier = db.Supliers.Find(id);
            db.Supliers.Remove(suplier);
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
