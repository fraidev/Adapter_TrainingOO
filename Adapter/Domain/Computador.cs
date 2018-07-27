using System;
using System.Linq;

namespace Adapter.Domain
{
    public class Computador:IPlugBrasileiro
    {
        public bool Plugado { get; set; }
        public bool Luz { get; set; }
        public bool Ligado { get; set; } 
        
        public void PlugarNo(IEntradaBrasileira entrada)
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