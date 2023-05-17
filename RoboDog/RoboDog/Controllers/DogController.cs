using Microsoft.AspNetCore.Mvc;
using RoboDog.Enums;
using RoboDog.Services;
using RoboDog = RoboDog.Models.RoboDog;

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
        public ActionResult AddDog([FromBody] Models.RoboDog doggie)
        {
            DogStorage dogStorage = DogStorage.CreateDogStorage();
            dogStorage.AddDogToList(doggie);
            return Ok($"Name: {doggie.Name} | Breed: {doggie.Breed} | Age: {doggie.Age}");


        }

        [HttpPut("{name}")]
        public ActionResult UpdateDog(string name, Models.RoboDog doggie)
        {
            DogStorage dogStorage = DogStorage.CreateDogStorage();
            Models.RoboDog foundDog = dogStorage.DogFinder(name);
            Models.RoboDog oldDog = new Models.RoboDog(foundDog.Age, foundDog.Name, foundDog.Breed);
            dogStorage.UpdateBreedAndAge(foundDog, doggie);
           
            return Ok($"Name: {name}\n Previous age: {oldDog.Age}, previous breed: {oldDog.Breed}\n New age: {foundDog.Age}, New breed: {foundDog.Breed}\n");
        }
    }
    


}
