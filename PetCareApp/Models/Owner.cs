using System;
using System.Collections.Generic;
using System.Text;

namespace PetCareApp.Models
{
    public class Owner : Person
    {
        public virtual ICollection<Pet> Pets { get; set; }
    }
}
