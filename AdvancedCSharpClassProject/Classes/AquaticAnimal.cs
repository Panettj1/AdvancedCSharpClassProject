using AdvancedCSharpClassProject.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpClassProject.Classes
{

    //base aquatic animal class inheriting from animal
    public class AquaticAnimal : BaseClasses.Animal
    {
        public string? Tank { get; set; }
        public int? LightIntensity { get; set; }

        public string DisplayAnimalInfo()
        {
            return $"The animals name is, {Name} it is {Age} years old.";
        }

        public void Feed()
        {
            Console.WriteLine("The Aqauitic Animal Has been Fed");
        }

        public void Swim()
        {
            Console.WriteLine("The Aqauitic Animal Has Been Out For A Swim");
        }
    }
}
