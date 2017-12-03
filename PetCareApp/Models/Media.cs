using System;
using System.Collections.Generic;
using System.Text;

namespace PetCareApp.Models
{
    public class Media
    {   
        //UNIQUE
        public int ID { get; set; }

        //FK:
        public virtual Visit VisitId { get; set; }
    }
}
