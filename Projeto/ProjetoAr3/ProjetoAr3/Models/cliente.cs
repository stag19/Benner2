using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoAr3.Models
{
    public class cliente
    {
        [Key]
        public int Id { get; set; }

        
        public Usuario usuario { get; set; }

        public int Usuarioid { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Cpf { get; set; }

        public carrinho carrinho { get; set; }
        public int? CarrinhoId { get; set; }
    }
}