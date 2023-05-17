using Newtonsoft.Json.Linq;
using RoboDog.Enums;

namespace RoboDog.Services
{
    public class DogStorage : IDogStorage
    {
        private static DogStorage? _instance { get; set; }
        public List<Models.RoboDog> DogsList { get; set; } = new List<Models.RoboDog>();

        public static DogStorage CreateDogStorage()
        {
            if (_instance == null)
            {
                _instance = new DogStorage();
            }
            return _instance;
        }

        public void AddDogToList(Models.RoboDog dog)
        {
            DogsList.Add(dog);
        }
        public void AddRandomDogToList()
        {
            DogCreator dogCreator = new DogCreator();
            Models.RoboDog dog = dogCreator.CreateRandomDog();
            DogsList.Add(dog);
        }

        public List<Models.RoboDog> ReturnListOfAllDogs()
        {
            return DogsList;
        }

        public Models.RoboDog DogFinder(string name)
        {
            DogName dogName = (DogName)Enum.Parse(typeof(DogName), name);
            Models.RoboDog doggie = DogsList.Where(x => x.Name == dogName).FirstOrDefault();
            return doggie;
        }
        public void UpdateBreedAndAge(Models.RoboDog oldDoggie, Models.RoboDog newDoggie)
        {
            oldDoggie.Age = newDoggie.Age;
            oldDoggie.Breed = newDoggie.Breed;
        }

    }
}
