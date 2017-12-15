using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetCareApp.Models
{
    public class Vet : Person
    {
        [Required]
        public int License { get; set; }
        [EmailAddress, Required]
        public override string Email { get; set; }
        [Required]
        public virtual User User { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
