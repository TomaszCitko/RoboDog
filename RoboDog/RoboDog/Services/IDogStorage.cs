using System;
using RoboDog.Enums;
using RoboDog.Models;

namespace RoboDog.Services
{
    public interface IDogStorage
    {
        public void AddDogToList(Models.RoboDog dog);

        public void AddRandomDogToList();
        
        public List<Models.RoboDog> ReturnListOfAllDogs();

        public void UpdateBreedAndAge(Models.RoboDog oldDoggie, Models.RoboDog newDoggie);

    }
}
