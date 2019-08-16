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
using ProjetoAr3.DAO;

namespace ProjetoAr3.Controllers
{
    [AutorizacaoFilter]
    public class produtosController : Controller
    {
        private contexto db = new contexto();

        // GET: produtos
        public ActionResult Index()
        {
     
            ViewBag.ad = "ok";
            var produtos = db.Produtos.Include(p => p.Categoria);
            return View(produtos.ToList());
        }

        // GET: produtos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produtos produtos = db.Produtos.Find(id);
            categoriaDoProduto categoriaDoProduto = db.CategoriaDoProdutos.Find(produtos.CategoriaId);
            ViewBag.NomeCategoria = categoriaDoProduto.Nome;

            if (produtos == null)
            {
                return HttpNotFound();
            }
            return View(produtos);
        }

        // GET: produtos/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(db.CategoriaDoProdutos, "Id", "Nome");
            return View();
        }

        // POST: produtos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Quantidade,Preço,CategoriaId,Imagem")] produtos produtos, HttpPostedFileBase imgEnviada)
        {
            if (ModelState.IsValid)
            {
                if(imgEnviada != null)
                {
                    produtos.Imagem = new byte[imgEnviada.ContentLength];
                    imgEnviada.InputStream.Read(produtos.Imagem, 0, imgEnviada.ContentLength);
                }
                db.Produtos.Add(produtos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(db.CategoriaDoProdutos, "Id", "Nome", produtos.CategoriaId);
            return View(produtos);
        }

        // GET: produtos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produtos produtos = db.Produtos.Find(id);
            if (produtos == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaId = new SelectList(db.CategoriaDoProdutos, "Id", "Nome", produtos.CategoriaId);
            return View(produtos);
        }

        // POST: produtos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,CategoriaId")] produtos produtos)
        {
            if (ModelState.IsValid)

            {
                db.Entry(produtos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaId = new SelectList(db.CategoriaDoProdutos, "Id", "Nome", produtos.CategoriaId);
            return View(produtos);
        }

        // GET: produtos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produtos produtos = db.Produtos.Find(id);

            categoriaDoProduto categoriaDoProduto = db.CategoriaDoProdutos.Find(produtos.CategoriaId);
            ViewBag.NomeCategoria = categoriaDoProduto.Nome;
            if (produtos == null)
            {
                return HttpNotFound();
            }
            return View(produtos);
        }

        // POST: produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            produtos produtos = db.Produtos.Find(id);
            db.Produtos.Remove(produtos);
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
