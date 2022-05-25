using Fhi.Abbedissen.UtviklerAPI.DTO;
using Refit;

namespace Fhi.Abbedissen.Web.Controllers
{
    public interface IUtviklerController
    {
        [Get("/api/Utvikler")]
        Task<IEnumerable<UtviklerDTO>> GetUtviklerResponse();
    }
}
