using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAr3.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public float Preco { get; set; }

        public categoriaDoProduto Categoria { get; set; }

        public int CategoriaId { get; set; }

        public String Descricao { get; set; }

        public int Quantidade { get; set; }
    }
}