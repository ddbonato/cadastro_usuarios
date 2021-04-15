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
            Console.WriteLine("Escreva seu nome:");

            Usuario usuario = new Usuario();
            usuario.nome = Console.ReadLine();

            Console.WriteLine("Escreva seu sobrenome:");
            usuario.sobrenome = Console.ReadLine();

            Console.WriteLine("O nome cadastrado foi: " + usuario.juntarNome());
            Console.ReadLine();

            IList<Usuario> ListaUsurios;
            ListaUsurios = new List<Usuario>();
            
            //Adiciona usuário a lista
            ListaUsurios.Add(usuario);
            Console.WriteLine("Usuário adicionado a lista");
            Console.ReadLine();


        }
    }
}
