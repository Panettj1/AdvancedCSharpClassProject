using AdvancedCSharpClassProject.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpClassProject.Classes.BaseClasses
{
    public abstract class Animal : IAnimal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string NotesToSitter { get; set; }
        public Owner Owner { get; set; }
        public int OwnerId { get; set; }
        public string Food { get; set; }

        public string DisplayAnimalInfo()
        {
            throw new NotImplementedException();
        }
    }
}
