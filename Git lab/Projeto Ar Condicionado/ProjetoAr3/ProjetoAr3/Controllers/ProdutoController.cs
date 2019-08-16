using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAr3.DAO;
using ProjetoAr3.Models;
using ProjetoAr3.Controllers;

namespace ProjetoAr3.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {
            ProdutosDAO dao = new ProdutosDAO();
            IList<Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Adiciona(Produto produto)
        {
            
            ProdutosDAO dao = new ProdutosDAO();
            dao.Adiciona(produto);
            return View();
        }
    }
}