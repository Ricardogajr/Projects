using App.DAO;
using App.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string nome;
            string senha;
            string email;

            UsuarioDAO userDAO = new UsuarioDAO();
            /*
            Console.WriteLine("*****************************************");
            Console.WriteLine("Bem vindo - Por favor, cadastre o usuario");
            Console.WriteLine("*****************************************");

            Console.WriteLine("Digite o Nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o Email");
            email = Console.ReadLine();

            Console.WriteLine("Digite o Senha");
            senha = Console.ReadLine();
            */


            Console.WriteLine("*****************************************");
            Console.WriteLine("Bem vindo - Por favor, Busque o usuario");
            Console.WriteLine("*****************************************");

            Console.WriteLine("Digite o id do Usuario");
            int id = Convert.ToInt32(Console.ReadLine());

            /*
                        Usuario user = new Usuario()
                        {
                            Nome = nome,
                            Senha = senha,
                            Email = email,

                        };
                        userDAO.Salvar(user);
                        */
            Usuario user = userDAO.Buscar(id);

            Console.WriteLine("Nome: " + user.Nome + " Email: " + user.Email + " FOI DELETADO ");
            //userDAO.Remover(user);

            Console.WriteLine("Digite o id do Usuario");
            nome = Console.ReadLine();
            userDAO.Alterar(id, nome);
            Console.ReadLine();

        }
    }
}
