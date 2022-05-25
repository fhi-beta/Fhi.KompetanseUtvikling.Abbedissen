using Fhi.Abbedissen.KompetanseAPI.Model;

namespace Fhi.Abbedissen.KompetanseAPI.Services
{
    public interface IKompetanseService
    {
        IEnumerable<Kompetanse> HentKompetanse();
        void LeggTilKompetanse(Kompetanse kompetanse);
        Kompetanse HentKompetanse(Guid guid);
    }
}
