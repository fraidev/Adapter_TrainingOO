using System;
using System.Linq;

namespace Adapter.Domain
{
    public class Computador:IPlugBrasileiro
    {
        public bool Plugado { get; set; } = false;
        public bool Luz { get; set; } = false;
        public bool Ligado { get; set; } = false;
        
        public void Pluga(IEntradaBrasileira entrada)
        {
            if (entrada.Luz) Luz = true;
            entrada.EntradaDeTomada = true;
            Plugado = true;
        }

        public void Ligar()
        {
            if(Luz) Ligado = true;
        }
        
        public void Desligar()
        {
            Ligado = false;
        }
        
        public double Calcula(double a, double b)
        {
            if (Ligado) return a + b;
            return 0;
        }
    }
}