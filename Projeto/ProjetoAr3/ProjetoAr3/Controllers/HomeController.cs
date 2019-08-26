using ProjetoAr3.Filtros;
using ProjetoAr3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoAr3.Controllers
{
   
    public class HomeController : Controller
    {
        private contexto db = new contexto();
     
        public ActionResult Index()
        {
            ViewBag.categoria = db.CategoriaDoProdutos.ToList();


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}