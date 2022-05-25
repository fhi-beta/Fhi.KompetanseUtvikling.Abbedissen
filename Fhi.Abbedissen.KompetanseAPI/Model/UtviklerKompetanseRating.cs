using Fhi.Abbedissen.UtviklerAPI.Model;

namespace Fhi.Abbedissen.KompetanseAPI.Model
{
    public class UtviklerKompetanseRating
    {
        public int Id { get; set; }
        public Utvikler Utvikler { get; set;  }
        public Kompetanse Kompetanse { get; set; }
        public Rating Rating { get; set; }

        public UtviklerKompetanseRating(Utvikler utvikler, Kompetanse kompetanse, Rating rating)
        {
           this.Utvikler = utvikler;
           this.Kompetanse = kompetanse;
           this.Rating = rating;   
        }
    }
}
