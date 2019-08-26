using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAr3.DAO;
using ProjetoAr3.Filtros;
using ProjetoAr3.Models;

namespace ProjetoAr3.Controllers
{

    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (TempData["ViewData"] != null)
            {
                ViewData = (ViewDataDictionary)TempData["ViewData"];
              
            }
            return View();
        }
        public ActionResult Autentica(String login, String senha)
        {
            UsuariosDAO dao = new UsuariosDAO();
            Usuario usuario = dao.Busca(login, senha);
            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Usuário ou senha inválidos, tente novamente!");
                TempData["ViewData"] = ViewData;
                return RedirectToAction("Index");
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}