using System;

namespace Adapter.Domain
{
    public class AdaptadorBrParaUs:IPlugAmericano
    {
        public bool Plugado { get; set; } = false;

        public IEntradaBrasileira Adaptar(IEntradaAmericana americana)
        {
            var adapter = americana as Object;
            return adapter as IEntradaBrasileira;
        }
    }
}