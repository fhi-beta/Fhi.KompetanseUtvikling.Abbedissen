using Fhi.Abbedissen.UtviklerAPI.DTO;
using Fhi.Abbedissen.UtviklerAPI.Model;

namespace Fhi.Abbedissen.UtviklerAPI.Services
{
    public class UtviklerService : IUtviklerService
    {
        private List<Utvikler> _Utviklere;

        public UtviklerService()
        {
            _Utviklere = new List<Utvikler>();
            _Utviklere.Add(new Utvikler() { Id = 1, Fornavn = "Per", Etternavn = "Askeladd", Opprettet=DateTime.Now });
            _Utviklere.Add(new Utvikler() { Id = 2, Fornavn = "Pål", Etternavn = "Askeladd", Opprettet = DateTime.Now });
            _Utviklere.Add(new Utvikler() { Id = 3, Fornavn = "Espen", Etternavn = "Askeladd", Opprettet = DateTime.Now });
            _Utviklere.Add(new Utvikler() { Id = 4, Fornavn = "Gunnar", Etternavn = "Askeladd", Opprettet = DateTime.Now });
        }

        public Utvikler? HentUtvikler(int id)
        {
            var resultat = _Utviklere.FirstOrDefault(x => x.Id == id);
            if (resultat == null) return null;
            return resultat;
        }

        public IEnumerable<Utvikler> HentUtviklere()
        {
            return _Utviklere;
        }

        public void LeggTilUtvikler(Utvikler utvikler)
        {
            _Utviklere.Add(utvikler);
        }
    }
}
