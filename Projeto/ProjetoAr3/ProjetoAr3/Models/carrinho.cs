using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoAr3.Models
{
    public class carrinho
    {
        [Key]

        public int Id { get; set; }

        public produtos Produtos { get; set; }
        public int? ProdutosId { get; set; }
  
    
    }
}