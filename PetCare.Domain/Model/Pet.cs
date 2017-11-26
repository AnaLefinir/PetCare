using System;
using System.Collections.Generic;
using System.Text;

namespace PetCare.Domain.Model
{
    class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Type { get; set; }

    }
}
