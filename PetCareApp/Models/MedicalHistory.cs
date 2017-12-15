using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetCareApp.Models
{
    public class MedicalHistory
    {
        [Key, ForeignKey("Pet")]
        public int Id { get; set; }

        [Required]
        public virtual Pet Pet{ get; set; }
        public virtual List<Visit> Visits { get; set; }
    }
}
