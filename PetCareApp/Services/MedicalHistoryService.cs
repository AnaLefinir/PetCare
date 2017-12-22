using System;
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
            model.Visit.VisitDate = DateTime.Now;
            // 6. Traer las Visits asocidas al Pet.
            List<Visit> visits = pet.MedicalHistory.Visits;
            // 7. Mapear de Visit a MedicalHistoryVisitModel y Agregarlo el mapeo a la lista de Visits.
            model.Visits = visits.Select(visit => MapVisit(visit)).ToList();
            
            return model;
        }

        public MedicalHistoryModel GetEditVisitModel(int visitId)
        {
            MedicalHistoryModel model = new MedicalHistoryModel();

            model.IsCreate = false;

            var visitToEdit = db.Visits.Find(visitId);
            var pet = visitToEdit.MedicalHistory.Pet;

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

            model.Visit.VisitId = visitToEdit.Id;
            model.Visit.VisitDate = visitToEdit.VisitDate;
            model.Visit.Title = visitToEdit.Title;
            model.Visit.Description = visitToEdit.Description;
            model.Visit.VisitPrice = visitToEdit.VisitPrice;

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

        public void CreateVisit(int petId, int vetId, MedicalHistoryActualVisitModel visit)
        {
            var newVisit = new Visit();
            var pet = db.Pets.Find(petId);
            var vet = db.Vets.Find(vetId);

            newVisit.VisitDate = visit.VisitDate;
            newVisit.Title = visit.Title;
            newVisit.Description = visit.Description;
            newVisit.VisitPrice = visit.VisitPrice;
            newVisit.MedicalHistory = pet.MedicalHistory;
            newVisit.Vet = vet;

            db.Visits.Add(newVisit);
            db.SaveChanges();
        }

        public void EditVisit(int petId, MedicalHistoryActualVisitModel visit)
        {
            var pet = db.Pets.Find(petId);
            int visitId = visit.VisitId;

            var visitToEdit = pet.MedicalHistory.Visits.FirstOrDefault(p => p.Id == visitId);

            visitToEdit.VisitDate = visit.VisitDate;
            visitToEdit.Title = visit.Title;
            visitToEdit.Description = visit.Description;
            visitToEdit.VisitPrice = visit.VisitPrice;

            db.SaveChanges();
        }

        public void DeleteVisit(int visitId)
        {
            var visitToDelete = db.Visits.Find(visitId);
            db.Visits.Remove(visitToDelete);

            db.SaveChanges();
        }
    }
}