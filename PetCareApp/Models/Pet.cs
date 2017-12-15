using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace PetCareApp.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public string Weight { get; set; }
        [Required]
        public bool Neutered { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
 
        public virtual MedicalHistory MedicalHistory { get; set; }
        public virtual Species Species { get; set; }
        public virtual Owner Owner { get; set; }
    }
}
