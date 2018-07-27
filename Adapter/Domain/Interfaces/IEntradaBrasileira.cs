namespace Adapter.Domain
{
    public interface IEntradaBrasileira
    {
        bool EntradaDeTomada { get; set; } 
        Energia Energia { get; set; }
    }
}