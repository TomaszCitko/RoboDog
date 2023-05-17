using Microsoft.AspNetCore.Mvc;
using RoboDog.Enums;
using RoboDog.Services;

namespace RoboDog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogController : ControllerBase
    {
        [HttpGet("GetAll")]
        public List<Models.RoboDog> GetAll()
        {
            DogStorage dogStorage = DogStorage.CreateDogStorage();
            List<Models.RoboDog> doggieList = dogStorage.ReturnListOfAllDogs();
            return doggieList;
        }
        [HttpGet("GetRandom")]
        public ActionResult GetRandomDog()
        {
            DogCreator dogCreator = new DogCreator();
            Models.RoboDog doggie = dogCreator.CreateRandomDog();
            DogStorage dogStorage = DogStorage.CreateDogStorage();
            dogStorage.AddDogToList(doggie);
            return Ok($"{doggie.Name}/{doggie.Breed}/{doggie.Age}");
        }

        [HttpPost]
        public ActionResult AddDog([FromBody] int age, int name, int breed)
        {
            DogStorage dogStorage = DogStorage.CreateDogStorage();
            DogName dogName = (DogName)name;
            DogBreed dogBreed = (DogBreed)breed;
            Models.RoboDog doggie = new Models.RoboDog(age, dogName, dogBreed);
            dogStorage.AddDogToList(doggie);
            return Ok($"{doggie.Name} - Breed: {doggie.Breed} - Age: {doggie.Age}");

        }

        [HttpPut("{name}")]
        public ActionResult UpdateDog(DogName dogName)
        {
            DogStorage dogStorage = DogStorage.CreateDogStorage();
            dogStorage.UpdateBreedAndAge(dogName);
            return Ok();
        }
    }
    


}
