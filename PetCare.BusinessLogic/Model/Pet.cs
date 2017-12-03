using System;
using System.Collections.Generic;
using System.Text;

namespace PetCare.BusinessLogic.Model
{
    public class Pet
    {
        //UNIQUE
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Type { get; set; }

        //Navigation Property from Owner's FK
        public virtual Owner OwnerId { get; set; }
    }
}
