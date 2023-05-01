using AdvancedCSharpClassProject.Classes;
using AdvancedCSharpClassProject.Collections;
using AdvancedCSharpClassProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCSharpClassProject
{
    public partial class DatabaseQueryPage : Form
    {
        private readonly ApplicationDbContext applicationDbContext;

        /// <summary>
        /// Initializes page, and setsup combo boxes
        /// </summary>
        public DatabaseQueryPage()
        {
            InitializeComponent();
            applicationDbContext = new ApplicationDbContext();

            AddToDbTypeComboBox.Items.Add("AquaticAnimal");
            AddToDbTypeComboBox.Items.Add("LandAnimal");

            SearchDbTypeComboBox.Items.Add("AquaticAnimal");
            SearchDbTypeComboBox.Items.Add("LandAnimal");
        }


        /// <summary>
        /// Searches Database for animals based off of user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var isValid = true;
            string animalType = SearchDbTypeComboBox.Text;
            string errorMessage = "";
            string animalName = SearchByNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(animalType))
            {
                isValid = false;
                errorMessage = "Please fill out the missing information";
            }

            if (isValid && animalType == "AquaticAnimal")
            {
                var animal = applicationDbContext.AqauticAnimals.Where(aa => aa.Name == animalName).ToList();

                if (!animal.Any())
                {
                    MessageBox.Show("No animal was found with that name");
                }
                else foreach (var aa in animal)
                    {
                        MessageBox.Show($"Animal was found with the name {aa.Name}\n" +
                                        $"It's color is {aa.Color}\n" +
                                        $"And it's age is {aa.Age}");
                    }
            }

            if (isValid && animalType == "LandAnimal")
            {
                var animal = applicationDbContext.LandAnimals.Where(la => la.Name == animalName).ToList();

                if (!animal.Any())
                {
                    MessageBox.Show("No animal was found with that name");
                }
                else foreach (var aa in animal)
                    {
                        MessageBox.Show($"Animal was found with the name {aa.Name}\n" +
                                        $"It's color is {aa.Color}\n" +
                                        $"And it's age is {aa.Age}");
                    }
            }
        }

        /// <summary>
        /// Adds user inputed information into DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToDbSubmitButton_Click(object sender, EventArgs e)
        {
            string animalName = AddToDbNameTextBox.Text;
            int age = Convert.ToInt32(AddAgeToDbNumberUpDown.Value);
            string color = AddToDbColorTextBox.Text;
            string notesToSitter = AddToDbNotesTextBox.Text;
            string animalType = AddToDbTypeComboBox.Text;

            var isValid = true;
            var errorMessage = "";

            if (string.IsNullOrWhiteSpace(animalName) || string.IsNullOrWhiteSpace(animalType) || age == null)
            {
                isValid = false;
                errorMessage = "Please fill out the missing information";
            }

            if (isValid && animalType == "AquaticAnimal")
            {
                var animalCollection = new AnimalCollection<AquaticAnimal>(new ApplicationDbContext());
                var owner = new Owner { Name = "Fish Owner" };

                var animal = new AquaticAnimal();

                animal.Name = animalName;
                animal.Age = age;
                animal.Color = color;
                animal.NotesToSitter = notesToSitter;
                animal.Owner = owner;
                animal.OwnerId = owner.Id;
                animal.Food = "Food";

                // Create a new thread to add the animal to the database
                Thread thread = new Thread(() =>
                {
                    animalCollection.AddAnimalToDatabase(animal);
                });
                thread.Start();

                MessageBox.Show("Successfully added to DB");
            }

            if (isValid && animalType == "LandAnimal")
            {
                var animalCollection = new AnimalCollection<LandAnimals>(new ApplicationDbContext());
                var owner = new Owner {Name = "Land Owner" };

                var animal = new LandAnimals();

                animal.Name = animalName;
                animal.Age = age;
                animal.Color = color;
                animal.NotesToSitter = notesToSitter;
                animal.Owner = owner;
                animal.OwnerId = owner.Id;
                animal.Food = "Food";

                // Create a new thread to add the animal to the database
                Thread thread = new Thread(() =>
                {
                    animalCollection.AddAnimalToDatabase(animal);
                });
                thread.Start();

                MessageBox.Show("Successfully added to DB");
            }
        }
    }
}
