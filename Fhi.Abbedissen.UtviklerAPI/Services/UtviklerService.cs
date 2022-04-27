using Fhi.Abbedissen.UtviklerAPI.DTO;
using Fhi.Abbedissen.UtviklerAPI.Model;

namespace Fhi.Abbedissen.UtviklerAPI.Services
{
    public class UtviklerService : IUtviklerService
    {
        private static List<Utvikler> _Utviklere = new List<Utvikler>()

            {
                new Utvikler()
                {
                    Id = 1,
                    Fornavn = "Per",
                    Etternavn = "Askeladd",
                    Opprettet = DateTime.Now
                },
                new Utvikler()
                {
                    Id = 2,
                    Fornavn = "Pål",
                    Etternavn = "Askeladd",
                    Opprettet = DateTime.Now
                },
                new Utvikler()
                {
                    Id = 3,
                    Fornavn = "Espen",
                    Etternavn = "Askeladd",
                    Opprettet = DateTime.Now
                },
                new Utvikler()
                {
                    Id = 4,
                    Fornavn = "Gunnar",
                    Etternavn = "Askeladd",
                    Opprettet = DateTime.Now
                }
            };

        public UtviklerService()
        {
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
