using ProjetoAr3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoAr3.Controllers
{
    public class LojaController : Controller
    {
        private contexto db = new contexto();
        // GET: Loja
        public ActionResult Index()
        {
            ViewBag.categoria = db.CategoriaDoProdutos.ToList();
          
            return View();
        }
    }
}
 
               