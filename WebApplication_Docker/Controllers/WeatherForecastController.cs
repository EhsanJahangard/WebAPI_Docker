using Microsoft.AspNetCore.Mvc;

namespace WebApplication_Docker.Controllers
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


        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _logger.LogInformation("ehsan create api");
        }
        //[HttpGet("GetTruck2")]
        //// public List<TruckViewModel> GetTruck()
        //public TruckViewModel GetTruck2()
        //{
        //    var str = new List<string>();


        //    for (int i = 0; i < 10000; i++)
        //    {
        //        str.Add(i.ToString());
        //    } 

        //}
        //[HttpGet]
        //// public List<TruckViewModel> GetTruck()
        //public TruckViewModel GetTruck()
        //{
        //    var lst = new List<TruckViewModel> {

        //    new TruckViewModel{ Id=2,Age=20,Family="ehsan" },
        //    new TruckViewModel{ Id=111,Age=30,Family="ehsan" },
        //    new TruckViewModel{ Id=221,Age=40,Family="ehsan" },
        //    new TruckViewModel{ Id=331,Age=20,Family="ehsan" },
        //    };

        //    var x = lst.Where(f => f.Id == 1).Select(f => new { ehsan = f.Id, aaa = f.Age });




        //    lst.TrimExcess();


        //    return new TruckViewModel { Id = 1, Age = 20, Family = "ehsan" };

        //}
        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<List<WeatherForecast>> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToList();
        }
    }
}
