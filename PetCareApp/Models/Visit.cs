using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetCareApp.Models
{
    public class Visit
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime VisitDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public double VisitPrice { get; set; }
        
        public virtual MedicalHistory MedicalHistory { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<Media> Media { get; set; }
    }
}
