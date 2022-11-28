using Microsoft.AspNetCore.Mvc;

namespace Primeiro_app.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        [HttpGet("nome")]
        public string RetornaNome()
        {

            return "Leonardo";
        }

        [HttpGet("idade")]
        public int RetornaIdade()
        {

            return 18;
        }

        [HttpPost("nomeRetorno/{nome}")]
        public string PegaNome([FromRoute] string nome)
        {

            return nome;
        }

        [HttpPost("nomeRetorno/{nome}/{idade}")]
        public string PegaNomeEIdade([FromRoute] string nome,[FromRoute] int idade )
        {
            if (idade >= 18)
            {
                return nome + " é maior de idade";
            }
            else
            {
                return nome + " é menor de idade";
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