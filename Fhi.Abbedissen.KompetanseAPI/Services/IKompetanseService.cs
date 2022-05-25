using Fhi.Abbedissen.KompetanseAPI.Model; 

namespace Fhi.Abbedissen.KompetanseAPI.Services
{
    public interface IKompetanseService
    {
        IEnumerable<Kompetanse> HentKompetanse();
        Kompetanse HentKompetanse(int id);
        void LeggTilKompetanse(Kompetanse kompetanse);
    }
}
