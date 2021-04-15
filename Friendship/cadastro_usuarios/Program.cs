using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_usuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Usuario> ListaUsurios;
            ListaUsurios = new List<Usuario>();
            string opcao = "1";

            while (opcao == "1") 
            {
                Usuario usuario = new Usuario();
                
                Console.WriteLine("Escreva seu nome:");
                usuario.nome = Console.ReadLine();
                Console.WriteLine("Escreva seu sobrenome:");
                usuario.sobrenome = Console.ReadLine();

                Console.WriteLine("O nome cadastrado foi: " + usuario.juntarNome());
                
                ListaUsurios.Add(usuario);
                Console.WriteLine("Usuário adicionado a lista");

                Console.WriteLine("Deseja inserir outro nome? 1-SIM | 2-NÃO");
                opcao = Console.ReadLine();
            }

            Console.WriteLine("A lista tem: " + ListaUsurios.Count + " itens:");


            Console.ReadLine();


            



        }
    }
}
