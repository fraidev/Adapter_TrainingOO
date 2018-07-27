namespace Adapter.Domain
{
    public interface IPlugBrasileiro
    {
        bool Plugado { get; set; }
        void PlugarNo(IEntradaBrasileira entrada);
        Energia Energia { get; set; }
    }
}