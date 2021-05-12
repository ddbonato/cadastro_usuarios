using System.Collections.Generic;
namespace CSharp_ListaObjetos.Services
{
    class ListaUsuario
    {
        public static List<Usuario> ListaUsuarios()
        {
            var lstaUsuario = new List<Usuario>()
            {
                new Livro { LivroId=1,Titulo="ASP, ADO e Banco de dados na web",Autor="Macoratti", ISBN="8585943963"},
                new Livro { LivroId=2,Titulo="ASP - Aprenda Rápido",Autor="Macoratti", ISBN="8585845214"}
            };
            return lstaUsuario;
        }
    }
}