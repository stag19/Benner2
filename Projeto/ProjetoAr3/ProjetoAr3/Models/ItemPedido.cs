using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoAr3.Models
{
    public class ItemPedido
    {
        [Key]
        public Guid ItemPedidoID { get; set; }

        public int ProdutoID { get; set; }
        public virtual produtos Produto { get; set; }

        public int PedidoID { get; set; }
        public virtual Pedido Pedido { get; set; }

        public int Qtd { get; set; }
    }
}