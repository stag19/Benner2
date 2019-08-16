using ProjetoAr3.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoAr3.Controllers
{
    [AutorizacaoFilter]
    public class ContadorController : Controller
    {
        // GET: Contador
        public ActionResult Index()
        {
            object valorNaSession = Session["contador"];
            int contador = Convert.ToInt32(valorNaSession);
            contador++;
            Session["contador"] = contador;
            return View(contador);
        }
    }
}