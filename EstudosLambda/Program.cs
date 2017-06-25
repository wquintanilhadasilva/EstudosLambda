using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosLambda
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] itens = { "jkl", "def", "abc", "ghi", "74770-390" };

            List<String> lista = itens.ToList();

            lista.ForEach(Console.WriteLine);

            Console.WriteLine();

            lista.Sort();

            lista.ForEach(Console.WriteLine);

            lista.ForEach(s => s.Equals("sss"));


            IList<Usuario> usuarios = UsuarioFactory.makeUsers();

            Array.ForEach(usuarios.Select(u => u.Pontos > 160).ToArray(), Console.WriteLine);

            var u1 = usuarios.Select(u => u.Pontos > 160);

            Array.ForEach(u1.ToArray(), e => Console.WriteLine(e));

            Console.ReadKey();
    
        }
    }

    class UsuarioFactory
    {

        public static IList<Usuario> makeUsers()
        {

            IList<Usuario> retorno = new List<Usuario>();

            retorno.Add(new Usuario { Nome = "Pedro Pereira", Pontos = 120, Supervisor = false });
            retorno.Add(new Usuario { Nome = "Manoel Gonçalves", Pontos = 140, Supervisor = false });
            retorno.Add(new Usuario { Nome = "Geraldo Magela", Pontos = 160, Supervisor = false });
            retorno.Add(new Usuario { Nome = "Abel dos Santos", Pontos = 190, Supervisor = false });

            return retorno;

        }

    }

    class Usuario
    {
        public String Nome {get; set;}

        public bool Supervisor { get; set; }

        public int Pontos { get; set; }
    }
}
