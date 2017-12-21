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
        public DbSet<MedicalHistory> MedicalHistory { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Species> Species { get; set; }

        // Charts
        // https://stackoverflow.com/questions/45483029/how-to-create-a-entityset-or-model-without-creating-corresponding-table-in-datab

        public DbSet<IncomeChartItem> IncomeChartItems { get; set; }
        public DbSet<SpeciesChartItem> SpeciesChartItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<IncomeChartItem>();
            modelBuilder.Ignore<SpeciesChartItem>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
