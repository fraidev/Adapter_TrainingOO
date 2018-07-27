using System;

namespace Adapter.Domain
{
    public class AdaptadorBrParaUs:IEntradaBrasileira, IPlugAmericano
    {
        public bool Plugado { get; set; } 
        public bool EntradaDeTomada { get; set; } = false;
        public bool Luz { get; set; }

        public IEntradaBrasileira Pluga(IEntradaAmericana entrada)
        {
            if (entrada.EntregaLuz)
            {
                Luz = true;
            }
            entrada.EntradaDeTomada = true;
            Plugado = true;
            var adapter = entrada as object;
            return adapter as IEntradaBrasileira;
        }
    }
}