using System;
using System.Collections.Generic;
using System.Text;

namespace PetCare.Domain.Model
{
    class Doctor : Person
    {
        public int DoctorId { get; set; }
        public int Matricula { get; set; }
    }
}
