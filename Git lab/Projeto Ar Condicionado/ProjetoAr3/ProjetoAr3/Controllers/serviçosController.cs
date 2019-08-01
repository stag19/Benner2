using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoAr3.Filtros;
using ProjetoAr3.Models;

namespace ProjetoAr3.Controllers
{
    [AutorizacaoFilter]
    public class serviçosController : Controller
    {
        private contexto db = new contexto();

        // GET: serviços
        public ActionResult Index()
        {
            return View(db.Serviços.ToList());
        }

        // GET: serviços/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            serviços serviços = db.Serviços.Find(id);
            if (serviços == null)
            {
                return HttpNotFound();
            }
            return View(serviços);
        }

        // GET: serviços/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: serviços/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Serviço,Preço")] serviços serviços)
        {
            if (ModelState.IsValid)
            {
                db.Serviços.Add(serviços);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serviços);
        }

        // GET: serviços/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            serviços serviços = db.Serviços.Find(id);
            if (serviços == null)
            {
                return HttpNotFound();
            }
            return View(serviços);
        }

        // POST: serviços/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Serviço,Preço")] serviços serviços)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviços).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serviços);
        }

        // GET: serviços/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            serviços serviços = db.Serviços.Find(id);
            if (serviços == null)
            {
                return HttpNotFound();
            }
            return View(serviços);
        }

        // POST: serviços/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            serviços serviços = db.Serviços.Find(id);
            db.Serviços.Remove(serviços);
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
