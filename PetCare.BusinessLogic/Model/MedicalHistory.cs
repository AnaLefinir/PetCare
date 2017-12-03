using System;
using System.Collections.Generic;
using System.Text;

namespace PetCare.BusinessLogic.Model
{
    public class MedicalHistory
    {
        //UNIQUE
        public int MedicalHistoryId { get; set; }

        //UNIQUE - Create FK
        public Pet ID { get; set; }

        public List<Visit> Visits { get; set; }
        //Opcional???
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
