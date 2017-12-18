using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetCareApp.Models;

namespace PetCareApp.ModelView.MedicalHistory
{
    public class MedicalHistoryModel
    {
        public bool IsCreate { get; set; }
        public int PetId { get; set; }
        public string PetName { get; set; }
        public Genre PetGenre { get; set; }
        public int PetAge { get; set; }
        public string PetSpecies { get; set; }

        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Genre OwnerGenre { get; set; }
        public string OwnerPhone { get; set; }

        public MedicalHistoryActualVisitModel Visit { get; set; }
        public List<MedicalHistoryVisitModel> Visits { get; set; }
    }
}