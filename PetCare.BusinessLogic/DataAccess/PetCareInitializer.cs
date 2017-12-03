using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Data.Entity;
using PetCare.BusinessLogic.Model;


namespace PetCare.BusinessLogic.DataAccess
{
    public class PetCareInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PetCareContext>
    {
        protected override void Seed(PetCareContext context)
        {
            var doctors = new List<Doctor>
            {
                new Doctor {Matricula=4124 },
                new Doctor {Matricula=4123 }
            };

            doctors.ForEach(s => context.Doctors.Add(s));
            context.SaveChanges();

            var pets = new List<Pet>
            {
                    new Pet {Name="Crookshanks", Birthdate=DateTime.Parse("2004-10-28"), Type="Cat" },
                    new Pet {Name="Foxie", Birthdate=DateTime.Parse("2005-02-08"), Type="Dog" },
                    new Pet {Name="Juana", Birthdate=DateTime.Parse("2004-10-28"), Type="Dog" }
            };

            pets.ForEach(s => context.Pets.Add(s));
            context.SaveChanges();
        }
    }
}
