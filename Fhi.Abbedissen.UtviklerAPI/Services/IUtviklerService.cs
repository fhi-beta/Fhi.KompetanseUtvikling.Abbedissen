using Fhi.Abbedissen.UtviklerAPI.Model;

namespace Fhi.Abbedissen.UtviklerAPI.Services;
    public interface IUtviklerService
    {
        IEnumerable<Utvikler> HentUtviklere();
        Utvikler HentUtvikler(int id);
        void LeggTilUtvikler(Utvikler utvikler);
    }

