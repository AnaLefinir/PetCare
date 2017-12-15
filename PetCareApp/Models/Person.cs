using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetCareApp.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public int DNI { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public Genre Genre { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        public int Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
