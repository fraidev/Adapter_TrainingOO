using System.Collections.Generic;

namespace Adapter.Domain
{
    public interface IEntradaAmericana
    {
        bool EntradaDeTomada { get; set; }
        Energia Energia { get; set; }
    }
}