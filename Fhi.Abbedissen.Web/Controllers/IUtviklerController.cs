using Fhi.Abbedissen.UtviklerAPI.DTO;
using Refit;

namespace Fhi.Abbedissen.Web.Controllers
{
    public interface v
    {
        [Get("/api/Utvikler")]
        Task<IEnumerable<UtviklerDTO>> GetUtviklerResponse();
    }
}
