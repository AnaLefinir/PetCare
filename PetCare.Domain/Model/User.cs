using System;
using System.Collections.Generic;
using System.Text;

namespace PetCare.Domain.Model
{
    public class User
    {
        //UNIQUE
        public int ID { get; set; }
        //UNIQUE
        public string Username { get; set; }
        //UNIQUE
        public string Password { get; set; }
    }
}
