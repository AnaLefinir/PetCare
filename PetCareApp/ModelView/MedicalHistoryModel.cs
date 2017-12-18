using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetCareApp.Models;

namespace PetCareApp.ModelView
{
    public class MedicalHistoryModel
    {
        public string PetName { get; set; }
        public Genre PetGenre { get; set; }
        public int PetAge { get; set; }
        public Species PetSpecies { get; set; }

        public string OwnerName { get; set; }
        public Genre OwnerGenre { get; set; }
        public string OwnerPhone { get; set; }


    }
}