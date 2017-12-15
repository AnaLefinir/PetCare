using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetCareApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Username { get; set; }
        [Required]
        [MaxLength(10)]
        public string Password { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
    }
}
