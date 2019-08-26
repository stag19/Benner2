using ProjetoAr3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace ProjetoAr3.Controllers
{
    public class FerramentasController : Controller
    {
        private contexto db = new contexto();
        // GET: Ferramentas
        public ActionResult Index()
        {
            ViewBag.categoria = db.CategoriaDoProdutos.ToList();
            ViewBag.produtosl = db.Produtos.Include(p => p.Categoria).ToList();
            return View();
        }
    }
}