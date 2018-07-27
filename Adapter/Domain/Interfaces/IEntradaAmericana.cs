using System.Collections.Generic;

namespace Adapter.Domain
{
    public interface IEntradaAmericana
    {
        bool EntradaDeTomada { get; set; }
        bool EntregaLuz { get; set; }
    }
}