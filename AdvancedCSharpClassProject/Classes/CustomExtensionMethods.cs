using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpClassProject.Classes
{
    public static class CustomExtensionMethods
    {
        public static Action ReUseTryCatch(this Action action)
        {
            return () =>
            {
                try
                {
                    action();
                }
                catch (Exception exception)
                {

                    Console.WriteLine("Exception: " + exception.Message);
                }
            };
        }

        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasData(
                new Owner { Id = 1, Name = "John" }
            );

            modelBuilder.Entity<AquaticAnimal>().HasData(
                new AquaticAnimal
                {
                    Id = -1,
                    Name = "TestAnimal",
                    Color = "Blue",
                    Age = 5,
                    NotesToSitter = "This is a test note, please take good care of my dog",
                    OwnerId = 1,
                    Food = "Fish Filet",
                    Tank = "Large Tank",
                    LightIntensity = 67
                }
            );

            modelBuilder.Entity<LandAnimals>().HasData(
                new LandAnimals
                {
                    Id = -2,
                    Name = "TestAnimal2",
                    Color = "red",
                    Age = 7,
                    NotesToSitter = "This is the second test note, please also take care of my dog",
                    OwnerId = 1,
                    Food = "Kibbles N' Bits",
                    Caged = true,
                    WaterInterval = 3
                }
            );
        }
    }
}
