using System;

namespace Adapter.Domain
{
    public class AdaptadorBrParaUs:IEntradaBrasileira, IPlugAmericano
    {
        public bool Plugado { get; set; } 
        public bool EntradaDeTomada { get; set; }
        public bool Luz { get; set; }

        public void PlugarNo(IEntradaAmericana entrada)
        {
            if (entrada.Luz)
            {
                Luz = true;
            }
            entrada.EntradaDeTomada = true;
            Plugado = true;
        }
    }
}