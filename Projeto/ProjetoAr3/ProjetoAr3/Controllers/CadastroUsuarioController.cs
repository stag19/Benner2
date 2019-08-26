using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAr3.Filtros;


namespace ProjetoAr3.Controllers
{
    public class CadastroUsuarioController : Controller
    {
        [AutorizacaoFilter]
        // GET: CadastroUsuario
        public ActionResult Index()
        {
            return View();
        }
    }
}