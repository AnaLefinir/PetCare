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
            Species cat = new Species { Name = "Cat" };
            Species dog = new Species { Name = "Dog" };
            Species lemur = new Species { Name = "Lemur" };

            var species = new List<Species>
            {
                cat,
                dog,
                lemur
            };
            species.ForEach(s => context.Species.Add(s));
            context.SaveChanges();

            Owner ana = new Owner { FirstName = "Ana", LastName = "Lefinir", Birthdate = new DateTime(1981, 04, 20), DNI = 34333254, Address = "Av. Corrientes 5514", Genre = Genre.Female, Phone = "1122521580", Email = "analefinir@gmail.com" };
            Owner marin = new Owner { FirstName = "Mariana", LastName = "Ballesteros", Birthdate = new DateTime(1981, 05, 17), DNI = 34333254, Address = "Thompson 680", Genre = Genre.Female, Phone = "1122521580", Email = "marin@gmail.com" };

            var owners = new List<Owner>
            {
                ana,
                marin
            };
            
            owners.ForEach(s => context.Owners.Add(s));
            context.SaveChanges();

            var pets = new List<Pet>
            {
                new Pet {Name="Crookshanks", Birthdate = new DateTime(2003, 10, 24), Genre = Genre.Female, Weight = "5.2kg", Neutered = true, Description = "La gata mas hermosa sobre la faz de esta Tierra y cualquier Terra", Owner = ana, Species = cat},
                new Pet {Name="Mel", Birthdate = new DateTime(2003, 10, 24), Genre = Genre.Female, Weight = "5.2kg", Neutered = true, Description = "La hermana de la gata mas hermosa sobre la faz de esta Tierra y cualquier Terra", Owner = marin, Species = cat},
                new Pet {Name="Blanqui", Birthdate = new DateTime(2000, 5, 13), Genre = Genre.Male, Weight = "5kg", Neutered = true, Description = "Pequeño cachorro de leon", Owner = marin, Species = cat}
            };

            pets.ForEach(s => context.Pets.Add(s));
            context.SaveChanges();

            var vets = new List<Vet>
            {
                new Vet {FirstName = "Leandro", LastName = "Iglesias", Birthdate = new DateTime(1989, 5, 13), Email = "lIglesias@gmail.com", Genre = Genre.Male, Phone = "998855", DNI = 29631590, Address = "Mendoza 565", License = 23556, Password = "Puchun13" }
            };

            vets.ForEach(u => context.Vets.Add(u));
            context.SaveChanges();
        }
    }
}
