using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Primeiro_app.dataModel;

namespace Primeiro_app.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        //[HttpGet("nome")]
        //public string RetornaNome()
        //{

        //    return "Leonardo";
        //}

        //[HttpGet("idade")]
        //public int RetornaIdade()
        //{

        //    return 18;
        //}

        //[HttpPost("nomeRetorno/{nome}")]
        //public string PegaNome([FromRoute] string nome)
        //{

        //    return nome;
        //}

        //[HttpPost("nomeRetorno/{nome}/{idade}")]
        //public string PegaNomeEIdade([FromRoute] string nome,[FromRoute] int idade )
        //{
        //    if (idade >= 18)
        //    {
        //        return nome + " é maior de idade";
        //    }
        //    else
        //    {
        //        return nome + " é menor de idade";
        //    }
            
        //}

        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> getAllAsync([FromServices] Context contexto)
        {
            var pessoas = await contexto.Pessoas.AsNoTracking().ToListAsync();
            return pessoas == null ? NotFound() : Ok(pessoas);
        }

        [HttpGet]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> getByIdAsync([FromServices] Context contexto, [FromRoute] int id)
        {
            var pessoa = await contexto.Pessoas.AsNoTracking().FirstOrDefaultAsync(p => p.id == id);
            return pessoa == null ? NotFound() : Ok(pessoa);
        }

        [HttpPost]
        [Route("pessoas")]

        public async Task<IActionResult> PostAsync([FromServices] Context contexto, [FromBody] Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await contexto.Pessoas.AddAsync(pessoa);
                await contexto.SaveChangesAsync();
                return Created($"api/pessoas/{pessoa.id}", pessoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
               
            }
        }

        [HttpPut]
        [Route("pessoas/{id}")]

        public async Task<IActionResult> PutAsync([FromServices] Context contexto, [FromBody] Pessoa pessoa, [FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var p = await contexto.Pessoas.FirstOrDefaultAsync(x => x.id == id);

            if(p == null) return NotFound("Pessoa não encontrada");
            
            try
            {
                p.nome = pessoa.nome;

                contexto.Pessoas.Update(p);
                await contexto.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                
            }
        }

        [HttpDelete]
        [Route("pessoas/{id}")]

        public async Task<IActionResult> DeleteAsync([FromServices] Context contexto, [FromRoute] int id) {
            var p = await contexto.Pessoas.FirstOrDefaultAsync(x => x.id == id);

            if (p == null)
            {
                return BadRequest("Pessoa não encontrada");
            }

            try
            {
                contexto.Pessoas.Remove(p);
                await contexto.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        
        }


        //    private static readonly string[] Summaries = new[]
        //    {
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //private readonly ILogger<ApiController> _logger;

        //public ApiController(ILogger<ApiController> logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}