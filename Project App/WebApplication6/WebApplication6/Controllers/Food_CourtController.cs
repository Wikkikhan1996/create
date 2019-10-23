using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class Food_CourtController : Controller
    {
        private MallManagementSystemDBContext db = new MallManagementSystemDBContext();

        // GET: Food_Court
        public ActionResult Index()
        {
            var food_Court = db.Food_Court.Include(f => f.Food_Categary);
            return View(food_Court.ToList());
        }

        // GET: Food_Court/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food_Court food_Court = db.Food_Court.Find(id);
            if (food_Court == null)
            {
                return HttpNotFound();
            }
            return View(food_Court);
        }

        // GET: Food_Court/Create
        public ActionResult Create()
        {
            ViewBag.C_ID = new SelectList(db.Food_Categary, "ID", "Name");
            return View();
        }

        // POST: Food_Court/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Image,C_ID")] Food_Court food_Court)
        {
            if (ModelState.IsValid)
            {
                db.Food_Court.Add(food_Court);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.C_ID = new SelectList(db.Food_Categary, "ID", "Name", food_Court.C_ID);
            return View(food_Court);
        }

        // GET: Food_Court/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food_Court food_Court = db.Food_Court.Find(id);
            if (food_Court == null)
            {
                return HttpNotFound();
            }
            ViewBag.C_ID = new SelectList(db.Food_Categary, "ID", "Name", food_Court.C_ID);
            return View(food_Court);
        }

        // POST: Food_Court/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Image,C_ID")] Food_Court food_Court)
        {
            if (ModelState.IsValid)
            {
                db.Entry(food_Court).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.C_ID = new SelectList(db.Food_Categary, "ID", "Name", food_Court.C_ID);
            return View(food_Court);
        }

        // GET: Food_Court/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food_Court food_Court = db.Food_Court.Find(id);
            if (food_Court == null)
            {
                return HttpNotFound();
            }
            return View(food_Court);
        }

        // POST: Food_Court/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Food_Court food_Court = db.Food_Court.Find(id);
            db.Food_Court.Remove(food_Court);
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
