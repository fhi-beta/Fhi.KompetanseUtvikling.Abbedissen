using Fhi.Abbedissen.UtviklerAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Fhi.Abbedissen.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class UtviklerProxyController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

    private readonly ILogger<UtviklerProxyController> _logger;
    private readonly IUtviklerController utviklerController;

    public UtviklerProxyController(ILogger<UtviklerProxyController> logger, IUtviklerController utviklerController)
    {
        _logger = logger;
        this.utviklerController = utviklerController;
    }

    [HttpGet]
    public async Task<IEnumerable<UtviklerDTO>> Get()
    {
        var result = await utviklerController.GetUtviklerResponse();
       return result;
    }
}
