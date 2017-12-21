using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetCareApp.Filters;
using PetCareApp.Models;
using PetCareApp.ModelView.MedicalHistory;
using PetCareApp.Services;

namespace PetCareApp.Controllers
{
    [AdminAuthorizationFilter]
    public class MedicalHistoryController : Controller
    {
        private MedicalHistoryService _medicalHistoryService = new MedicalHistoryService();

        // /MedicalHistory/{PetId} : La creacion de una visita asociada al id del Pet.
        // /MedicalHistory/EditVisit/{VisitId} : Para ver y/o editar una visita antigua.
        
        // GET: MedicalHistory/CreateVisit/{PetId}
        public ActionResult CreateVisit(int id)
        {
            var model = _medicalHistoryService.GetCreateVisitModel(id);

            return View("Index", model);
        }

        // POST: MedicalHistory/CreateVisit/{PetId}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateVisit(int id, [Bind(Include = "VisitDate, Title, Description, VisitPrice")] MedicalHistoryActualVisitModel visit)
        {
            if (ModelState.IsValid)
            {
                int vetId = ((Vet) Session["LoggedUser"]).Id;
                _medicalHistoryService.CreateVisit(id, vetId, visit);
            }

            return RedirectToAction("CreateVisit", new { id = id });
        }

        // GET: MedicalHistory/EditVisit/{VisitId}
        public ActionResult EditVisit(int id)
        {
            var model = _medicalHistoryService.GetEditVisitModel(id);

            return View("Index", model);
        }

        // POST: MedicalHistory/EditVisit/{petId}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditVisit(int id, [Bind(Include = "VisitId, VisitDate, Title, Description, VisitPrice")] MedicalHistoryActualVisitModel visit)
        {
            if (ModelState.IsValid)
            {
                _medicalHistoryService.EditVisit(id, visit);
            }

            return RedirectToAction("CreateVisit", new {id = id});
        }
        
        // POST: MedicalHistory/DeleteVisit/{VisitId}
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
