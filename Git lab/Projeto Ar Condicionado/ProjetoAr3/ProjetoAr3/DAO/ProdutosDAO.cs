using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoAr3.Models;

namespace ProjetoAr3.DAO
{
    public class ProdutosDAO
    {
        public void Adiciona(Produto produto)
        {
            using (var contexto = new contexto())
            {
                contexto.Produtos.Add(produto);
                contexto.SaveChanges();
            }
        }

        public IList<Produto> Lista()
        {
            using (var contexto = new contexto())
            {
                return contexto.Produtos.Include("Categoria").ToList();
            }
        }

        public Produto BuscaPorId(int id)
        {
            using (var contexto = new contexto())
            {
                return contexto.Produtos.Include("Categoria")
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
            }
        }

        public void Atualiza(Produto produto)
        {
            using (var contexto = new contexto())
            {
                contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}