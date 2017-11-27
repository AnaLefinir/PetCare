using System;
using System.Collections.Generic;
using System.Text;

namespace PetCare.Domain.Model
{
    public class Doctor : Person
    {
        //UNIQUE
        public int ID { get; set; }
        //UNIQUE
        public int Matricula { get; set; }

        //FK:
        public User UserId { get; set; }

        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }

    }
}
