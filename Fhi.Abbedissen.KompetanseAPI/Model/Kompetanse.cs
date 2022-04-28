namespace Fhi.Abbedissen.KompetanseAPI.Model
{
    public class Kompetanse
    {
        public int Id { get; set; }
        public string? Navn { get; set; }
        
        public string? Beskrivelse { get; set; }

        public DateTime OpprettetDato { get; set; }

    }
}
