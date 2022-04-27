using Fhi.Abbedissen.KompetanseAPI.Model;
using Fhi.Abbedissen.KompetanseAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Fhi.Abbedissen.KompetanseAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KompetanseController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<KompetanseController> _logger;
        Kompetanse kompetanse;

        public KompetanseController(ILogger<KompetanseController> logger)
        {
            _logger = logger;
            kompetanse = new Kompetanse();
            kompetanse.Id = 1;
            kompetanse.Navn = "React";
            kompetanse.Beskrivelse = "Klient tekn.";
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public KompetanseDTO GetKompetanse()
        {
            return new KompetanseDTO(kompetanse);
        }
    }
}