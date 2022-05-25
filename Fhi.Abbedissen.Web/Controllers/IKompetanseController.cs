using Fhi.Abbedissen.KompetanseAPI.DTO;
using Refit;

namespace Fhi.Abbedissen.Web.Controllers
{
    public interface IKompetanseController
    {
        [Get("/Kompetanse")]
        Task<IEnumerable<KompetanseDTO>> GetKompetanseResponse();
    }
}
