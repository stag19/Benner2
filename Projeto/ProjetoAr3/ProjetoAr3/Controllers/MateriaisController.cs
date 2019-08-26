using ProjetoAr3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace ProjetoAr3.Controllers
{
    public class MateriaisController : Controller
    {
        private contexto db = new contexto();
        // GET: Materiais
        public ActionResult Index()
        {
            ViewBag.produtosl = db.Produtos.Include(p => p.Categoria).ToList();
            ViewBag.categoria = db.CategoriaDoProdutos.ToList();
            return View();
        }
    }
}