using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAr3.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }

        public Usuario Usuario { get; set; }
        public int? UsuarioId { get; set; }

        public Decimal Valor { get; set; }

        public Decimal ValorTotal { get; set; }
        public List<produtos> Produtos { get; set; }

        public int ProdutosId { get; set; }

    }
}