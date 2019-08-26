using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAr3.Models;
using System.Data.Entity;

namespace ProjetoAr3.Controllers
{
    
    public class ArCondicionadosController : Controller
    {
        private contexto db = new contexto();
        // GET: ArCondicionados
        public ActionResult Index()
        {
            ViewBag.categoria = db.CategoriaDoProdutos.ToList();
            ViewBag.produtosl = db.Produtos.Include(p => p.Categoria).ToList();
            return View();
        }
    }
}