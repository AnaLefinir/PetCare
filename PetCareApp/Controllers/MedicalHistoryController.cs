using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetCareApp.Filters;
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
        public ActionResult CreateVisit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MedicalHistory/EditVisit/{VisitId}
        public ActionResult EditVisit(int id)
        {
            var model = _medicalHistoryService.GetEditVisitModel(id);

            return View("Index", model);
        }

        // POST: MedicalHistory/EditVisit/{VisitId}
        [HttpPost]
        public ActionResult EditVisit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
