using App.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAO
{
    public class UsuarioDAO
    {
        EntidadeContext contexto;

        public UsuarioDAO() {
            contexto = new EntidadeContext();
        }

        public void Salvar(Usuario user)
        {
            contexto.Usuarios.Add(user);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public Usuario Buscar(int ID)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.ID == ID);
        }

        public void Remover(Usuario user)
        {
            contexto.Usuarios.Remove(user);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Alterar(int ID,string nome)
        {
            Usuario user = this.Buscar(ID);
            user.Nome = nome;
            contexto.SaveChanges();
            contexto.Dispose();
        }
    }
}
