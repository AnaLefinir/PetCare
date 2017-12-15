using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Data.Entity;
using System.Security.Cryptography;
using PetCareApp.Models;


namespace PetCareApp.DataAccess
{
    public class PetCareInitializer : System.Data.Entity.DropCreateDatabaseAlways<PetCareContext>
    {
        protected override void Seed(PetCareContext context)
        {
            var species = new List<Species>
            {
                new Species {Name="Cat"},
                new Species {Name="Dog"},
                new Species {Name="Lemur"}
            };
            species.ForEach(s => context.Species.Add(s));
            context.SaveChanges();

            Owner ana = new Owner { FirstName = "Ana", LastName = "Lefinir", Birthdate = new DateTime(1981, 04, 20), DNI = 34333254, Address = "Av. Corrientes 5514", Genre = Genre.Female, Phone = 1122521580, Email = "analefinir@gmail.com" };
            var owners = new List<Owner>
            {
                ana
            };
            
            owners.ForEach(s => context.Owners.Add(s));
            context.SaveChanges();

            var users = new List<User>
            {
                new User {Username = "anita@gmail.com", Password = "1234"}
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();


        }
    }
}
