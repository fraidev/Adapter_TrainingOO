using System;
using Adapter.Domain;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var energia = new Energia();
            energia.LigarLuz();
            
            var nobreak = new Nobreak();
            nobreak.LigarNa(energia);
            
            var adaptadorBrParaUs = new AdaptadorBrParaUs();
            
            var computador = new Computador();
                
            computador.Pluga(adaptadorBrParaUs.Pluga(nobreak));
            
        }
    }
}
