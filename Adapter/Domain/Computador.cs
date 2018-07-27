using System;
using System.Linq;

namespace Adapter.Domain
{
    public class Computador:IPlugBrasileiro
    {
        public bool Plugado { get; set; }
        public bool BotaoLigado { get; set; }
        public Energia Energia { get; set; }

        public Computador()
        {
            Energia = new Energia {Luz = false};
        }
        
        public void PlugarNo(IEntradaBrasileira entrada)
        {
            if (entrada.Energia.Luz)
            {
                Energia = entrada.Energia;
            }
            entrada.EntradaDeTomada = true;
            Plugado = true;
        }

        public void LigarBotao()
        {
            if(Energia.Luz) BotaoLigado = true;
        }
        
        public void DesligarBotao()
        {
            BotaoLigado = false;
        }
        
        public double Calcula(double a, double b)
        {
            if (BotaoLigado&&Energia.Luz) return a + b;
            return 0;
        }
    }
}