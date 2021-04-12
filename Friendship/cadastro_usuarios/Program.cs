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
            string nome = Console.ReadLine();
            Console.WriteLine("O nome cadastrado foi: " + nome);
            Console.ReadLine();
        }
    }
}
