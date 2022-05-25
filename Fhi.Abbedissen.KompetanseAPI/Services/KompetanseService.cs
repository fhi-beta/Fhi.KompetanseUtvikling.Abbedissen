using Fhi.Abbedissen.KompetanseAPI.Model;

namespace Fhi.Abbedissen.KompetanseAPI.Services
{
    public class KompetanseService : IKompetanseService
    {
        private static List<Kompetanse> _kompetanse = new List<Kompetanse>() {
            new Kompetanse {
                Id = 1,
                Navn = "React",
                Beskrivelse = "Klient tekn."
            },
             new Kompetanse {
                Id = 2,
                Navn = "Automapper",
                Beskrivelse = "Automapper profile.."
            }
        };  

        public IEnumerable<Kompetanse> HentKompetanse()
        {
            return _kompetanse; 
        }

        public Kompetanse HentKompetanse(Guid guid)
        {
            return _kompetanse.SingleOrDefault(k => k.Guid == guid);
        }

        public void LeggTilKompetanse(Kompetanse kompetanse)
        {
            _kompetanse.Add(kompetanse);
        }
    }
}
