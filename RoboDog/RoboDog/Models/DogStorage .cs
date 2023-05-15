using RoboDog.Enums;
using RoboDog.Services;

namespace RoboDog.Models
{
    public class DogStorage
    {
        public List<RoboDog> DogsList { get; set; } = new List<RoboDog>();

        public void AddDogToList(RoboDog dog)
        {
            DogsList.Add(dog);
        }
        public void AddRandomDogToList()
        {
            DogCreator dogCreator = new DogCreator();
            RoboDog dog = dogCreator.CreateRandomDog();
            DogsList.Add(dog);
        }

        public List<RoboDog> ReturnListOfAllDogs()
        {
            return DogsList;
        }

        public void UpdateNameAndAge(DogName dogName)
        {
            RoboDog doggie = DogsList.Where(x => x.Name == dogName).FirstOrDefault();
            Console.WriteLine("Please input dog's age");
            doggie.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input dog's breed via number (i.e. 1 = Blablador and so on");
            doggie.Breed = (DogBreed)Convert.ToInt32(Console.ReadLine());
        }
    }
}
