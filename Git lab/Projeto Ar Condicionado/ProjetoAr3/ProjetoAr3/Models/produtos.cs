using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoAr3.Models
{
    public class produtos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ConcurrencyCheck]
        [MaxLength(100, ErrorMessage = "Limite de 100 Caracteres alcançado")]
        public string Nome { get; set; }
        public categoriaDoProduto Categoria { get; set; }
        public int? CategoriaId { get; set; }
    }
}