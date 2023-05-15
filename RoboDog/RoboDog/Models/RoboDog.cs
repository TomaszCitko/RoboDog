using Microsoft.AspNetCore.Mvc.RazorPages;
using RoboDog.Enums;

namespace RoboDog.Models
{
    public class RoboDog
    {
        public int Age { get; set; }
        public DogName Name { get; set; }
        public DogBreed Breed { get; set; }

        public RoboDog(int age, DogName name, DogBreed breed)
        {
            Age = age;
            Name = name;
            Breed = breed;
        }
    }
}



