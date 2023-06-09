﻿using AdvancedCSharpClassProject.Data;
using AdvancedCSharpClassProject.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpClassProject.Collections
{
    public class AnimalCollection<T> where T : IAnimal
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public delegate void AnimalAddedEventHandler(object sender, AnimalAddedEventArgs e);
        public event AnimalAddedEventHandler AnimalAdded;

        public AnimalCollection(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        private List<T> animals = new List<T>();

        public void Add(T animal)
        {
            animals.Add(animal);
        }

        public void Remove(T animal)
        {
            animals.Remove(animal);
        }

        public void PrintAllAnimals()
        {
            foreach (T animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}, Color: {animal.Color}");
            }
        }


        public async Task AddAnimalToDatabase<T>(T animal) where T : IAnimal
        {
            try
            {
                var animalAdded = AnimalAdded;

                _applicationDbContext.Add(animal);
                await _applicationDbContext.SaveChangesAsync();

                animalAdded?.Invoke(this, new AnimalAddedEventArgs(animal));
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Inner exception: " + ex.InnerException?.Message);
            }
        }
    }
    public class AnimalAddedEventArgs : EventArgs
    {
        private readonly IAnimal _animal;
        public AnimalAddedEventArgs(IAnimal animal)
        {
            _animal = animal;
        }

        public IAnimal Animal
        {
            get { return _animal; }
        }
    }
}
