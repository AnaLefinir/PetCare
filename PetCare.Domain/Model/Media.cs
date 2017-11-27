using System;
using System.Collections.Generic;
using System.Text;

namespace PetCare.Domain.Model
{
    public class Media
    {   
        //UNIQUE
        public int ID { get; set; }

        //FK:
        public virtual Visit VisitId { get; set; }
    }
}
