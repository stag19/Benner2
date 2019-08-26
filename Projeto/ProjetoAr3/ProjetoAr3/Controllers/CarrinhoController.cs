using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoAr3.Models;
using System.Web.Mvc;

namespace ProjetoAr3.Controllers
{
    public class CarrinhoController : Controller
    {
        private contexto db = new contexto();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdicionarProdutoAoCarrinho(cliente cliente, produtos produto)
        {
            //Verifica se tem um carrinho relacionado a esse cliente que clicou
         
            //Se não tiver nenhum carrinho relacionado a esse cliente, cria um carrinho novo e coloca o produto dentro dele
            //Se já tiver ele apenas coloca o produto no carrinho


            return View();
        }

        public ActionResult DeletarProdutoDoCarrinho()
        {
            //Acha o carrinho do cliente que clicou, acha o produto e apaga ele do carrinho
            return View();
        }

        public ActionResult FinalizarPedido()
        {
            //Pega o carrinho atual do cliente e passa as informações para uma tabela de Pedidos
            //Exclui o carrinho atual e diminui os produtos pedidos do estoque
            return View();
        }
    }
}
