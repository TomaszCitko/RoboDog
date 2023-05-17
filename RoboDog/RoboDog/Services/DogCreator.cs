using System;
using RoboDog.Enums;
using RoboDog.Models;

namespace RoboDog.Services
{
    public class DogCreator
    {
        public Models.RoboDog CreateRandomDog()
        {
            int randomAge = new Random().Next(1,19);
            Array nameValues = Enum.GetValues(typeof(DogName));
            Random randomName = new Random();
            DogName dogName = (DogName)nameValues.GetValue(randomName.Next(nameValues.Length));
            Array breedValues = Enum.GetValues(typeof(DogBreed));
            Random randomBreed = new Random();
            DogBreed dogBreed = (DogBreed)breedValues.GetValue(randomBreed.Next(breedValues.Length));
            return new Models.RoboDog(randomAge, dogName, dogBreed);

        }
    }
}
