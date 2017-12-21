using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetCareApp.ModelView.MedicalHistory
{
    public class MedicalHistoryActualVisitModel
    {
        public int VisitId { get; set; }
        [DataType(DataType.Date)]
        public DateTime VisitDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public double VisitPrice { get; set; }
    }
}