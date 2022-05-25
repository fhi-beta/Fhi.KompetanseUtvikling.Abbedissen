using Fhi.Abbedissen.KompetanseAPI.Model;
using Fhi.Abbedissen.Felles;
using Fhi.Abbedissen.KompetanseAPI.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Fhi.Abbedissen.KompetanseAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KompetanseController : ControllerBase
    {
        private readonly IKompetanseService kompetanseService;
        private readonly IMapper mapper;

        public KompetanseController(IKompetanseService service, IMapper mapper)
        {
            this.kompetanseService = service;
            this.mapper = mapper;
        }

        // GET: api/<KompetanseController>
        [HttpGet]
        public ActionResult<IEnumerable<KompetanseDTO>> GetKompetanse()
        {
            var kompetanseListe = kompetanseService.HentKompetanse();

            var kompetanseDTOer = mapper.Map<IEnumerable<KompetanseDTO>>(kompetanseListe);
            
            return Ok(kompetanseDTOer);
        }

        // GET api/<KompetanseController>/5
        [HttpGet("{guid:Guid}")]
        public ActionResult<KompetanseDTO> GetByGuid(Guid guid)
        {
            var kompetanse = kompetanseService.HentKompetanse(guid);

            if (kompetanse == null)
                return NotFound();

            var kompetanseDTO = mapper.Map<KompetanseDTO>(kompetanse);

            return Ok(kompetanseDTO);
        }

        // POST api/<KompetanseController>
        [HttpPost]
        public ActionResult Post([FromBody] KompetanseDTO kompetanseDTO)
        {
            if (kompetanseDTO == null)
                return BadRequest();

            var kompetanse = new Kompetanse()
            {
                Id = kompetanseDTO.Id,
                Navn = kompetanseDTO.Navn,
                Beskrivelse = kompetanseDTO.Beskrivelse                
            };

            kompetanseService.LeggTilKompetanse(kompetanse);
            
            return Ok();
        }
    }
}