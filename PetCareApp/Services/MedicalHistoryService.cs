using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetCareApp.Models;
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
            model.OwnerGenre = Genre.Female;
            model.OwnerId = 2;
            model.OwnerName = "Ana Lefiñir";
            model.OwnerPhone = "1122521580";
            model.PetAge = 13;


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