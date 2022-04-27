using Fhi.Abbedissen.KompetanseAPI.Model;
using Fhi.Abbedissen.KompetanseAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Fhi.Abbedissen.KompetanseAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KompetanseController : ControllerBase
    {
        public List<Kompetanse> KompetanseDB { get; set; }

        private readonly ILogger<KompetanseController> _logger;
        Kompetanse kompetanse;

        public KompetanseController(ILogger<KompetanseController> logger)
        {
            _logger = logger;
            kompetanse = new Kompetanse();
            kompetanse.Id = 1;
            kompetanse.Navn = "React";
            kompetanse.Beskrivelse = "Klient tekn.";

            KompetanseDB = new List<Kompetanse>();
        }

        [HttpGet(Name = "GetKompetanse")]
        public KompetanseDTO GetKompetanse()
        {
            return new KompetanseDTO(kompetanse);
        }

        [HttpPost(Name = "PostKompetanse")]
        public dynamic PostKompetanse([FromBody] KompetanseDTO kompetanseDTO )
        {
            int index = KompetanseDB.Count + 1;

            var nyttElement = new Kompetanse()
            {
                Navn = kompetanseDTO.Navn,
                Beskrivelse = kompetanseDTO.Beskrivelse,
                Id = index,

            };

            KompetanseDB.Add(nyttElement);

            return Ok();
        }



    }
}