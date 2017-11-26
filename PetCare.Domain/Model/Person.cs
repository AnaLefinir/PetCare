using System;
using System.Collections.Generic;
using System.Text;

namespace PetCare.Domain.Model
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}
