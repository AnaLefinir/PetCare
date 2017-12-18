using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetCareApp.ModelView.MedicalHistory
{
    public class MedicalHistoryVisitModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}