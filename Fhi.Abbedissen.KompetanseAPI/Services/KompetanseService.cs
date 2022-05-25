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
            }
        };  

        public IEnumerable<Kompetanse> HentKompetanse()
        {
            return _kompetanse; 
        }

        public Kompetanse HentKompetanse(int id)
        {
            return _kompetanse.SingleOrDefault(k => k.Id == id);
        }

        public void LeggTilKompetanse(Kompetanse kompetanse)
        {
            _kompetanse.Add(kompetanse);
        }
    }
}
