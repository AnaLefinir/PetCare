using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetCareApp.ModelView.MedicalHistory;

namespace PetCareApp.Services
{
    public class MedicalHistoryService
    {
        public MedicalHistoryModel GetCreateVisitModel (int petId)
        {
            MedicalHistoryModel model = new MedicalHistoryModel();
            model.PetName = "Puchun";
            model.PetId = petId;
            model.IsCreate = true;

            return model;
        }

        public MedicalHistoryModel GetEditVisitModel(int visitId)
        {
            MedicalHistoryModel model = new MedicalHistoryModel();
            model.PetName = "Puchun";
            model.Visit = new MedicalHistoryActualVisitModel();
            model.Visit.Id = visitId;
            model.IsCreate = false;

            return model;
        }
    }
}