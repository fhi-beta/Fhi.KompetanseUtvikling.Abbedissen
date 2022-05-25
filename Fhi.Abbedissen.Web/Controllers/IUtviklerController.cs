using Fhi.Abbedissen.Felles;
using Refit;

namespace Fhi.Abbedissen.Web.Controllers
{
    public interface IUtviklerController
    {
        [Get("/api/Utvikler")]
        Task<IEnumerable<UtviklerDTO>> GetUtviklerResponse();
    }
}
