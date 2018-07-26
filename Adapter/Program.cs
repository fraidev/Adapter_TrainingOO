using System;
using Adapter.Domain;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var nobreak = new Nobreak();
            var computador = new Computador();

            var adaptadorBrParaUs = new AdaptadorBrParaUs();
            
            computador.Pluga(adaptadorBrParaUs.Adaptar(nobreak));

            Console.WriteLine("Hello World!");
        }
    }
}
