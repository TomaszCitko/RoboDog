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

        public void UpdateBreedAndAge(DogName dogName)
        {
            Models.RoboDog doggie = DogsList.Where(x => x.Name == dogName).FirstOrDefault();
            Console.WriteLine("Please input dog's age");
            doggie.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input dog's breed via number (i.e. 1 = Blablador and so on");
            doggie.Breed = (DogBreed)Convert.ToInt32(Console.ReadLine());
        }
    }
}
