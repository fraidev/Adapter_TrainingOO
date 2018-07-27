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
            adaptadorBrParaUs.PlugarNo(nobreak);

            var computador = new Computador();
            computador.PlugarNo(adaptadorBrParaUs);
            computador.Ligar();


            computador.Calcula(2, 5);
        }
    }
}
