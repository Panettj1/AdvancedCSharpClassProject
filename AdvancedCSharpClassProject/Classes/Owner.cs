using AdvancedCSharpClassProject.Classes.BaseClasses;
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
    public class Owner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public List<Animal> Animals { get; set; }
    }
}
