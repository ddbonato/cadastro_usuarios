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
            int opcao;

            do
            {
                opcao = SelecionarOpcao();
                switch (opcao)
                {
                    case 1:
                        ListaUsurios.Add(ObterNovoUsuario());
                        break;
                    case 2:
                        
                        break;
                }

            } while(opcao != 3 );

        }

        private static int SelecionarOpcao() 
        {
            Console.WriteLine("1 - Cadastrar Usuário");
            Console.WriteLine("2 - Listar Usuários");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("Digite sua opção: ");
            var opcao = Console.ReadLine();
            var opcaoint = Int32.Parse(opcao);
            return opcaoint;
        }

        private static Usuario ObterNovoUsuario()
        {
            Console.WriteLine("Escreva seu nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Escreva seu sobrenome:");
            var sobrenome = Console.ReadLine();

            Usuario usuario = new Usuario(nome, sobrenome);
            return usuario;
        }

        private static void ListarUsuario(List<Usuario> lista)
        {
            Console.WriteLine("Listando os usuários: ");

            foreach (var item in ListaUsuarios)
            {
                Console.WriteLine(Usuario);
            }
            
        }
    }
}
