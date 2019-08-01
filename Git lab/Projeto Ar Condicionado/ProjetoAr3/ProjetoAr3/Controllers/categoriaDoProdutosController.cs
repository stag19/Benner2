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
    public class categoriaDoProdutosController : Controller
    {
        private contexto db = new contexto();

        // GET: categoriaDoProdutos
        public ActionResult Index()
        {
       
            return View(db.CategoriaDoProdutos.ToList());
            
        }

        // GET: categoriaDoProdutos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categoriaDoProduto categoriaDoProduto = db.CategoriaDoProdutos.Find(id);
            if (categoriaDoProduto == null)
            {
                return HttpNotFound();
            }
            return View(categoriaDoProduto);
        }

        // GET: categoriaDoProdutos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: categoriaDoProdutos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome")] categoriaDoProduto categoriaDoProduto)
        {
            if (ModelState.IsValid)
            {
                db.CategoriaDoProdutos.Add(categoriaDoProduto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaDoProduto);
        }

        // GET: categoriaDoProdutos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categoriaDoProduto categoriaDoProduto = db.CategoriaDoProdutos.Find(id);
            if (categoriaDoProduto == null)
            {
                return HttpNotFound();
            }
            return View(categoriaDoProduto);
        }

        // POST: categoriaDoProdutos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome")] categoriaDoProduto categoriaDoProduto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaDoProduto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaDoProduto);
        }

        // GET: categoriaDoProdutos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categoriaDoProduto categoriaDoProduto = db.CategoriaDoProdutos.Find(id);
            if (categoriaDoProduto == null)
            {
                return HttpNotFound();
            }
            return View(categoriaDoProduto);
        }

        // POST: categoriaDoProdutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            categoriaDoProduto categoriaDoProduto = db.CategoriaDoProdutos.Find(id);
            db.CategoriaDoProdutos.Remove(categoriaDoProduto);
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
