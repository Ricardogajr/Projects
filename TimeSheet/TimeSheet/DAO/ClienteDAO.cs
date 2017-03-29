using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Entidade;

namespace TimeSheet.DAO
{
    public class ClienteDAO
    {
        private EntidadeContext Contexto;

        public ClienteDAO(){
            EntidadeContext Contexto = new EntidadeContext();
        }

        public void Salvar(Cliente cliente)
        {
            try
            {
                Contexto.Clientes.Add(cliente);
                Contexto.SaveChanges();
                Contexto.Dispose();
            }catch (Exception)
            {
                Console.WriteLine("Erro!");
            }
        }
    }
}
