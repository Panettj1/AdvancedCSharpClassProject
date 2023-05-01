using AdvancedCSharpClassProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpClassProject.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        string Color { get; set; }
        string Food { get; set; }
        string NotesToSitter { get; set; }
        public Owner Owner { get; set; }
        public int OwnerId { get; set; }
        public string DisplayAnimalInfo();
        public void Feed()
        {

        }
    }
}
