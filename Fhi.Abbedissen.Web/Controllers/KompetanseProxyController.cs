using Fhi.Abbedissen.KompetanseAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Fhi.Abbedissen.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class KompetanseProxyController : ControllerBase
{

    private readonly ILogger<KompetanseProxyController> _logger;
    private readonly IKompetanseController KompetanseController;

    public KompetanseProxyController(ILogger<KompetanseProxyController> logger, IKompetanseController KompetanseController)
    {
        _logger = logger;
        this.KompetanseController = KompetanseController;
    }

    [HttpGet]
    public async Task<IEnumerable<KompetanseDTO>> Get()
    {
        var result = await KompetanseController.GetKompetanseResponse();
       return result;
    }
}
