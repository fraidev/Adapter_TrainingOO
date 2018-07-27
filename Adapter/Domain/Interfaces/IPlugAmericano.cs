namespace Adapter.Domain
{
    public interface IPlugAmericano
    {
        bool Plugado { get; set; }
        void PlugarNo(IEntradaAmericana entrada);
        Energia Energia { get; set; }
    }
}