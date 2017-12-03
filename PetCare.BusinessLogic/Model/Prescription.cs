using System;
using System.Collections.Generic;
using System.Text;

namespace PetCare.BusinessLogic.Model
{
    public class Prescription
    {
        //UNIQUE
        public int ID { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public string Description { get; set; }
    }
}
