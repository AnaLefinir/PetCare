using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetCareApp.Models
{
    public class Doctor : Person
    {
        public int License { get; set; }
        
        public virtual User User { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
