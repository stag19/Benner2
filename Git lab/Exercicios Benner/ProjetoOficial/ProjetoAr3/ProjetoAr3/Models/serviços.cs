using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoAr3.Models
{
    public class serviços
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Serviço { get; set; }
        [Required]
        [ConcurrencyCheck]
        [MaxLength(10, ErrorMessage = "Limite de 10 Caracteres alcançado")]
        public string Preço { get; set; }
    }
}