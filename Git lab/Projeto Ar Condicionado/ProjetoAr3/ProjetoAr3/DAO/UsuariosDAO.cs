using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoAr3.Models;

namespace ProjetoAr3.DAO
{
   
    public class UsuariosDAO
    {
        private contexto Contexto;
        public void Adiciona(Usuario usuario)
        {
            using (var Contexto = new contexto())
            {
                Contexto.Usuarios.Add(usuario);
                Contexto.SaveChanges();
            }
        }

        public IList<Usuario> Lista()
        {
            using (var Contexto = new contexto())
            {
                return Contexto.Usuarios.ToList();
            }
        }

        public Usuario BuscaPorId(int id)
        {
            using (var Contexto = new contexto())
            {
                return Contexto.Usuarios.Find(id);
            }
        }

        public void Atualiza(Usuario usuario)
        {
            using (var Contexto = new contexto())
            {
                Contexto.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                Contexto.SaveChanges();
            }
        }

        public Usuario Busca(string login, string senha)
        {
            using (var Contexto = new contexto())
            {
                return Contexto.Usuarios.FirstOrDefault(u => u.Nome == login && u.Senha == senha);
            }
        }
    }
}