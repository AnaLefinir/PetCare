using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PetCareApp.Models;


namespace PetCareApp.DataAccess
{
    public class PetCareContext : DbContext
    {
        //The name of the connection string is paddes in to the connstructor
        public PetCareContext() : base("PetCareContext")
        {
        }

        public DbSet<Vet> Vets { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<MedicalHistory> MedicalHistory { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Species> Species { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
