using System.Collections.Generic;
using PetCareApp.Models;

namespace PetCareApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetCareApp.DataAccess.PetCareContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PetCareApp.DataAccess.PetCareContext context)
        {
            
            // TODO: https://stackoverflow.com/questions/28635377/ef6-run-update-database-command-without-seeds
            if (context.Vets.Any())
            {
                return;
            }
              //  This method will be called after migrating to the latest version.

                //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
                //  to avoid creating duplicate seed data.
            Species cat = new Species { Name = "Cat" };
            Species dog = new Species { Name = "Dog" };
            Species lemur = new Species { Name = "Lemur" };

            Owner ana = new Owner { FirstName = "Ana", LastName = "Lefinir", Birthdate = new DateTime(1981, 04, 20), DNI = 34333254, Address = "Av. Corrientes 5514", Genre = Genre.Female, Phone = "1122521580", Email = "analefinir@gmail.com" };
            Owner marin = new Owner { FirstName = "Mariana", LastName = "Ballesteros", Birthdate = new DateTime(1981, 05, 17), DNI = 34333254, Address = "Thompson 680", Genre = Genre.Female, Phone = "1122521580", Email = "marin@gmail.com" };

            MedicalHistory medicalhistoryofpuchun = new MedicalHistory();

            var puchun = new Pet
            {
                Name = "Crookshanks",
                Birthdate = new DateTime(2003, 10, 24),
                Genre = Genre.Female,
                Weight = "5.2kg",
                Neutered = true,
                Description = "La gata mas hermosa sobre la faz de esta Tierra y cualquier Terra",
                Owner = ana,
                Species = cat,
                MedicalHistory = medicalhistoryofpuchun
            };



            var species = new List<Species>
            {
                cat,
                dog,
                lemur
            };
            species.ForEach(s => context.Species.AddOrUpdate(s));
            context.SaveChanges();


            var owners = new List<Owner>
            {
                ana,
                marin
            };

            owners.ForEach(s => context.Owners.AddOrUpdate(s));
            context.SaveChanges();


            var pets = new List<Pet>
            {
                puchun,
                new Pet {Name="Mel", Birthdate = new DateTime(2003, 10, 24), Genre = Genre.Female, Weight = "5.2kg", Neutered = true, Description = "La hermana de la gata mas hermosa sobre la faz de esta Tierra y cualquier Terra", Owner = marin, Species = cat},
                new Pet {Name="Blanqui", Birthdate = new DateTime(2000, 5, 13), Genre = Genre.Male, Weight = "5kg", Neutered = true, Description = "Pequeño cachorro de leon", Owner = marin, Species = cat}
            };

            pets.ForEach(s => context.Pets.AddOrUpdate(s));
            context.SaveChanges();

            var vets = new List<Vet>
            {
                new Vet {FirstName = "Leandro", LastName = "Iglesias", Birthdate = new DateTime(1989, 5, 13), Email = "liglesias@gmail.com", Genre = Genre.Male, Phone = "998855", DNI = 29631590, Address = "Mendoza 565", License = 23556, Password = "Puchun13", IsAdmin = true},
                new Vet {FirstName = "Gloria", LastName = "Iglesias", Birthdate = new DateTime(1989, 5, 13), Email = "giglesias@gmail.com", Genre = Genre.Female, Phone = "998855", DNI = 29631591, Address = "Mendoza 565", License = 23553, Password = "Puchun", IsAdmin = false}
            };

            vets.ForEach(u => context.Vets.AddOrUpdate(u));
            context.SaveChanges();


            var visits = new List<Visit>
            {
                new Visit{ VisitDate = new DateTime(2017,4, 15), Title = "First Visit", Description = "First visit of Puchun. She is well.", VisitPrice = 80, MedicalHistory = medicalhistoryofpuchun},
                new Visit{ VisitDate = new DateTime(2017,8, 15), Title = "Vanucation Anual", Description = "Vacunation.", VisitPrice = 120, MedicalHistory = medicalhistoryofpuchun},
                new Visit{ VisitDate = new DateTime(2017,11, 15), Title = "Revision", Description = "Revision.", VisitPrice = 80, MedicalHistory = medicalhistoryofpuchun}
            };

            visits.ForEach(u => context.Visits.AddOrUpdate(u));
            context.SaveChanges();
        }
    }
}
