using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ProjetoAr3.Models;

namespace ProjetoAr3.Controllers
{
    public class PeçasController : Controller
    {
        private contexto db = new contexto();
        // GET: Peças
        public ActionResult Index()
        {
          
            ViewBag.produtosl = db.Produtos.Include(p => p.Categoria).ToList();
            ViewBag.categoria = db.CategoriaDoProdutos.ToList();
            return View();
        }
    }
}