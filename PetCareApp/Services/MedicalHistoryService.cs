﻿using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using PetCareApp.DataAccess;
using PetCareApp.Models;
using PetCareApp.ModelView.MedicalHistory;

namespace PetCareApp.Services
{
    public class MedicalHistoryService
    {
        private PetCareContext db = new PetCareContext();

        public MedicalHistoryModel GetCreateVisitModel(int petId)
        {
            MedicalHistoryModel model = new MedicalHistoryModel();
            model.IsCreate = true;

            // 1. Buscar el Pet asociado al petId en el dbContext
            var pet = db.Pets.Find(petId);// TODO: include!!!(pre fetch)
            // 2. Asociar los campos requeridos por el model, con los obtenidos del Pet.
            model.PetId = pet.Id;
            model.PetName = pet.Name;
            model.PetGenre = pet.Genre;
            model.PetAge = GetAge(pet.Birthdate);
            model.PetSpecies = pet.Species.Name;
            // 3. Obtener al objeto Ownwer asociado al Pet.
            var owner = pet.Owner;
            // 4. Asociar los campos requeridos por el model, con los obtenidos del Owner.
            model.OwnerId = owner.Id;
            model.OwnerName = $"{owner.FirstName} {owner.LastName}";// String Interpolation
            model.OwnerGenre = owner.Genre;
            model.OwnerPhone = owner.Phone;
            // 5. Crear un objeto de tipo MedicalHistoryActualVisitModel vacio.
            model.Visit = new MedicalHistoryActualVisitModel();
            // 6. Traer las Visits asocidas al Pet.
            List<Visit> visits = pet.MedicalHistory.Visits;
            // 7. Mapear de Visit a MedicalHistoryVisitModel y Agregarlo el mapeo a la lista de Visits.
            model.Visits = visits.Select(visit => MapVisit(visit)).ToList();
            
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

        private MedicalHistoryVisitModel MapVisit(Visit visit)
        {
            return new MedicalHistoryVisitModel
            {
                Id = visit.Id,
                TimeStamp = visit.VisitDate,
                Title = visit.Title
            };
        }

        private int GetAge(DateTime petBirthdate)
        {
            return DateTime.Now.Year - petBirthdate.Year;
        }
    }
}