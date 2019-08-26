using ProjetoAr3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace ProjetoAr3.Controllers
{
    public class LojaController : Controller
    {
        private contexto db = new contexto();
       
        // GET: Loja
        public ActionResult Index()
        {
            ViewBag.produtosl = db.Produtos.Include(p => p.Categoria).ToList();
            ViewBag.categoria = db.CategoriaDoProdutos.ToList();
          
            return View();
        }
    }
}
 
               