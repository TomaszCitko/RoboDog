using Microsoft.AspNetCore.Mvc;
using RoboDog.Enums;
using RoboDog.Models;
using RoboDog.Services;

namespace RoboDog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogController : ControllerBase
    {
        [HttpGet]
        public List<Models.RoboDog> GetAll()
        {
            DogStorage dogStorage = DogStorage.CreateDogStorage();
            return dogStorage.ReturnListOfAllDogs();
        }
        [HttpGet]
        public Models.RoboDog GetRandomDog()
        {
            DogCreator dogCreator = new DogCreator();
            return dogCreator.CreateRandomDog();
        }

        [HttpPost]
        public void AddDog([FromBody] Models.RoboDog doggie)
        {
            DogStorage dogStorage = DogStorage.CreateDogStorage();
            dogStorage.AddDogToList(doggie);
        }

        [HttpPut("{name}")]
        public void UpdateDog(DogName dogName)
        {
            DogStorage dogStorage = DogStorage.CreateDogStorage();
            dogStorage.UpdateNameAndAge(dogName);
        }
    }
    


}
//        private static readonly string[] Summaries = new[]
//        {
//            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//        };
//    }
//}
    //    private readonly ILogger<DogController> _logger;

//    public DogController(ILogger<DogController> logger)
//    {
//        _logger = logger;
//    }

//    [HttpGet(Name = "GetWeatherForecast")]
//    public IEnumerable<WeatherForecast> Get()
//    {
//        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//        {
//            Date = DateTime.Now.AddDays(index),
//            TemperatureC = Random.Shared.Next(-20, 55),
//            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
//        })
//        .ToArray();
//    }
//}
