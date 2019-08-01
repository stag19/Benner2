using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoAr3.Models
{
    public class funcionario
    {
        [Key]
        public int Id { get; set; }

        public Usuario usuario { get; set; }

        public int Usuarioid { get; set; }

        public string Email { get; set; }



  
        public string Cpf { get; set; }
    }
}
