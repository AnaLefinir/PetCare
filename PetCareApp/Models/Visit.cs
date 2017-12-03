using System;
using System.Collections.Generic;
using System.Text;

namespace PetCareApp.Models
{
    public class Visit
    {
        //UNIQUE
        public int ID { get; set; }
        public string Description { get; set; }
        //NULL
        public string Title { get; set; }
        public DateTime VisitDate { get; set; }
        //NULL
        public int VisitPrice { get; set; }

        //FK:
        public MedicalHistory MedicalHistoryId { get; set; }
        public Doctor DoctorId { get; set; }

        //Opcional?????
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Media> Media { get; set; }
    }
}
