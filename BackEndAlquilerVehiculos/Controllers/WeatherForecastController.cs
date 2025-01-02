using BackEndAlquilerVehiculos.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Dtos;

namespace BackEndAlquilerVehiculos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ApplicationDbContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        [Route("todos")]
        public  List<CarroDto> Get()
        {
            var carros = _context.Carro.Select(c=> new CarroDto
            {
                Costo= c.Costo,
                Disponible= c.Disponible,
                Marca= c.Marca,
                Modelo= c.Modelo,
                Placa= c.Placa,

            }).ToList();
            return carros;

          
        }


    }
}