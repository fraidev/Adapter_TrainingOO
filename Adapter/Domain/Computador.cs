using System;
using System.Linq;

namespace Adapter.Domain
{
    public class Computador:IPlugBrasileiro
    {
        public bool Plugado { get; set; } = false;
        
        public void Pluga(IEntradaBrasileira entrada)
        {
            //entrada.EntradaDeTomada = true;
            Plugado = true;
        }
    }
}