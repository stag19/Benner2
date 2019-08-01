using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProjetoAr3.Models
{
    public class contexto : DbContext
    {
        public DbSet<cliente> Clientes { get; set; }
        public DbSet<categoriaDoProduto> CategoriaDoProdutos { get; set; }
        public DbSet<produtos> Produtos { get; set; }
        public DbSet<serviços> Serviços { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

       


        public System.Data.Entity.DbSet<ProjetoAr3.Models.funcionario> funcionarios { get; set; }

        

        public contexto() : base("DefaultConnection")
        {

        }
    }
}