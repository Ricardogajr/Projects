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
            Contexto = new EntidadeContext();
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

        public IList<Cliente> Listar()
        {
            var lista = from c in Contexto.Clientes select c ;            
            return lista.ToList();
        }

        public Cliente BuscaPorId(int id)
        {
            Cliente cliente = Contexto.Clientes.FirstOrDefault(c => c.ID == id);
            return cliente;
        }

        public void Deletar(int id)
        {
            Cliente ClienteADeletar = this.BuscaPorId(id);
            Contexto.Clientes.Remove(ClienteADeletar);
  
            Contexto.SaveChanges();
            Contexto.Dispose();
        }
    }
}
