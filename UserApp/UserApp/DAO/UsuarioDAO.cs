using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Entidade;

namespace UserApp.DAO
{
    public class UsuarioDAO
    {   private EntidadeContext contexto;
        public UsuarioDAO()
        {
            contexto = new EntidadeContext();
        }

        public void Salvar(Usuario user)
        {
            try
            {
                contexto.Usuarios.Add(user);
                contexto.SaveChanges();
                contexto.Dispose();
            }
            catch {
                throw new Exception();
            }
        }

        public  IList<Usuario> Listar()
        {
            var users = from u in contexto.Usuarios select u;

            return users.ToList();
        }
    }
}
