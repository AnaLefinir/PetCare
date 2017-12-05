using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Data.Entity;
using PetCareApp.Models;


namespace PetCareApp.DataAccess
{
    public class PetCareInitializer : System.Data.Entity.DropCreateDatabaseAlways<PetCareContext>
    {
        protected override void Seed(PetCareContext context)
        {
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
