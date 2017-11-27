﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetCare.Domain.Model
{
    public class Owner : Person
    {
        //UNIQUE
        public int ID { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
