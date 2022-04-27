using Fhi.Abbedissen.KompetanseAPI.Model;

namespace Fhi.Abbedissen.KompetanseAPI.DTO
{
    public class KompetanseDTO
    {
        public int Id { get; set; }
        public string Navn { get; set; }

        public string Beskrivelse { get; set; }

        public KompetanseDTO(Kompetanse k)
        {
            Navn = k.Navn;
            Beskrivelse = k.Beskrivelse;
            Id = k.Id;
        }
    }


}
