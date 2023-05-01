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

    //base land animal class inheriting from animal
    public class LandAnimals : BaseClasses.Animal
    {
        public int? WaterInterval { get; set; }
        public bool? Caged { get; set; }

        public string DisplayAnimalInfo()
        {
            return $"The animals name is, {Name} it is {Age} years old.";
        }
        public void Feed()
        {
            // Code for feeding the land animal
        }

        public void Run()
        {
            // Code for running
        }
    }
}
