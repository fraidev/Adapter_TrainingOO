using System;

namespace Adapter.Domain
{
    public class AdaptadorBrParaUs:IEntradaBrasileira, IPlugAmericano
    {
        public bool Plugado { get; set; } 
        public bool EntradaDeTomada { get; set; }
        public Energia Energia { get; set; }

        public AdaptadorBrParaUs()
        {
            Energia = new Energia {Luz = false};
        }

        public void PlugarNo(IEntradaAmericana entrada)
        {
            if (entrada.Energia.Luz)
            {
                Energia = entrada.Energia;
            }
            entrada.EntradaDeTomada = true;
            Plugado = true;
        }
    }
}