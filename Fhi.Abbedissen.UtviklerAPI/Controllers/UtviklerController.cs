using Fhi.Abbedissen.UtviklerAPI.DTO;
using Fhi.Abbedissen.UtviklerAPI.Model;
using Fhi.Abbedissen.UtviklerAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fhi.Abbedissen.UtviklerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UtviklerController : ControllerBase
{
    private readonly IUtviklerService utviklerService;

    public UtviklerController(IUtviklerService utviklerService)
    {
        this.utviklerService = utviklerService;
    }
    // GET: api/<UtviklerController>
    [HttpGet]
    public ActionResult<IEnumerable<UtviklerDTO>> Get()
    {
        var utviklere = utviklerService.HentUtviklere();
        var utviklerDTOer = utviklere.Select(u => new UtviklerDTO()
        {
            Id = u.Id,
            Etternavn = u.Etternavn,
            Fornavn = u.Fornavn
        });
        return Ok(utviklerDTOer);
    }

    // GET api/<UtviklerController>/5
    [HttpGet("{id}")]
    public ActionResult<UtviklerDTO> Get(int id)
    {
        var utvikler = utviklerService.HentUtvikler(id);
        if (utvikler == null)
            return NotFound();

        var utviklerDTO = new UtviklerDTO()
        {
            Id = utvikler.Id,
            Etternavn = utvikler.Etternavn,
            Fornavn = utvikler.Fornavn
        };
        return Ok(utviklerDTO);
    }

    // POST api/<UtviklerController>
    [HttpPost]
    public ActionResult Post([FromBody] UtviklerDTO utviklerDTO)
    {
        if (utviklerDTO == null)
            return BadRequest();

        var utvikler = new Utvikler()
        {
            Etternavn = utviklerDTO.Etternavn,
            Fornavn = utviklerDTO.Fornavn,
            Opprettet = DateTime.Now
        };
        utviklerService.LeggTilUtvikler(utvikler);
        return Ok();
    }

    // PUT api/<UtviklerController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<UtviklerController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}

